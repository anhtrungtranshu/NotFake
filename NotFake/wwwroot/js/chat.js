$(document).ready(function () {
    "use strict";

    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

    //Disable send button until connection is established
    $("#sendButton").attr("disabled", true);

    connection.on("ActiveConnections", function (data) {
        console.log("list of Groups", data);
    })

    var postMeTemp = `
    <div class="col-md-8 offset-md-4">
        <div class="float-right text-right posts-content posts-content_me mt-2 mb-2 p-2">
            <p>{0}</p>
        </div>
    </div>
    `;

    var postOtherTemp = `
        <div class="col-md-8">
            <div class="posts-content mt-2 m mb-2 p-2">
                <p>{0}</p>
            </div>
            <p class="post-title text-primary">{1} say: <span>{2}</span></p>
        </div>
    `;


    connection.on("ReceiveMessage", function (user, message) {
        console.log("message", message);
        var msg = StringFormat(postMeTemp, message);
        console.log(msg);
        $("#messagesList").append(msg);

        // var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");

        // var encodedMsg = user + " says " + msg;
        // var li = document.createElement("li");
        // li.textContent = encodedMsg;
        // document.getElementById("messagesList").appendChild(li);
    });

    connection.start().then(function () {
        $("#sendButton").attr("disabled", false);
    }).catch(function (err) {
        return console.error(err.toString());
    });

    // $("#sendButton").click(function (e) {

    //     var user = $("#userInput").val();

    // })

    // $("#postsForm").submit(function (e) {
    //     e.preventDefault();
    //     console.log($(this).serialize());
    // })

    $("#sendButton").click(function (e) {
        e.preventDefault();
        var formValue = $("#postsForm").serializeArray();
        console.log(formValue);
        var msg = ArrayToJSON(formValue);
        console.log("msg", msg);
        if (connection) {
            connection.invoke("SendMessage", msg.user, msg.message)
                .catch(function (err) {
                    return console.error(err.toString());
                })
        }
    })

    // document.getElementById("sendButton").addEventListener("click", function (event) {
    //     var user = document.getElementById("userInput").value; // takes user value
    //     var message = document.getElementById("messageInput").value; // takes message value - Doesn't change
    //     connection.invoke("SendMessage", user, message).catch(function (err) {
    //         return console.error(err.toString()); // calls Send Message in the Chat Hub and passes the message and user
    //     });
    //     event.preventDefault();
    // });

    // $("#messageInput").on("keydown", function (e) {
    //     console.log(e.target.value);

    //     if (e.which == 13) {
    //         console.log(e.target.value);
    //     }
    // })
})


function ArrayToJSON(arr) {
    return arr.reduce((a, b, i) => {
        a[b.name] = b.value;
        return a;
    }, {})
}

function StringFormat(tempt) {
    var rg = /\{\d+\}/g;
    return tempt.replace(rg, function (match) {
        var idx = +(/\d+/.exec(match));
        if (arguments[idx + 1]) {
            return arguments[idx + 1];
        } else {
            return match;
        }
    });
}
