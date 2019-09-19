<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_CustomParameters_Win/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_CustomParameters_Win/Form1.vb))
<!-- default file list end -->
# How to Pass a Hidden Dashboard Parameter to a Custom SQL query


This example shows how to filter a custom SQL query by changing a parameter value in the [DashboardViewer.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event handler.


The **custIDQueryParameter** query parameter is included in a **WHERE** clause of a [custom SQL query](https://docs.devexpress.com/Dashboard/115212). The <strong>custIDQueryParameter </strong>parameter is also bound to the hidden <strong>custIDDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the [DashboardViewer.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event that is raised before the DashboardViewer queries a database.

![screenshot](/images/screenshot.png)

See also:
*  [How to specify default parameter values in the WinForms Viewer](https://www.devexpress.com/Support/Center/p/T475858)
