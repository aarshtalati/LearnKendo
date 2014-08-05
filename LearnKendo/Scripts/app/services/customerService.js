/// <reference path="../app.js" />

(function () {
    'use strict';

    app.factory('customerService', ['$http', customerService]);

    function customerService($http) {
        var service = {
            getAll: _getAll
        };

        return service;

        var _getData = function () {

        };

        //#region Internal Methods        

        //#endregion
    }
})();