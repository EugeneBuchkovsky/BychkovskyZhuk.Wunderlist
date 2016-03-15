var UserApp = angular.module('UserApp', []);

UserApp.controller('UserController', function ($scope, UserService){
    //$scope.message = "Hello!";

    getUser();
    function getUser() {
        UserService.getUser()
        .success(function (users) {
            $scope.users = users;
        })
        .error(function (error) {
            $scope.status = 'Error to load data: ' + error.message;
        });
    }
});

UserApp.factory('UserService', ['$http', function ($http) {

    var UserService = {};
    UserService.getUser = function () {
        return $http.get('/api/User/1');
    }
    return UserService;
}]);