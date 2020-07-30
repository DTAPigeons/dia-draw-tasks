var getDateFromDataString = function(dataString){
    var dateParts = dataString.split('.');
    return new Date(dateParts[2], dateParts[1] - 1, dateParts[0]);
}

