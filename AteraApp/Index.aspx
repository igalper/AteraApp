<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AteraApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atera</title>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/Script.js"></script>
    <link href="Style/bootstrap.min.css" rel="stylesheet" />
    <link href="Style/font-awesome.min.css" rel="stylesheet" />
    <link href="Style/Style.css" rel="stylesheet" />
</head>
<body data-ng-app="AretaApp">
    <div class="container myContainer" data-ng-controller="AteraController">
            <div>
            <h1>Devices Page</h1>
        </div>
        <div class="row">
            <div class="col-md-8">
                <input class="form-control" data-ng-model="ownerSearch" placeholder="Search by owner" />
            </div>
            <div class="fright pright15">
                <button class="btn btn-danger" data-ng-click="refresh()">Reset</button>
            </div>
            <div class="fright pright15">
                <button class="btn btn-primary" data-ng-click="searchByOwner()">Search</button>
            </div>
        </div>
        <h2>Devices list</h2>
        <input class="form-control" type="text" data-ng-model="searchBox.Name" placeholder="Search device name" />
        {{error}}
        <br />
        <ul class="list-group">
            <li class="list-group-item deviceItem" data-ng-repeat="device in devices | filter:searchBox track by $index" data-ng-init="device.hide=false" 
                data-ng-click="device.hide=!device.hide"> <p class ="deviceName">{{device.Name}}</p>
                <div class="deviceDetails" data-ng-show="device.hide">
                    <p>Owner name: {{device.Owner}}</p> 
                    <p>Time created: {{device.Created |date:'dd/MM/yyyy'}}</p>
                </div>
                <i class="fa fa-angle-down device-list-icon" aria-hidden="true"></i>
            </li>
        </ul>
    </div>
</body>
</html>
