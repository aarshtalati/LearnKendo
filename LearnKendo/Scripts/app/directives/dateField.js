/// <reference path="../app.js" />
(function() {
    'use strict';

    app
        .directive('dateField', ['$window', dateField]);
    
    function dateField ($window) {
        // Usage:
        // 
        // Creates:
        // 
        var directive = {
            restrict: 'A',
            replace: true,
            transclude: false,
            scope: {
                dateValue: '=dateValue'
            },
            template:'<div class="dateContainer"><input data-role="datepicker" data-ng-model="dateValue" /></div>',
            link: _link,
            controller: _controller
        };
        return directive;

        function _link(scope, element, attrs) {
            console.log(scope.dateValue);
            (function () {
                kendo.init($(".dateContainer"));
            })();
        }

        function _controller(scope, $filter) {
            scope.dateValString = $filter('date')(scope.dateValue, 'mediumDate');
            console.log('and the string is : ', scope.dateValString);
            }
        }
    }

})();