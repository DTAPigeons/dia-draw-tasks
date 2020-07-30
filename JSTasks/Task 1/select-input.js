var switchSelectText = function(textData){

    var positionTextBox = document.querySelector(textData.textQuery);
    var positionSelect = document.querySelector(textData.selectorQuery);

    positionTextBox.innerHTML = textData[positionSelect.value];
}

var positionListener = function(){
    const POSITIONE_TEXT = {
        textQuery : "#position-text",
        selectorQuery : "#position-select",
        "true" : "Ако ме изберат за премиер",
        "false" : "Ако не ме изберат за премиер"
    };

    switchSelectText(POSITIONE_TEXT);
}

var promiseListener = function(){    
    const PROMISE_TEXT = {
        textQuery : "#promise-text",
        selectorQuery : "#promise-select",
        "true" : "ще построя магистрала",
        "false" : "няма да построя нова магистрала"
    };

    switchSelectText(PROMISE_TEXT);
}

var positionSelect = document.querySelector("#position-select");
var promiseSelect = document.querySelector("#promise-select");

positionSelect.addEventListener("change", positionListener);
promiseSelect.addEventListener("change", promiseListener);


