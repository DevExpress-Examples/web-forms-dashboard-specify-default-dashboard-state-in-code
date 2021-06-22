using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Collections.Generic;

namespace WebDashboard_ManualDashboardState {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboard1_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e) {
            e.InitialState = InitializeDashboardState();
        }

        public DashboardState InitializeDashboardState() {
            DashboardState dashboardState = new DashboardState();

            DashboardParameterState parameterState = 
                new DashboardParameterState("countryParameter", "USA", typeof(string));

            DashboardItemState gridFilterState = new DashboardItemState("gridDashboardItem1");
            gridFilterState.MasterFilterValues.AddRange(new List<object[]>() {
                new string[1] { "Andrew Fuller" },
                new string[1] { "Laura Callahan" }
            }
            );

            DashboardItemState treemapDrilldownState = new DashboardItemState("treemapDashboardItem1");
            treemapDrilldownState.DrillDownValues.Add("Beverages");

            DashboardItemState rangeFilterState = new DashboardItemState("rangeFilterDashboardItem1");
            rangeFilterState.RangeFilterState.Selection = 
                new RangeFilterSelection(new DateTime(2015, 1, 1), new DateTime(2016, 1, 1));

            dashboardState.Parameters.Add(parameterState);
            dashboardState.Items.AddRange(new List<DashboardItemState>() {
                gridFilterState,
                treemapDrilldownState,
                rangeFilterState }
            );
            return dashboardState;
        }
    }
}
