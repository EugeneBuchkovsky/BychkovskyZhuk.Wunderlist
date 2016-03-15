WunderlistApp.controller('TodoItemController', function ($scope, TodoService) {
    //$scope.message = "Hello!";

    $scope.message = "hello todo item";

    getItems();
    function getItems() {
        TodoService.getItems()
        .success(function (items) {
            $scope.items = items;
        })
        .error(function (error) {
            $scope.status = 'Error to load data: ' + error.message;
        });
    }
});

WunderlistApp.factory('TodoService', ['$http', function ($http) {

    var TodoService = {};
    TodoService.getItems = function () {
        //return $http({ method: 'GET', url: '/api/TaskLists', params: { 'id': 1 } });
        return $http({ method: 'GET', url: '/api/TodoItem' });
    }
    return TodoService;
}]);