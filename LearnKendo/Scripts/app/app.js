/// <reference path="../KendoUI/angular.min.js" />
var app = angular.module('app', []);

app.filter("asDate", function () {
    return function (input) {
        return new Date(input);
    }
});

app.value('$', $);