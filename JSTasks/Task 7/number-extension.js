Number.prototype.plus = function(value){
    return this + value;
}

Number.prototype.minus = function(value){
    return this - value;
}

var outputContainer = document.querySelector("#output-container");
var output = document.createTextNode("(2).plus(3).minus(1) = " + (2).plus(3).minus(1));
outputContainer.appendChild(output);