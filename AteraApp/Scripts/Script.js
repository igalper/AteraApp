/// <reference path="angular.min.js" />
var app = angular.module("AretaApp", [])
            .controller("AteraController", function ($scope, $http, $log, $httpParamSerializerJQLike) {
                $scope.refresh = function () {
                    $scope.error = "";
                    $http.get(
                        "/Devices/GetAllDevices"
                        )
                    .then(function (response) {
                        $scope.devices = response.data;
                        if ($scope.devices.length === 0) {
                            $scope.error = "You do not have any records at the moment"
                        }
                    }, function (reason) {
                        $scope.error = "Our servers are down at the moment"
                        $log.info(reason.data);
                    });
                };
                $scope.refresh();
                $scope.searchByOwner = function(){
                    if ($scope.ownerSearch) {
                        $scope.error = "";
                        $http({
                            url: "/Devices/GetDevicesByOwnerName",
                            method: 'POST',
                            data: $httpParamSerializerJQLike({ "owner": $scope.ownerSearch }),
                            headers: {
                                'Content-Type': 'application/x-www-form-urlencoded'
                            }
                        }).then(function (response) {
                            $scope.devices = response.data;
                            $scope.ownerSearch = "";
                            debugger;
                            if ($scope.devices.length === 0) {
                                $scope.error = "You do not have any records at the moment"
                            }
                        }, function (reason) {
                            $scope.error = "Our servers are down at the moment"
                            $log.info(reason.data);
                        });
                    }
                };
            });