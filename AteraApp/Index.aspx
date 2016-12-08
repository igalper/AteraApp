<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AteraApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atera</title>
    
</head>
<body ng-app="AretaApp">
    <div class="container">
        <form id="form1" runat="server">
            <div>
                <h1>Devices Page</h1>
            </div>
            <div ng-controller="AteraController">


            </div>
            <div id="device-list-div">
            </div>
        </form>
    </div>
</body>
</html>
