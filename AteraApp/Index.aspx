<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AteraApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Devices Page</h1>
    </div>
    <div>


        <form class="float_left" action="/Devices/Test" method="get">
            <button  type="submit">Go</button>
        </form>

    </div>
    <div id="device-list-div">
        
    </div>
    </form>
</body>
</html>
