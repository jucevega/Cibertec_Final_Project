(function () {
    angular.module('app.widgets')
        .directive('personCard', personCard);

    function personCard() {
        return {
            templateUrl: 'app/components/person-card/person-card.html',
            restrict: 'E',
            transclude: true,
            scope: {
                personId: '@',
                firstName: '@',
                middleName: '@',
                lastName: '@',
                modifiedDate: '@'
            },
            controller: directiveController
        };

        directiveController.$inject = ['$scope'];

        function directiveController($scope) {
            $scope.getPersonId = getPersonId();
            //$scope.getDeleteLink = getDeleteLink();

            //function getDeleteLink() {                
            //}

            function getPersonId() {
                return $scope.personId;
            }
        }
    }
})();