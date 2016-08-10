(function () {
    var apiUrl = 'http://localhost/WebDeveloper-API/';
    angular.module('app').factory('personService', personService);

    function personService($http) {
        var service = {
            create: create,
            edit: edit,
            update: update,
            getList: getList
        };

        return service;
        function getList(page, size) {
            return $http.get(apiUrl+'person/list/' + page + '/rows/'+ size)
                .then(function (result) {
                    return result.data;
                }, function (error) {
                    console.log(error);
                    return error;
                });            
        }

        function create(person) {
            return $http.put(apiUrl + 'person', person)
                .then(function (result) {
                    return result.data;
                }, function (error) {
                    console.log(error);
                    return error;
                });
        }

        function edit(id) {
            return $http.get(apiUrl + 'person/edit/' + id)
                .then(function (result) {
                    return result.data;
                }, function (error) {
                    console.log(error);
                    return error;
                });
        }

        function update(person) {
            return $http.put(apiUrl + 'person', person)
                .then(function (result) {
                    return result.data;
                }, function (error) {
                    console.log(error);
                    return error;
                });
        }
    }
})();