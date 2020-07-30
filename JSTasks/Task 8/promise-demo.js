const promiseOne = new Promise(function(resolve, reject){
    setTimeout(function(){
        resolve();
    }, 5000);
});

const  promiseTwo = new Promise(function(resolve, reject){
    setTimeout(function(){
        resolve();
    }, 7000)
});

const promiseThree = Promise.all([promiseOne,promiseTwo]);

var outputContainer = document.querySelector("#output-container");

promiseOne.then(function(){
    var date = new Date();
    var output = document.createTextNode("Done 1: "+date.getTime());
    var br = document.createElement("br");
    outputContainer.appendChild(output);
    outputContainer.appendChild(br);
})

promiseTwo.then(function(){
    var date = new Date();
    var output = document.createTextNode("Done 2: "+date.getTime());
    var br = document.createElement("br");
    outputContainer.appendChild(output);
    outputContainer.appendChild(br);
})

promiseThree.then(function(){
    var date = new Date();
    var output = document.createTextNode("Done 3: "+date.getTime());
    var br = document.createElement("br");
    outputContainer.appendChild(output);
    outputContainer.appendChild(br);
})