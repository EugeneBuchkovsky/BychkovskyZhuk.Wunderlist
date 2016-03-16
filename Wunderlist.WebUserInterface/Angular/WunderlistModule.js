/// <reference path="Views/TodoItems.html" />
var WunderlistApp = angular.module('WunderlistApp', ["ngRoute"])
.config(function ($routeProvider) {
    //$routeProvider.when('/lists/:id',
    $routeProvider.when('/lists',
        {
            templateUrl:'../Angular/Views/TodoItems.html',
            controller: 'TodoItemController'
        });
    //$routeProvider.otherwise({ redirectTo: '/lists/' });
});