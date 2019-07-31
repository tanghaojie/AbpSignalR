$.index = {};
$.index.init = {
    signalrInit: function () {
        var msgHub = $.connection.msgHub;
        msgHub.client.msg = function (message) {
            if (message) {
                $.index.init.appendLog(message);
            }
        };

        var msgHubApi = $.connection.msgHubApi;
        msgHubApi.client.msg = function (message) {
            if (message) {
                $.index.init.appendLog(message);
            }
        };
    },

    appendLog: function (text) {
        $('#log-panel').append('<li class="li-log-info">' + text + '</li>');
    },
}

$(function () {
    $.index.init.signalrInit();
    $("#check-btn")[0].onclick = function () {
        $.connection.hub.stop();
        $.connection.hub.start()
            .fail(function () {
                var msg = 'signalR Connection Error';
                console.log(msg);
            })
            .done(function () {
                console.log('signalR Connected');
                $.ajax({
                    type: "Get",
                    url: "/Home/SignalR",
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                });
            });
    }
    $("#check-btn1")[0].onclick = function () {
        $.connection.hub.stop();
        $.connection.hub.start()
            .fail(function () {
                var msg = 'signalR Connection Error';
                console.log(msg);
            })
            .done(function () {
                console.log('signalR Connected');
                $.ajax({
                    type: "Get",
                    url: "/api/myapi/SignalR",
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                });
            });
    }
})