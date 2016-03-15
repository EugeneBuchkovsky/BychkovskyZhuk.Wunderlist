//var UserApp = angular.module('UserApp', []);

UserApp.controller('TaskListController', function ($scope, TaskListService){
    //$scope.message = "Hello!";

    getList();
    function getList() {
        TaskListService.getList()
        .success(function (l) {
            $scope.list = l;
        })
        .error(function (error) {
            $scope.status = 'Error to load data: ' + error.message;
        });
    }
});

UserApp.factory('TaskListService', ['$http', function ($http) {

    var TaskListService = {};
    TaskListService.getList = function () {
        return $http.get('/api/TaskLists');
    }
    return TaskListService;
}]);