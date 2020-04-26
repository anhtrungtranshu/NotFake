// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var isChatWithFriend = false;
    var isGroupAdmin = false;
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    });

    // slick
    $(".slick-carousel__home").slick({
        lazyLoad: 'ondemand',
        slidesToShow: 4,
        slidesToScroll: 2,
        prevArrow: "<button class='slic-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slic-next slick-arrow'><i class='fas fa-chevron-right'></i></button>"
    });

    $(".slick-carousel__detail").slick({
        slidesToShow: 4,
        slidesToScroll: 2,
        prevArrow: "<button class='slic-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slic-next slick-arrow'><i class='fas fa-chevron-right'></i></button>"
    });

    // notify
    $.notify.addStyle('chat-confirm', {
        html:
            "<div>" +
            "<div class='clearfix notification'>" +
            "<div class='title' data-notify-html='title'/>" +
            "<div class='buttons d-flex'>" +
            "<button class='btn btn-outline-secondary disabled no'>Cancel</button>" +
            "<button class='btn btn-outline-primary yes'>Ok</button>" +
            "</div>" +
            "</div>" +
            "</div>"
    });

    // notification temp
    $.notify.addStyle('notification', {
        html:
            "<div>" +
            "<div class='clearfix notification'>" +
            "<div class='title' data-notify-html='title'/>" +
            "</div>" +
            "</div>"
    });

    $.notify.addStyle('post-message', {
        html:
            "<div style='z-index:999'>" +
            "<div class='clearfix notification'>" +
            "<div class='post-content' data-notify-html='content'/>" +
            "<div class='post-title' data-notify-html='title'/>" +
            "</div>" +
            "</div>"
    })

    // startup chatHub
    var isChatExpanded = false;

    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
    connection.start().then(function () {
        console.log("connection starts");
        var userEmail = "";
        var formValue = "";
        if ($("#CurrentUserEmail").length && $("#CurrentUserEmail").val() && $("#CurrentUserEmail").val() != "") {
            userEmail = $("#CurrentUserEmail").val();
        }

        if ($("#postsForm").length) {
            // check if there is a group in localStorage
            // var groupName = localStorage.getItem("hubGroupName");
            // if (groupName != undefined && groupName != null) {
            //     $("#groupName").val(groupName);
            // }

            var _postForm = ArrayToJSON($("#postsForm").serializeArray());
            formValue = JSON.stringify(_postForm);
        }
        connection.invoke("Authorize", userEmail, formValue, false);

        // get friends of User
        if ($(".user-profile").length) {
            var data = {
                email: $("#CurrentUserEmail").val(),
                keyword: $("#friendListKeyword").val(),
            };
            connection.invoke("GetUserFriendList", JSON.stringify(data));
        }
    }).catch(function (err) {
        return console.error(err.toString());
    });

    connection.on("Authorized", function (data) {
        console.log("Authorized");
        console.log(data);
        console.log(data && data.groupName);
        if (data && data.groupName) {
            // store GroupName in local storge in case user refresh browser
            localStorage.setItem("hubGroupName", data.groupName);
            $("input#groupName").val(data.groupName);

            isChatWithFriend = true;
            $("#filmLayout > div:first-child").addClass("video-shirk");
            $("#filmLayout > div:last-child").addClass("chat-show");
            isChatExpanded = true;

            // display previous posts
            if (data.posts) {
                data.posts.forEach(function (post) {
                    AppendMessage(post);
                })
            }

            // display group members and status
            if (data.members.length > 0) {
                $("#groupMemberList").empty();
                appendGroupMemberToList(data.members)
            }

            isGroupAdmin = data.isGroupAdmin;
            if (!isGroupAdmin) {
                $("#video-progress").append("<div class='progress-bar root-bar' id='rootProgressBar' role='progressbar' aria-valuenow='75' aria-valuemin='0' aria-valuemax='100' style='width: 0%'></div>")
            }
        }
    })

    connection.on("GroupMembersChange", function (data) {
        $("#groupMemberList").empty();
        appendGroupMemberToList(data);
    })

    function appendGroupMemberToList(list) {
        var temp = `
        <div class="col-12 member-of-group p-2" data-email="{0}">
            <p class="m-0 member-name">{1}</p>
        </div>
        `;
        var html = list.reduce(function (a, b) {
            return a += StringFormat(temp, [b.userEmail, b.userName]);
        }, "");
        $("#groupMemberList").append(html);
    }

    connection.on("ChatRequireAction", function (data) {
        $.notify({
            title: data.message
        }, {
            style: "chat-confirm",
            autoHide: false,
            clickToHide: false
        })
    })

    //listen for click events from this style
    $(document).on('click', '.notifyjs-chat-confirm-base .no', function () {
        ConfirmCreateGroup(false);
        $(this).trigger('notify-hide');
    });

    $(document).on('click', '.notifyjs-chat-confirm-base .yes', function () {
        ConfirmCreateGroup(true);
        $(this).trigger('notify-hide');
    });

    function ConfirmCreateGroup(usePreviousGroup) {
        if (connection) {
            var userEmail = "";
            var formValue = "";
            if ($("#CurrentUserEmail").length && $("#CurrentUserEmail").val() && $("#CurrentUserEmail").val() != "") {
                userEmail = $("#CurrentUserEmail").val();
            }

            if ($("#postsForm").length) {
                var _postForm = ArrayToJSON($("#postsForm").serializeArray());
                formValue = JSON.stringify(_postForm);
            }

            connection.invoke("CreateGroup", userEmail, formValue, usePreviousGroup);
        } else {
            console.error("Connection is no established");
        }
    }

    connection.on("Error", function (data) {
        console.error(data.message);
    })

    connection.on("ReceiveMessage", function (data) {
        $.notify({
            content: data.message,
            title: data.userName
        }, {
            style: "post-message",
            autoHide: true,
        })
        AppendMessage(data);
        // var msg = data.userEmail == $("#CurrentUserEmail").val() ? StringFormat(postMeTemp, [data.message, moment(data.created).format("YYYY-MM-DD HH:MM")])
        //     : StringFormat(postOtherTemp, [data.message, data.userName, moment(data.created).format("YYYY-MM-DD HH:MM")]);

        // if ($("#messagesList")) {
        //     $("#messagesList").append(msg);
        // }

    });

    function AppendMessage(post) {
        var postMeTemp = `
        <div class="col-md-8 offset-md-4">
            <div class="posts-content posts-content_me mt-2 p-2">
                {0}
                <span class="post-title text-primary">{1}</span>
            </div>
        </div>
        `;

        var postOtherTemp = `
        <div class="col-md-8">
            <div class="posts-content mt-2 m p-2">
                {0}
                <span class="post-title text-primary">{1} - <span>{2}</span></span>
            </div>
        </div>
        `;

        var msg = post.userEmail == $("#CurrentUserEmail").val() ? StringFormat(postMeTemp, [post.message, moment(post.created).format("YYYY-MM-DD HH:MM")])
            : StringFormat(postOtherTemp, [post.message, post.userName, moment(post.created).format("YYYY-MM-DD HH:MM")]);

        if ($("#messagesList")) {
            $("#messagesList").append(msg);
        }
        $("#messagesList").animate({ scrollTop: $("#messagesList").height() }, 0);
    }

    $("#messageInput").keydown(function (e) {
        var code = e.keyCode || e.which;
        if (code == 13) {
            var msg = ArrayToJSON($("#postsForm").serializeArray());
            msg.UserEmail = $("#CurrentUserEmail").val();

            if (connection) {
                connection.invoke("SendMessage", JSON.stringify(msg))
                    .catch(function (err) {
                        return console.error(err.toString());
                    })
            }
            $("#messageInput").val("");
        }
    })

    $("#chatGroup").click(function (e) {
        if (!isChatWithFriend) {

            var userEmail = "";
            var formValue = "";
            if ($("#CurrentUserEmail").length && $("#CurrentUserEmail").val() && $("#CurrentUserEmail").val() != "") {
                userEmail = $("#CurrentUserEmail").val();
            }

            if ($("#postsForm").length) {
                var _postForm = ArrayToJSON($("#postsForm").serializeArray());
                formValue = JSON.stringify(_postForm);
            }

            if (!connection) console.error("connection failed");

            connection.invoke("Authorize", userEmail, formValue, true);
        }

        if (isChatExpanded) {
            $("#filmLayout > div:first-child").removeClass("video-shirk");
            $("#filmLayout > div:last-child").removeClass("chat-show");
        } else {
            $("#filmLayout > div:first-child").addClass("video-shirk");
            $("#filmLayout > div:last-child").addClass("chat-show");
        }
        isChatExpanded = !isChatExpanded;
    })

    $("#chatPanelHideButton").click(function () {
        $("#filmLayout > div:first-child").removeClass("video-shirk");
        $("#filmLayout > div:last-child").removeClass("chat-show");
        isChatExpanded = false;
    })




    connection.on("GetUserFriendList", function (data) {
        console.log(data);
        $("#friendList tbody").empty();

        var friendItemHtml = `
            <tr>
                <td>{0}</td>
                <td>{1}</td>
            </tr>
        `
        if (data.length > 0) {
            var listOfFriendsHtml = data.reduce(function (a, b, i) {
                return a += StringFormat(friendItemHtml, [i + 1, b.userName]);
            }, "");

            $("#friendList tbody").append(listOfFriendsHtml);
        } else {
            $("#friendList tbody").append("<tr><td colspan='2'>You have no friends, so sad!!</td></tr>")
        }

    })

    $("#friendSuggestions").on("input", function (e) {
        var data = {
            email: $("#CurrentUserEmail").val(),
            keyword: e.target.value,
        };
        console.log(data);
        connection.invoke("GetFriendSuggestions", JSON.stringify(data));
    });

    connection.on("GetFriendSuggestions", function (data) {
        console.log(data);

        var keyword = $("#friendSuggestions").val();
        $("#friendSuggestionList tbody").empty();
        var friendSuggestionTemp = `
            <tr>
                <td>
                    <p class='m-0'>{0}</p>
                    <span style='font-size: .625rem'>{1}</span>
                </td>
                <td>
                    <button class='btn btn-primary btn-sm send-friend-request-btn'>Send Request</button>
                    <input type='hidden' value='{2}' />
                </td>
            </tr>
        `;

        var friendSgtHtml = data.reduce(function (a, b) {
            var _userName = b.userName.replace(keyword, StringFormat("<strong class='text-primary'>{0}</strong>", [keyword]));
            var _userEmail = b.userEmail.replace(keyword, StringFormat("<strong class='text-primary'>{0}</strong>", [keyword]));

            return a += StringFormat(friendSuggestionTemp, [_userName, _userEmail, b.userEmail]);
        }, "");

        $("#friendSuggestionList tbody").append(friendSgtHtml);
    });

    $("#friendSuggestionList").on("click", "button", function (e) {
        var data = {
            email: $("#CurrentUserEmail").val(),
            requestTo: $(this).next().val()
        }

        connection.invoke("RequestFriend", JSON.stringify(data));
    })

    connection.on("RequestFriend", function (data) {
        $.notify({
            title: data.message
        }, {
            style: "notification",
            autoHide: true,
        })
    })

    function newRequestHandler(message, target, requestType) {

        if ($("#incomingFriendRequestsMenu .dropdown-item[disabled]").length) {
            $("#incomingFriendRequestsMenu").empty();
            $("#pendingFriendRequests").removeClass("d-none");
            $("#pendingFriendRequests").html("1");
        } else {
            $("#pendingFriendRequests").html($("#incomingFriendRequestsMenu .dropdown-item").length + 1);
        }

        var frmTemp = `
            <a class="dropdown-item" data-email="{0}">
                <div class="d-flex align-items-center">
                    <span style="white-space:break-spaces; width: 15rem; display: inline-block">{1}</span>
                    <div class="btn-group" role="group" aria-label="request action">
                        <button type="button" class="btn btn-icon-secondary request-action-btn-no">
                            <i class="fas fa-ban"></i>
                        </button>
                        <button type="button" class="btn btn-icon-primary request-action-btn-yes">
                            <i class="fas fa-check"></i>
                        </button>
                        <input type="hidden" name="target" value="{2}" />
                        <input type="hidden" name="requestType" value={3} />
                    </div>
                </div>
            </a>`;

        var frmHtml = StringFormat(frmTemp, [
            target,
            message,
            target,
            requestType
        ])
        $("#incomingFriendRequestsMenu").append(frmHtml);

    }

    connection.on("IncommingFriendRequest", function (data) {
        $.notify({
            title: StringFormat("{0} sent you a friend request!", [data.invitingUserName])
        }, {
            style: "notification",
            autoHide: true
        })

        newRequestHandler(
            StringFormat("{0} sent you a friend request", [data.invitingUserName]),
            data.invitingUserEmail,
            "friendRequest"
        );

    })

    // Film invitation
    connection.on("NewFilmInvitation", function (data) {
        $.notify({
            title: data.message
        }, {
            style: "notification",
            autoHide: true
        })

        newRequestHandler(

            data.message,
            data.invitationId,
            "filmRequest"
        );
    })


    $("#incomingFriendRequestsMenu").on("click", "button", function (e) {
        e.stopPropagation();
        var isAccepted = $(this).hasClass("request-action-btn-no") ? false : true;

        var requestType = $(this).parent().find("input[name*='requestType']").val();
        if (requestType == "friendRequest") {
            var invitingUserEmail = $(this).parent().find("input[name*='target']").val();

            var data = {
                invitedUserEmail: $("#CurrentUserEmail").val(),
                invitingUserEmail: invitingUserEmail,
                isAccepted: isAccepted
            };

            $.post("/api/Friendship/FriendRequestAction", data, function (res) {
                if (res.success) {
                    $("#incomingFriendRequestsMenu").find("a.dropdown-item[data-email*='" + invitingUserEmail + "']").remove();
                    if (!$("#incomingFriendRequestsMenu a.dropdown-item").length) {
                        $("#pendingFriendRequests").addClass("d-none");
                        $("#pendingFriendRequests").html("0");
                        $("#incomingFriendRequestsMenu").append("<a class='dropdown-item' disabled>Oops! There is nothing new!</a>");
                    } else {
                        $("#pendingFriendRequests").html($("#incomingFriendRequestsMenu a.dropdown-item").length);
                    }
                }
            })

        } else {
            var invitationId = $(this).parent().find("input[name*='target']").val();
            var data = {
                invitedUserEmail: $("#CurrentUserEmail").val(),
                invitationId: invitationId,
                isAccepted: isAccepted
            }

            connection.invoke("FriendResponseToJoinGroup", JSON.stringify(data));

            $("#incomingFriendRequestsMenu").find("a.dropdown-item[data-email*='" + invitationId + "']").remove();
            if (!$("#incomingFriendRequestsMenu a.dropdown-item").length) {
                $("#pendingFriendRequests").addClass("d-none");
                $("#pendingFriendRequests").html("0");
                $("#incomingFriendRequestsMenu").append("<a class='dropdown-item' disabled>Oops! There is nothing new!</a>");
            } else {
                $("#pendingFriendRequests").html($("#incomingFriendRequestsMenu a.dropdown-item").length);
            }
        }

    })

    connection.on("UserJoinGroup", function (data) {
        var host = "http://" + window.location.host;
        var path = "/Film/WatchWithGroup";
        var params = StringFormat("?filmId={0}&groupName={1}", [data.filmId, data.groupName]);
        window.location.href = StringFormat("{0}{1}{2}", [host, path, params]);
    })



    // get friend suggestions from hubs

    connection.on("GroupFriendSuggestions", function (data) {
        console.log(data);
        $("#autocomplete-list").empty();
        var userTemp = `
            <div class="friend-suggestion-item">
                <span>{0}</span>
                <button class="btn btn-outline-primary">Send Request</button>
                <input type="hidden" value="{1}" />
            </div>
        `;

        $("#autocomplete-list").append(
            data.reduce(function (a, b) {
                return a += StringFormat(userTemp, [b.userName, b.userEmail]);
            }, "")
        )
    })

    $("#groupFriendSuggestionAuto").parent().on("click", "button", function (e) {
        e.preventDefault();
        e.stopPropagation();
        console.log($(this));

        var data = {
            // email: $("#CurrentUserEmail"),
            groupName: $("#groupName").val(),
            gUserEmail: $(this).next().val()
        };

        if (connection) {
            connection.invoke("RequestFriendJoinGroup", JSON.stringify(data))
        }
    })

    connection.on("RequestFriendJoinGroup", function (data) {
        $.notify({
            title: data.message
        }, {
            style: "notification",
            autoHide: true,
        })
    })

    // autocomplete group friend suggestions field in chat feature
    autocomplete($("#groupFriendSuggestionAuto"))

    // AutoComplete Bootstrap

    function autocomplete(inp) {
        /*the autocomplete function takes two arguments,
        the text field element and an array of possible autocompleted values:*/
        var currentFocus;
        /*execute a function when someone writes in the text field:*/
        $(inp).on("input", function (e) {
            var a,
                b,
                i;
            // keyword = this.value;

            var keyword = e.target.value;
            console.log(keyword);
            /*close any already open lists of autocompleted values*/
            closeAllLists();
            if (!keyword) { return false; }
            currentFocus = -1;

            $(this).parent().append(`
                <div class="autocomplete-items" id="autocomplete-list">
                    <span>loading</span>
                </div>
            `);

            if (connection) {
                var data = {
                    email: $("#CurrentUserEmail").val(),
                    keyword: keyword
                }
                connection.invoke("GroupFriendSuggestions", JSON.stringify(data));
            }
        });

        function closeAllLists(elmnt) {
            /*close all autocomplete lists in the document,
            except the one passed as an argument:*/
            var x = document.getElementsByClassName("autocomplete-items");
            for (var i = 0; i < x.length; i++) {
                if (elmnt != x[i] && elmnt != inp) {
                    x[i].parentNode.removeChild(x[i]);
                }
            }
        }
        /*execute a function when someone clicks in the document:*/
        document.addEventListener("click", function (e) {
            closeAllLists(e.target);
        });
    }

    var isFullScreen = false;

    // full screen
    $("#expand-collapse-button").click(function (e) {
        if (!isFullScreen) {
            var el = document.documentElement
                , rfs = // for newer Webkit and Firefox
                    el.requestFullScreen
                    || el.webkitRequestFullScreen
                    || el.mozRequestFullScreen
                    || el.msRequestFullScreen
                ;
            if (typeof rfs != "undefined" && rfs) {
                rfs.call(el);
            } else if (typeof window.ActiveXObject != "undefined") {
                // for Internet Explorer
                var wscript = new ActiveXObject("WScript.Shell");
                if (wscript != null) {
                    wscript.SendKeys("{F11}");
                }
            }
            $("#videoThumbnail").addClass("fullscreen");
            $("#mainNav").addClass("video-fullscreen");
            $(".main-film-section__chat-wrapper").addClass("fullsize");
            $(this).empty();
            $(this).append("<i class='fas fa-compress'></i>");

        } else {

            $("#videoThumbnail").removeClass("fullscreen");
            $("#mainNav").removeClass("video-fullscreen");
            $(".main-film-section__chat-wrapper").removeClass("fullsize");
            $(this).empty();
            $(this).append("<i class='fas fa-expand'></i>");

            closeFullscreen();
        }
        isFullScreen = !isFullScreen;
    })

    // custom media controller

    var mediaPlayer = $("#my-video")[0];
    if (mediaPlayer != null && mediaPlayer != undefined) {
        mediaPlayer.ontimeupdate = function () { onVideoTimeUpdate($("#myProgressBar")[0]) }
    }
    mediaPlayer.controls = false;

    $("#play-pause-button").on("click", function () {
        if (mediaPlayer.paused || mediaPlayer.ended) {
            $(this).title = "pause";
            $(this).empty();
            $(this).append("<i class='fas fa-pause'></i>");
            mediaPlayer.play();
        }
        else {
            $(this).title = "pause";
            $(this).empty();
            $(this).append("<i class='fas fa-play'></i>");
            mediaPlayer.pause();
        }
    })

    // updateOnTime
    function onVideoTimeUpdate(element) {
        var mediaPlayer = $("#my-video")[0];
        var duration = mediaPlayer.duration;
        var currentProgress = mediaPlayer.currentTime / duration * 100;
        $(element).css("width", currentProgress + "%");
        console.log("isGroupAdmin", isGroupAdmin);
        if (isGroupAdmin) {
            if (connection) {
                var data = {
                    groupName: $("#groupName").val(),
                    currentProgress: currentProgress
                }
                connection.invoke("AdminVideoTimeUpdate", JSON.stringify(data));
            }
        }
    }

    connection.on("AdminVideoTimeUpdate", function (data) {
        console.log(data);
        if ($("#rootProgressBar").length) {
            $("#rootProgressBar").css("width", data + "%");
        }
    })
})

function closeFullscreen() {
    if (document.exitFullscreen) {
        document.exitFullscreen();
    } else if (document.mozCancelFullScreen) {
        document.mozCancelFullScreen();
    } else if (document.webkitExitFullscreen) {
        document.webkitExitFullscreen();
    } else if (document.msExitFullscreen) {
        document.msExitFullscreen();
    }
}

function ArrayToJSON(arr) {
    return arr.reduce((a, b, i) => {
        a[b.name] = b.value;
        return a;
    }, {})
}

function StringFormat(tempt, params) {
    var rg = /\{\d+\}/g;
    return tempt.replace(rg, function (match) {
        var idx = +(/\d+/.exec(match));
        if (params[idx] != null && params[idx] != undefined) {
            return params[idx];
        } else {
            return match;
        }
    });
}
