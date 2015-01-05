(function () {
    'use strict';

    var controllerId = 'home';

    app.controller(controllerId, ['$scope', 'customerService', home]);

    function home($scope, service) {
        $scope.title = 'home';
        $scope.activate = function () {
            service.getAll().success(function (records, status) {
                $scope.ppl = records;
                $scope.autoCompleteValues = new kendo.data.DataSource({ data: records });
                console.log(records);
            }).error(function (data, status) {
                console.log(data);
            });
        };

        $scope.spinnerOptions = {
            format: "#"
            //, decimals: 0
        };

        $scope.personId = 0;
        

        $scope.$watch('person', function () {
            if ($scope.person !== undefined && $scope.person !== null && $scope.person !== '') {
                var result = $.grep($scope.ppl, function (e) { // jQuery grep
                    return e.name.toLowerCase() == $scope.person.toLowerCase();
                }); 
                if (result.length > 0) {
                    console.log('found : ', result[0]);
                    $scope.personId = result[0].id;
                }
                else {
                    $scope.personId = -1;
                }
            }
        });
    }
})();