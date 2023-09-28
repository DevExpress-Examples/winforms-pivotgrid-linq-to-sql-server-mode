<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/196423028/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828611)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# PivotGridControl and LINQ to SQL - a Server Mode Example

This example demonstrates a PivotGridControl bound to LINQ and SQL classes and operates in server mode.

## Files to Review

[Form1.cs](./CS/LinqToSqlServerModeExample/Form1.cs) ([Form1.vb](./VB/LinqToSqlServerModeExample/Form1.vb))

## Example Overview

The application contains two data sources bound to the Microsoft SQL database file:

* [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the PivotGridControl to the LinqServerModeSource instance.

![screenshot](./images/screenshot.png)

> SQL queries are logged to the Output window in Visual Studio IDE, so you can see what is going on behind the scene.

## Documentation
- [LINQ to SQL](https://docs.microsoft.com/dotnet/framework/data/adonet/sql/linq/)
- [Server Mode](https://docs.devexpress.com/WindowsForms/17856/controls-and-libraries/pivot-grid/binding-to-data/database-server-mode)

## More Examples

- [PivotGridControl and Entity Framework - a Server Mode Example](https://github.com/DevExpress-Examples/winforms-pivotgrid-entity-framework-server-mode)
