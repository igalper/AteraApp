<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AteraApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atera</title>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/Script.js"></script>
    <link href="Style/bootstrap.min.css" rel="stylesheet" />
    <link href="Style/Style.css" rel="stylesheet" />
</head>
<body data-ng-app="AretaApp">
    <div class="container">
        <form id="form1" runat="server">
            <div class="col-sm-4" data-ng-controller="AteraController">
                 <div>
                    <h1>Devices Page</h1>
                </div>
                <ul class="list-group">
                    <li class="list-group-item deviceItem" data-ng-repeat="device in devices track by $index" data-ng-init="device.hide=true" 
                        data-ng-click="device.hide=!device.hide"> <p class ="deviceName">{{device.Name}}</p>
                        <div class="deviceDetails" data-ng-hide="device.hide">
                            <p>Owner name: {{device.Owner}}</p> 
                            <p>Time created: {{device.Created |date:'dd/MM/yyyy'}}</p>
                        </div>
                    </li>
                </ul>

            </div>
            <div id="device-list-div">
            </div>
        </form>
    </div>
</body>
</html>
