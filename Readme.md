# How to pass a hidden dashboard parameter to a custom SQL query in the WinForms Viewer


<p>The following example shows how to filter a custom SQL query by changing a parameter value in the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_CustomParameterstopic">DashboardViewer.CustomParameters</a> event handler.</p>
<p>In this example, the <strong>custIDQueryParameter</strong> query parameter is included in a WHERE clause of a <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument115212">custom SQL query</a>. The <strong>custIDQueryParameter </strong>parameter is also bound to the hidden <strong>custIDDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_CustomParameterstopic">DashboardViewer.CustomParameters</a> event which is raised before the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardViewertopic">DashboardViewer</a> sends a query to a database.<br><br><strong>See also: </strong><a href="https://www.devexpress.com/Support/Center/p/T475858">How to specify default parameter values in the WinForms Viewer</a></p>

<br/>


