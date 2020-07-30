var calculateTreeSum = function(tree){
    var sumContainer = {
        sum : 0,
        addToSum: function(value){
            this.sum+=value;
        }
    }

    calculateNodeSum(tree, sumContainer);

    return sumContainer.sum;
}

var calculateNodeSum = function(node, sumcontainer){
    sumcontainer.addToSum(node.valueNode);
    if(node.next!=undefined && node.next!=null){
        node.next.forEach(element => {
            calculateNodeSum(element, sumcontainer);
        });
    }
}

var sum = calculateTreeSum(tree);

var outputContainer = document.querySelector("#output-container");
var output = document.createTextNode("Сумата е: "+sum);
outputContainer.appendChild(output);