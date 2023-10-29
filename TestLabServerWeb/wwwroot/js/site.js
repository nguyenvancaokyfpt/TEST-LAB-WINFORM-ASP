// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(() => {
    var connection = new signalR.HubConnectionBuilder()
        .withUrl("/signalrServer")
        .build();
    connection.start();

    connection.on("SaveAnswerResult", (s, i) => {
        if (s == 1) {
            // button
            var button = $("button[tl-answer-id='" + i + "']");
            button.removeClass("btn-outline-primary");
            button.addClass("btn-primary");
            button.attr("tl-button-answer", "1");
        }
        else {
            // button
            var button = $("button[tl-answer-id='" + i + "']");
            button.removeClass("btn-primary");
            button.addClass("btn-outline-primary");
            button.attr("tl-button-answer", "0");
        }
    });

    //// Send hello message to server every 5 seconds
    //setInterval(() => {
    //    connection.invoke("Hello", "Hello from client");
    //}, 5000);

    // Get all button with attribute tl-button-answer
    var buttons = $("button[tl-button-answer]");
    var userId = $("#tl-user-id").val();
    var paperid = $("#tl-paper-id").val();
    if (buttons.length != 0) {
        for (var i = 0; i < buttons.length; i++) {
            buttons[i].addEventListener('click', function () {
                var answerId = this.getAttribute("tl-answer-id");
                var questionId = this.getAttribute("tl-question-id");
                // Change button color
                // if tl-button-answer = 0 then change to 1
                // if tl-button-answer = 1 then change to 0
                if (this.getAttribute("tl-button-answer") == "0") {
                    // Send answer to server
                    connection.invoke("SelectAnswer", userId, paperid, questionId, answerId);
                } else {
                    // Send answer to server
                    connection.invoke("UnSelectAnswer", userId, paperid, questionId, answerId);
                }
            });
        }
    }


});