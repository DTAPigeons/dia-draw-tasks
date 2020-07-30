var sortFunction = function(a,b){
    var dateA = getDateFromDataString(a.date);
    var dateB = getDateFromDataString(b.date);
    
    return dateA - dateB;
}

arr.sort(sortFunction);

arr.forEach(element => {
    var outputContainer = document.querySelector("#output-container");
    var outputElement = document.createTextNode( JSON.stringify(element));
    var br = document.createElement("br");
    outputContainer.appendChild(outputElement);
    outputContainer.appendChild(br);
});