var url = "https://localhost:44367/api/user/list";
var myApp = angular.module("myApp", []);

var MainController = function ($scope, $http) {

    var onSucess = function (response) { $scope.users = response.data };

    var onFailure = function (reason) { $scope.error = reason };

    var getAlluser = function () {
        $http.get(url)
        .then(onSucess, onFailure)
    };

    getAlluser();

};
myApp.controller("MainController", MainController);











