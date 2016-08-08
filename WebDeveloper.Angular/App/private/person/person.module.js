(function () {
    'use strict';

    angular.module('app')
           .controller('PersonController', personController);

    personController.$inject = ['$scope', 'personService'];

    function personController($scope, personService) {
        var vm = this;
        vm.title = 'Person Module';
        vm.update = update;

        init();
        function init() {
            personService.getList(1, 10).then(function (data) {
                vm.personList = data;
            });            
        }

        function update() {
            var person = {
                "personType": "EM",
                "nameStyle": false,
                "title": null,
                "firstName": "Julio",
                "middleName": "J",
                "lastName": "Sánchez",
                "modifiedDate": "2017-01-07T00:00:00",
                "suffix": null,
                "emailPromotion": 0,
                "additionalContactInfo": null,
                "demographics": "<IndividualSurvey xmlns=\"http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/IndividualSurvey\"><TotalPurchaseYTD>0</TotalPurchaseYTD></IndividualSurvey>",
                "password": null,
                "businessEntity": null,
                "businessEntityContact": []
            };
            personService.create(person).then(function (data) {
                alert(data);
            });
        }
        
    }
})();
