
var calculateAvarageTemperatureForWeek = function(week, month, data){
    var sumTemperature = 0.00;
    var numberOfDaysRecorded = 0;
    for(const [key,value] of Object.entries(data)){
        var date = getDateFromDataString(key);
        var monthData = date.getMonth() + 1;
        var weekData = getWeekOfMont(date);
        if(monthData == month && weekData == week){
            sumTemperature += value;
            numberOfDaysRecorded++;
        }
    }

    return sumTemperature / numberOfDaysRecorded;
}

document.querySelector("#avarage-temperature-week-one").innerHTML = calculateAvarageTemperatureForWeek(1,1,data);
document.querySelector("#avarage-temperature-week-two").innerHTML = calculateAvarageTemperatureForWeek(2,1,data);