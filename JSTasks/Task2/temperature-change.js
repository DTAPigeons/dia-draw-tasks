var displayTemeperatureChangeForMonth = function(month, data){
    var previousTemperature = 0.00;
    var displayContainer = document.querySelector("#temperature-change");
    for(const [key,value] of Object.entries(data)){
        var date = getDateFromDataString(key);
        var monthData = date.getMonth() + 1;
        if(monthData==month){
            var change = value - previousTemperature;
            var changeDisplayText = key +" : "+ change;
            previousTemperature = value;
            var changeDisplay = document.createTextNode(changeDisplayText);
            displayContainer.appendChild(changeDisplay);
            var br = document.createElement("br");
            displayContainer.appendChild(br);
        }
    }
}

displayTemeperatureChangeForMonth(1,data);