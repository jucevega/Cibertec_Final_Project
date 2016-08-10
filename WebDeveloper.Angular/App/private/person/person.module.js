(function () {
    'use strict';

    angular.module('app')
           .controller('PersonController', personController);

    personController.$inject = ['$scope', 'personService'];

    function personController($scope, personService) {
        var vm = this;
        vm.title = 'Person Module';
        vm.getPerson = getPerson;
        vm.personUpdate = personUpdate;
        vm.createPerson = createPerson;
        vm.newPerson;
        vm.updatePerson;

        init();
        function init() {
            personService.getList(1, 10).then(function (data) {
                vm.personList = data;
            });
        }

        function getPerson(id) {
            personService.edit(id).then(function (data) {
                vm.updatePerson = data;
                //console.log(vm.person);
            });
        }
        function personUpdate(person) {
            //var person = {
            //    "personType": "EM",
            //    "nameStyle": false,
            //    "title": null,
            //    "firstName": "Julio",
            //    "middleName": "J",
            //    "lastName": "Sánchez",
            //    "modifiedDate": "2017-01-07T00:00:00",
            //    "suffix": null,
            //    "emailPromotion": 0,
            //    "additionalContactInfo": null,
            //    "demographics": "<IndividualSurvey xmlns=\"http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/IndividualSurvey\"><TotalPurchaseYTD>0</TotalPurchaseYTD></IndividualSurvey>",
            //    "password": null,
            //    "businessEntity": null,
            //    "businessEntityContact": []
            //};
            personService.update(person).then(function () {
                $("button[data-dismiss='modal']").click();
            });
        }

        function createPerson(person) {
            if (person) {
                personService.create(person).then(function (data) {
                    //console.log(person);
                    vm.newPerson = null;
                    $("button[data-dismiss='modal']").click();
                });
            }
        }

    }
})();
