/*var fa = "flag-active";

var flag1 = document.getElementById("flag1");
if (flag1 != null) {
    flag1.classList.add(fa);
}
*/

var emblemhouses = document.querySelectorAll(".emblem-house");
var boxhouses = document.querySelectorAll(".box-house");

var flag1 = document.getElementById("flag1");
var flag2 = document.getElementById("flag2");
var bg = document.getElementById("background");
var carouselB = document.getElementById("carousel-buttons");
var cButtons = document.querySelectorAll(".cButton");
flag1.style.top = "-100vh";
flag1.style.top = 0;
emblemBox = document.getElementById("emblem-box");

function switchCarousel(x) {

    /*var activeFlags = document.getElementsByClassName(fa);
    for (var i = 0; i < activeFlags.length; i++) {
        activeFlags[i].classList.remove(fa);
    }*/
    flag1.style.top = "-100vh";
    flag2.style.top = "-100vh";

    cButtons.forEach(function(entry) {
        entry.classList.remove("active");
    });
    emblemBox.classList.remove("eRight");
    emblemBox.classList.remove("eLeft");
    boxhouses.forEach(function (entry) {
        entry.classList.remove("box-active");
    });

    if (x.classList.contains("cButton1")) {
        bg.style.backgroundImage = "url('../Images/bg1.jpg')";
        //flag1.classList.add(fa);
        flag1.style.top = 0;
        emblemBox.classList.add("eRight");
    } else if (x.classList.contains("cButton2")) {
        bg.style.backgroundImage = "url('../Images/bg2.jpg')";
    } else {
        bg.style.backgroundImage = "url('../Images/bg3.jpg')";
        flag2.style.top = 0;
        emblemBox.classList.add("eLeft");
    }
    x.classList.add("active");
}

function emblemclick(x) {
    flag1.style.top = "-100vh";
    flag2.style.top = "-100vh";
    cButtons.forEach(function (entry) {
        entry.classList.remove("active");
    });
    bg.style.backgroundImage = "url('../Images/bg2.jpg')";
    emblemBox.classList.remove("eRight");
    emblemBox.classList.remove("eLeft");
    document.getElementById("cButton2").classList.add("active");

    boxhouses.forEach(function (entry) {
        entry.classList.remove("box-active");
    });
    if (x.classList.contains("emblem-house1")) {
        document.getElementById("box-house1").classList.add("box-active");
    } else if (x.classList.contains("emblem-house2")) {
        document.getElementById("box-house2").classList.add("box-active");
    } else if (x.classList.contains("emblem-house3")) {
    document.getElementById("box-house3").classList.add("box-active");
    } else if (x.classList.contains("emblem-house4")) {
        document.getElementById("box-house4").classList.add("box-active");
    }

}

