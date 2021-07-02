<!-- default file list -->
*Files to look at*:

* [ConnectionStringsStorage.cs](./CS/DXWebApplication26/Storage/ConnectionStringsStorage.cs) (VB: [ConnectionStringsStorage.vb](./VB/DXWebApplication26/Storage/ConnectionStringsStorage.vb))
* [MyJsonConnection.cs](./CS/DXWebApplication26/Models/MyJsonConnection.cs) (VB: [MyJsonConnection.vb](./VB/DXWebApplication26/Models/MyJsonConnection.vb))
* [Global.asax.cs](./CS/DXWebApplication26/Global.asax.cs) (VB: [Global.asax.vb](./VB/DXWebApplication26/Global.asax.vb))
<!-- default file list end -->

# Dashboard for MVC - How to store JSON connections in a database

This example demonstrates how to create new JSON connections in MVC Dashboard's Data Source wizard and store them in a database.

Set the [DashboardExtensionSettings.AllowCreateNewJsonConnection](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardExtensionSettings.AllowCreateNewJsonConnection) property to True to allow creating new JSON connections. Implement the [IDataSourceWizardConnectionStringsStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.IDataSourceWizardConnectionStringsStorage) interface to create custom connection string storage, and use the DashboardConfigurator's [SetConnectionStringsProvider](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetConnectionStringsProvider.overloads) method to assign it to the MVC Dashboard.

In this example, connections are stored in a database using Entity Framework. To run the example, modify the "ConnectionStorage" connection string in [Web.config](./CS/DXWebApplication26/Web.config#L18).

## Documentation

- [Dashboard Data Source Wizard](https://docs.devexpress.com/Dashboard/117680/web-dashboard/ui-elements-and-customization/dialogs-and-wizards/dashboard-data-source-wizard)
- [Specify Data Source Settings (JSON)](https://docs.devexpress.com/Dashboard/401401/web-dashboard/ui-elements-and-customization/dialogs-and-wizards/dashboard-data-source-wizard/specify-data-source-settings-json)

## More Examples

- [Dashboard for Web Forms - How to store JSON connections in a database](https://github.com/DevExpress-Examples/web-dashboard-how-to-store-json-connections-in-database)
