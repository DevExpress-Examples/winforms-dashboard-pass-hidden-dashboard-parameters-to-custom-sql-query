<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_CustomParameters_Win/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_CustomParameters_Win/Form1.vb))
<!-- default file list end -->
# How to Pass a Hidden Dashboard Parameter to a Custom SQL query


This example shows how to filter a custom SQL query by changing a parameter value in the [DashboardViewer.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event handler.


The **custIDQueryParameter** query parameter is included in a **WHERE** clause of a [custom SQL query](https://docs.devexpress.com/Dashboard/115212). The <strong>custIDQueryParameter </strong>parameter is also bound to the hidden <strong>custIDDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the [DashboardViewer.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event that is raised before the DashboardViewer queries a database.

![screenshot](/images/screenshot.png)

## Documentation

[Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)

## More Examples

* [How to: Pass a Dashboard Parameter to a Filter String in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-filter-string-in-code-e5117)
* [How to: Pass a Dashboard Parameter to a Calculated Field's Expression in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-calculated-fields-expression-in-code-e5135)
* [How to: Pass a Dashboard Parameter to a Custom SQL Query in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-custom-sql-query-in-code-e5120)
* [How to: Specify Default Parameter Values in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-specify-default-parameter-values-in-the-winforms-viewer-t475858)
* [How to: Use Dashboard Parameters with the Expression Format Condition](https://github.com/DevExpress-Examples/how-to-usedashboard-parameters-with-the-expressionformat-condition-t260065)
* [How to: Manage Parameters in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-manage-dashboard-parameters-in-code-t635871)
* [How to: Display the Others Slice in the Pie Chart](https://github.com/DevExpress-Examples/how-to-display-pie-chart-others-slice)
