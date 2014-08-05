(function () {
    'use strict';

    var controllerId = 'home';

    app.controller(controllerId,
        ['$scope', home]);

    function home($scope) {
        $scope.title = 'home';
        $scope.activate = activate;
        $scope.selectedDate = new Date();
        $scope.personId = undefined;

        function activate() { }
    }
})();