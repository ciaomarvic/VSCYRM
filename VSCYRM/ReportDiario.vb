Public Class ReportDiario
    Private Sub ReportDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ObjReports As New CrystalReportDia
        CrystalReportViewer1.ReportSource = ObjReports
        ObjReports.ParameterFields.Add(frmRDiario.DateTimePicker1.Value)


    End Sub
End Class