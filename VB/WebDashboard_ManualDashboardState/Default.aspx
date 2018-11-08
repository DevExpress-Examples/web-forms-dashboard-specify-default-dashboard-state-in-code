﻿<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" 
    Inherits="WebDashboard_ManualDashboardState.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.1.Web, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position:absolute; left:0; right:0; top:0; bottom:0;">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" 
            DashboardStorageFolder="~/App_Data/Dashboards"
            WorkingMode="ViewerOnly"
            Height="100%" Width="100%" OnSetInitialDashboardState="ASPxDashboard1_SetInitialDashboardState">
        </dx:ASPxDashboard>
    </div>
    </form>
</body>
</html>