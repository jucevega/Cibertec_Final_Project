(function () {
    'use strict';
    angular.module('app')
        .controller('applicationController', applicationController);

    applicationController.$inject = ['$scope']

    function applicationController($scope) {
        $scope.settings = settings;
        $scope.init = function (opt) {
            var options = JSON.parse(opt);
            $.extend(settings, options);
        };
    }

})();