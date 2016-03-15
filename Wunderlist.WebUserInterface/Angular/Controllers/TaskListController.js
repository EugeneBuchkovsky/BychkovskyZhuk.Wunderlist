WunderlistApp.controller('TaskListController', function ($scope, ListService) {
    //$scope.message = "Hello!";

    $scope.message = "hello";

    getList();
    function getList() {
        ListService.getList()
        .success(function (lists) {
            $scope.lists = lists;
        })
        .error(function (error) {
            $scope.status = 'Error to load data: ' + error.message;
        });
    }
});

WunderlistApp.factory('ListService', ['$http', function ($http) {

    var ListService = {};
    ListService.getList = function () {
        //return $http({ method: 'GET', url: '/api/TaskLists', params: { 'id': 1 } });
        return $http({ method: 'GET', url: '/api/TaskLists'});
    }
    return ListService;
}]);