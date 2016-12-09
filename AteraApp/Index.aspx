<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AteraApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atera</title>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/Script.js"></script>
</head>
<body data-ng-app="AretaApp">
    <div class="container">
        <form id="form1" runat="server">
            <div>
                <h1>Devices Page</h1>
            </div>
            <div data-ng-controller="AteraController">
                <ul>
                    <li data-ng-repeat="device in devices track by $index" data-ng-init="device.hide=true" data-ng-click="device.hide=!device.hide">{{device.Name}}
                        <div data-ng-hide="device.hide">
                            Owner: {{device.Owner}} Created: {{device.Created |date:'medium'}}
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
