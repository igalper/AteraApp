/// <reference path="angular.min.js" />
var app = angular.module("AretaApp", [])
            .controller("AteraController", function ($scope, $http) {
                $http.post(
                    "/Devices"
                    )
                .then(function (response) {
                    debugger;
                    $scope.devices = JSON.parse(response.data);
                }, function (e) {
                    alert(e);
                });
            });