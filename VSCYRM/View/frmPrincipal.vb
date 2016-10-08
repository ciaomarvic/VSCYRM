Public Class frmPrincipal
    Private Sub MarcajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcajesToolStripMenuItem.Click
        FrmMarcaje.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim ValuePer As String
        ValuePer = InputBox("Indicar Clave", "Se Requiere Validar", "")
        If ValuePer = "t4c4" Then
            frmRegEmp.Show()
        Else
            MsgBox("Clave Errada")
        End If

    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        Dim ValuePer As String
        ValuePer = InputBox("Indicar Clave", "Se Requiere Validar", "")
        If ValuePer = "t4c4" Then
            frmHorarios.Show()
        Else
            MsgBox("Clave Errada")
        End If
    End Sub

    Private Sub DiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiarioToolStripMenuItem.Click
        frmRDiario.Show()
    End Sub

    Private Sub SemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanalToolStripMenuItem.Click
        frmRSem.Show()
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        Me.Text = "Registro y Control de Marcajes  -   " + String.Format("Version {0}", My.Application.Info.Version.ToString) + "     " + DateTime.Now.ToString

    End Sub

    Private Sub AcercaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaToolStripMenuItem.Click
        AboutBox.Show()
    End Sub
End Class
