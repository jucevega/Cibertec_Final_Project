(function () {
    'use strict';

    angular.module('app')
           .controller('PersonController', homeController);

    homeController.$inject = ['$scope'];

    function homeController($scope, searchService) {
        var vm = this;
        vm.title = 'Person Module';
    }
})();
