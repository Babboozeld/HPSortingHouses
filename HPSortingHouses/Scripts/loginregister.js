var urlParams = new URLSearchParams(window.location.search);
var flaglogin = document.getElementById("login");
var flagregister = document.getElementById("register");
var cButtonl = document.getElementById("cButtonl");
var cButtonr = document.getElementById("cButtonr");

var cButtons = document.querySelectorAll(".cButton");

var request = urlParams.get('request');
if (request == 'register') {
    flagregister.style.top = "0";
    cButtonr.classList.add("active");
} else {
    flaglogin.style.top = "0";
    cButtonl.classList.add("active");
}

function switchlogreg(x) {
    flaglogin.style.top = "-100vh";
    flagregister.style.top = "-100vh";

    cButtons.forEach(function (entry) {
        entry.classList.remove("active");
    });

    if (x.classList.contains("cButtonl")) {
        flaglogin.style.top = "0";
        x.classList.add("active");
    } else if (x.classList.contains("cButtonr")) {
        flagregister.style.top = "0";
        x.classList.add("active");
    }
}



