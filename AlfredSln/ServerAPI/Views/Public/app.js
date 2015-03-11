var alfredApp = angular.module("alfredApp", ['ngRoute']);

alfredApp.config(function ($routeProvider)
{
    $routeProvider.when('/',
        {
            templateUrl: 'index.html'
        })
})