/*var fa = "flag-active";

var flag1 = document.getElementById("flag1");
if (flag1 != null) {
    flag1.classList.add(fa);
}
*/

var flag1 = document.getElementById("flag1");
var bg = document.getElementById("Background");
var carouselB = document.getElementById("carousel-buttons");
flag1.style.top = 0;

function switchCarousel(x) {

    /*var activeFlags = document.getElementsByClassName(fa);
    for (var i = 0; i < activeFlags.length; i++) {
        activeFlags[i].classList.remove(fa);
    }*/
    flag1.style.top = "-100vh";

    if (x.classList.contains("cButton1")) {
        bg.style.backgroundImage = "url('../Images/bg1.jpg')";
        //flag1.classList.add(fa);
        flag1.style.top = 0;
    } else if (x.classList.contains("cButton2")) {
        bg.style.backgroundImage = "url('../Images/bg2.jpg')";
    } else {
        bg.style.backgroundImage = "url('../Images/bg3.jpg')";
    }
}