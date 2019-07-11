# Pivot Grid LINQ to SQL Server Mode Example

This example demonstrates the PivotGridControl that is bound to LINQ to SQL classes and operates in Server mode.

The application contains two data sources bound to the Microsoft SQL database file:

* [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the PivotGridControl to the LinqServerModeSource instance.

![screenshot](/images/screenshot.png)

> SQL queries are written to the Output window in Visual Studio IDE, so you can see what is going on behind the scene.
