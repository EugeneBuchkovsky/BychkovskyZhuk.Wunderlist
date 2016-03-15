var ListApp = angular.module('ListApp', []);

ListApp.controller('TaskListController', function ($scope, TaskListService){
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

ListApp.factory('TaskListService', ['$http', function ($http) {

    var TaskListService = {};
    TaskListService.getList = function () {
        return $http({ method: 'GET', url: '/api/TaskLists', params: {'id':1} });
    }
    return TaskListService;
}]);