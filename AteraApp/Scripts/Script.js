/// <reference path="angular.min.js" />
var app = angular.module("AretaApp", [])
            .controller("AteraController", function ($scope, $http) {
                $http.get(
                    "/Devices/GetAllDevices"
                    )
                .then(function (response) {
                    $scope.devices = response.data;
                }, function (e) {
                    alert(e);
                });
            });