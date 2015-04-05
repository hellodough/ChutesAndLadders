<!--

    $(document).ready(function() {
    //    $('body').keydown(myFunction());
        start();
    });


function myFunction() {
    var x, text;

    // Get the value of the input field with id="numb"
    x = document.getElementById("numb").value;

    // If x is Not a Number or less than one or greater than 10
    if (isNaN(x) || x < 1 || x > 10) {
        text = "Input STUPID";
    } else {
        text = "Input OK";
    }
    document.getElementById("demo").innerHTML = text;
}

function blah(){
    document.getElementById("canvas").innerHTML ="working?";
}

function start(){
//    document.getElementById("canvas").innerHTML ="start screen";
    $('.button').hide();
}

function instructions(){
    document.getElementById("canvas").innerHTML ="instructions";
}
-->