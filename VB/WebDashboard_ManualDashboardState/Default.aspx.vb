Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Collections.Generic

Namespace WebDashboard_ManualDashboardState
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Protected Sub ASPxDashboard1_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
			e.InitialState = InitializeDashboardState()
		End Sub

		Public Function InitializeDashboardState() As DashboardState
			Dim dashboardState As New DashboardState()

			Dim parameterState As New DashboardParameterState("countryParameter", "USA", GetType(String))

			Dim gridFilterState As New DashboardItemState("gridDashboardItem1")
			gridFilterState.MasterFilterValues.AddRange(New List(Of Object())() From {
				New String(0) { "Andrew Fuller" },
				New String(0) { "Laura Callahan" }
			})

			Dim treemapDrilldownState As New DashboardItemState("treemapDashboardItem1")
			treemapDrilldownState.DrillDownValues.Add("Beverages")

			Dim rangeFilterState As New DashboardItemState("rangeFilterDashboardItem1")
			rangeFilterState.RangeFilterState.Selection = New RangeFilterSelection(New DateTime(2015, 1, 1), New DateTime(2016, 1, 1))

			dashboardState.Parameters.Add(parameterState)
			dashboardState.Items.AddRange(New List(Of DashboardItemState)() From {gridFilterState, treemapDrilldownState, rangeFilterState})
			Return dashboardState
		End Function
	End Class
End Namespace