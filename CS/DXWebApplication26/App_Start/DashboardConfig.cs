using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using System.Configuration;
using System.Web.Routing;

namespace DXWebApplication26
{
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl");

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);

            DashboardConfigurator.Default.SetConnectionStringsProvider(
                new ConnectionStringsStorage(ConfigurationManager.ConnectionStrings["ConnectionsStorage"].ConnectionString));
        }
    }
}