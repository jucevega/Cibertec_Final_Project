(function () {
	'use strict';
	angular.module('app')
    .config(routeConfig);

	routeConfig.$inject = ['$stateProvider', '$urlRouterProvider'];

	function routeConfig($stateProvider, $urlRouterProvider) {
		//$urlRouterProvider.otherwise('/search/searchcases');

		$stateProvider
            .state("home", {
            	url: "/home",
            	templateUrl: 'app/home.html'
            })
            .state('person',{
            	url: "/person",
                templateUrl: 'app/private/person/index.html'
            });
	}
})();