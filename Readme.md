<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579997/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T513681)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to specify a default dashboard state in code


The sample illustrates how to specify a [dashboard state](https://docs.devexpress.com/Dashboard/118733/web-dashboard/aspnet-web-forms-dashboard-control/manage-dashboard-state) (such as master filter or parameter values) in code and how to apply this state when loading a dashboard for the first time. 

In this example, the [DashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState) object holds the required dashboard state. The [ASPxDashboard.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.SetInitialDashboardState) event is used to apply the specified dashboard state when loading a dashboard.

## Files to Look At

* [Default.aspx](./CS/WebDashboard_ManualDashboardState/Default.aspx) (VB: [Default.aspx](./VB/WebDashboard_ManualDashboardState/Default.aspx))
* [Default.aspx.cs](./CS/WebDashboard_ManualDashboardState/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebDashboard_ManualDashboardState/Default.aspx.vb))

## Documentation

- [Manage Dashboard State in ASP.NET Web Forms Applications](https://docs.devexpress.com/Dashboard/118733/web-dashboard/aspnet-web-forms-dashboard-control/manage-dashboard-state)

## More Examples

* [ASP.NET MVC Dashboard - How to specify a default dashboard state in code](https://github.com/DevExpress-Examples/asp-net-mvc-dashboard-specify-default-state-in-code)
* [ASP.NET Core Dashboard Control - How to specify a default dashboard state in code](https://github.com/DevExpress-Examples/aspnet-core-dashboard-specify-default-state-in-code)
* [WPF Dashboard - How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-set-initial-dashboard-state)
* [WinForms Dashboard - How to Save and Restore the Dashboard State](https://github.com/DevExpress-Examples/winforms-dashboard-save-restore-dashboard-state)
