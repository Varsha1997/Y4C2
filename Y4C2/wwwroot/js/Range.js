var sliderOne = document.getElementById("myRangeOne");
var sliderTwo = document.getElementById("myRangeTwo");
var sliderThree = document.getElementById("myRangeThree");
var output = document.getElementById("demo");
output.innerHTML = slider.value; // Display the default slider value

// Update the current slider value (each time you drag the slider handle)
sliderOne.oninput = function () {
    output.innerHTML = this.value;
}

sliderTwo.oninput = function () {
    output.innerHTML = this.value;
}

sliderThree.oninput = function () {
    output.innerHTML = this.value;
}