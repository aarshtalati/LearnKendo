/// <reference path="../app.js" />

(function () {
    'use strict';

    app.service('customerService', ['$http', customerService]);

    function customerService($http) {
        
        this.getAll = function () {
            var v = 'test';
            return $http({
                method: 'GET',
                url: 'http://www.filltext.com/?rows=10&id={index}&name={firstName}'
            });
        };

        //#region Internal Methods        

        //#endregion
    }
})();