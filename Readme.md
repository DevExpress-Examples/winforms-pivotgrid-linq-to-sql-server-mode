<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/196423028/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828611)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# PivotGridControl and LINQ to SQL - a Server Mode Example

This example demonstrates the PivotGridControl that is bound to LINQ to SQL classes and operates in Server mode.

The application contains two data sources bound to the Microsoft SQL database file:

* [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the PivotGridControl to the LinqServerModeSource instance.

![screenshot](/images/screenshot.png)

> SQL queries are logged to the Output window in Visual Studio IDE, so you can see what is going on behind the scene.

## Example Overview

### Create Data Classes

1. Add **LINQ to SQL Classes** to the project.
	
	![Server Mode LINQ  Add LINQ to SQL classes](~/images/server-mode-linq-add-linq-to-sql-classes25446.png)
2. Data classes can then be created and edited in an **Object Relational Designer (O/R Designer)**. An **O/R Designer** provides a visual design surface for creating **LINQ to SQL entity classes** and relationships based on objects in a database. To learn more, see the [Microsoft LINQ to SQL article](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/).
	
	You can create and map entity classes to tables and views by dragging database tables and views from **Server Explorer** onto the **O/R Designer**.
	
	![Server Mode LINQ OR Designer](~/images/server-mode-linq-or-designer25447.png)
	
	Save your changes, close the **O/R Designer**, and rebuild the solution.

### Bind a Pivot Grid Control to the LinqServerModeSource component

3. Drag the **LinqServerModeSource** component and drop it onto the Form. 
	
	![Server Mode Add LINQ Component](~/images/server-mode-add-linq-component25462.png)

	> [!Note]
	> Alternatively, you can create the [LinqServerModeSource](xref:DevExpress.Data.Linq.LinqServerModeSource) in code at runtime.

4. Specify the type of objects retrieved from a data source with the [LinqServerModeSource.ElementType](xref:DevExpress.Data.Linq.LinqServerModeSource.ElementType) and [LinqServerModeSource.KeyExpression](xref:DevExpress.Data.Linq.LinqServerModeSource.KeyExpression) properties:

	# [C#](#tab/tabid-csharp)
	
	```csharp
	linqServerModeSource1.ElementType = typeof(Invoice);
	linqServerModeSource1.KeyExpression = "OrderID";
	```
	
	# [VB.NET](#tab/tabid-vb)
	
	```vb
	linqServerModeSource1.ElementType = GetType(Invoice)
	linqServerModeSource1.KeyExpression = "OrderID"
	```

	***

5. Specify the queryable source using the [LinqServerModeSource.QueryableSource](xref:DevExpress.Data.Linq.LinqServerModeSource.QueryableSource) property:

	# [C#](#tab/tabid-csharp)
	
	```csharp
	linqServerModeSource1.QueryableSource = dc.Invoices;
	```
	
	# [VB.NET](#tab/tabid-vb)
	
	```vb
	linqServerModeSource1.QueryableSource = dc.Invoices
	```
	
	***

6. Bind the Pivot Grid control to the [LinqServerModeSource](xref:DevExpress.Data.Linq.LinqServerModeSource) component:

	# [C#](#tab/tabid-csharp)
	
	```csharp
	pivotGridControl1.DataSource = linqServerModeSource1;
	```
	
	# [VB.NET](#tab/tabid-vb)
	
	```vb
	pivotGridControl1.DataSource = linqServerModeSource1
	```	
	
	***

See the full code: [Form1.cs](./CS/LinqToSqlServerModeExample/Form1.cs)/[Form1.vb](./VB/LinqToSqlServerModeExample/Form1.vb)

7. Run the project. The PivotGridControl works in server mode because it is bound to the LINQ-to-SQL data source. You can see the generated SQL statements in the Visual Studio Output window.

See also:

* [LINQ to SQL](https://docs.microsoft.com/dotnet/framework/data/adonet/sql/linq/)
* [Server Mode](https://docs.devexpress.com/WindowsForms/17856)
