﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var isChatWithFriend = false;

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
            "<div class='clearfix chat-require-action'>" +
            "<div class='title' data-notify-html='title'/>" +
            "<div class='buttons d-flex'>" +
            "<button class='btn btn-outline-secondary disabled no'>Cancel</button>" +
            "<button class='btn btn-outline-primary yes'>Ok</button>" +
            "</div>" +
            "</div>" +
            "</div>"
    });

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
            var groupName = localStorage.getItem("hubGroupName");
            if (groupName != undefined && groupName != null) {
                $("#groupName").val(groupName);
            }
            var _postForm = ArrayToJSON($("#postsForm").serializeArray());
            formValue = JSON.stringify(_postForm);
        }
        connection.invoke("Authorize", userEmail, formValue, false);

    }).catch(function (err) {
        return console.error(err.toString());
    });

    connection.on("Authorized", function (data) {
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
            if (data.members) {

            }
        }
    })

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
        console.log("click notify no");
        ConfirmCreateGroup(false);
        $(this).trigger('notify-hide');
    });

    $(document).on('click', '.notifyjs-chat-confirm-base .yes', function () {
        console.log("click notify yes");

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
                <span class="post-title text-primary"> {1}<span>{2}</span></span>
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

    $("#testButton").click(function (e) {
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






    // var mediaPlayer = $("#main-video")[0];
    // mediaPlayer.controls = false;

    // $("#play-pause-button").on("click", function () {
    //     if (mediaPlayer.paused || mediaPlayer.ended) {
    //         $(this).title = "pause";
    //         // $(this).empty();
    //         $(this).innerHTML = "<i class='fas fa-pause'></i>";
    //         mediaPlayer.play();
    //     }
    //     else {
    //         $(this).title = "pause";
    //         // $(this).empty();
    //         $(this).innerHTML = "<i class='fas fa-play'></i>";
    //         mediaPlayer.pause();
    //     }
    // })


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

    autocomplete($("#friendSuggestionAuto"))

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
                connection.invoke("GroupFriendSuggestions", keyword)
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


})

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
