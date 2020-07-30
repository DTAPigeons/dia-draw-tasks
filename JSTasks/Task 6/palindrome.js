var stringIsPalindrome = function(string){
    var reversedString = string.split("").reverse().join("");
    return string.toLowerCase() == reversedString.toLowerCase();
}

var outputContainer = document.querySelector("#output-container");

data.forEach(element => {
    var output = document.createTextNode(element+" Is palindrome: " + stringIsPalindrome(element));
    var br = document.createElement("br");
    outputContainer.appendChild(output);
    outputContainer.appendChild(br);
});
