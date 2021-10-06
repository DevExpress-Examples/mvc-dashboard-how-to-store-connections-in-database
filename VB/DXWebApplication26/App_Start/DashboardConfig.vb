Imports Microsoft.VisualBasic
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports System.Configuration
Imports System.Web.Routing

Namespace DXWebApplication26
	Public NotInheritable Class DashboardConfig
		Private Sub New()
		End Sub
		Public Shared Sub RegisterService(ByVal routes As RouteCollection)
			routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")

			Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
			DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

			DashboardConfigurator.Default.SetConnectionStringsProvider(New ConnectionStringsStorage(ConfigurationManager.ConnectionStrings("ConnectionsStorage").ConnectionString))
		End Sub
	End Class
End Namespace