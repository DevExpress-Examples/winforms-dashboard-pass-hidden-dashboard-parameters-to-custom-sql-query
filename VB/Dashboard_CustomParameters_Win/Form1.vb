Imports DevExpress.DashboardCommon
Imports System.Linq

Namespace Dashboard_CustomParameters_Win
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
		End Sub

		Private Sub dashboardViewer1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersEventArgs) Handles dashboardViewer1.CustomParameters
			Dim custIDParameter = e.Parameters.FirstOrDefault(Function(p) p.Name = "custIDDashboardParameter")
			If custIDParameter IsNot Nothing Then
				custIDParameter.Value = "AROUT"
			End If
		End Sub
	End Class
End Namespace
