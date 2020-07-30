var partCombinations = [];
const separator = ":";


var getClassificationFromCatagoryIdString= function(string){
    var seperatorIndex = string.search(separator);
    return string.substring(seperatorIndex+1);
}

var getIdFromCatagoryIdString= function(string){
    var seperatorIndex = string.search(separator);
    return  string.substring(0,seperatorIndex);
}

var getPriceFromCatagoryIdString = function(string){
    var classification = getClassificationFromCatagoryIdString(string);
    var id = getIdFromCatagoryIdString(string);
    var searchedForPart = data["parts"].find(function(part){
       return part.id == id && part.classification == classification;
    })
    return searchedForPart.price;
}

var getAllPartCombinations = function(partCombinations){
    for(generator in data["parts compatibility"]){      
        data["parts compatibility"][generator].forEach(body => {
           if(getClassificationFromCatagoryIdString(body) == "body"){
               data["parts compatibility"][generator].forEach(engine => {
                   if(getClassificationFromCatagoryIdString(engine) == "engine"){
                       var price = getPriceFromCatagoryIdString(generator) + 
                       getPriceFromCatagoryIdString(body) +
                       getPriceFromCatagoryIdString(engine);
                       partCombinations.push(generator+", "+body+", "+engine+", Price: "+ price);
                   }
               });
           }
        });
    }
}

getAllPartCombinations(partCombinations);

var outputContainer = document.querySelector("#output-container");
var counter = 1;
partCombinations.forEach(combination => {
    var output = document.createTextNode("Combination "+counter+": "+combination);
    var br  = document.createElement("br");
    outputContainer.appendChild(output);
    outputContainer.appendChild(br);
    counter++;
});