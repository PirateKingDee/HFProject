// Write your JavaScript code.
$(function () {
    $('#calendar').fullCalendar({
        header: {
            left: '',
            center: 'prev title next',
            right: 'month,agendaWeek,agendaDay'
        }
    });

    document.getElementById("return").onclick = function () {
        window.location.href = "../";
    };
});