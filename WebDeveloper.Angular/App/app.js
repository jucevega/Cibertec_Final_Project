(function () {
    'use strict';
    angular.module('app.widgets', []);

    angular
        .module('app', ['ngRoute', 'ui.router', 'app.widgets']);
    
})();