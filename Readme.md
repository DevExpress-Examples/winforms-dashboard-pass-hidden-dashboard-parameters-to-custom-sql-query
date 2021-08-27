<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581246/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T338459)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_CustomParameters_Win/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_CustomParameters_Win/Form1.vb))
<!-- default file list end -->
# How to pass a hidden dashboard parameter to a custom SQL query in the WinForms Viewer


<p>The following example shows how to filter a custom SQL query by changing a parameter value in the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_CustomParameterstopic">DashboardViewer.CustomParameters</a> event handler.</p>
<p>In this example, the <strong>custIDQueryParameter</strong> query parameter is included in a WHERE clause of a <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument115212">custom SQL query</a>. The <strong>custIDQueryParameter </strong>parameter is also bound to the hidden <strong>custIDDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_CustomParameterstopic">DashboardViewer.CustomParameters</a> event which is raised before the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardViewertopic">DashboardViewer</a> sends a query to a database.<br><br><strong>See also: </strong><a href="https://www.devexpress.com/Support/Center/p/T475858">How to specify default parameter values in the WinForms Viewer</a></p>

<br/>


