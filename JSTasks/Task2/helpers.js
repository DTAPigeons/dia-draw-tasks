var getDateFromDataString = function(dataString){
    var dateParts = dataString.split('.');
    return new Date(dateParts[2], dateParts[1] - 1, dateParts[0]);
}

var getWeekOfMont = function(date){    
    var dateAdjustment = new Date(+date);
    var day = dateAdjustment.getDay();
    if(day==0){ day = 7; }
    dateAdjustment.setDate(dateAdjustment.getDate() - day +1);
    if(dateAdjustment.getMonth() != date.getMonth()) {
         return 1; 
        }
    return 1 + Math.ceil(dateAdjustment.getDate()/7);
}

