Public Class frmMostrar
    Public oCedula, oHoraCap, oHorario, oJornada, oNombre, oApellido As Object
    Private TimeCap As String
    Private TiempoLimite As Integer = 0

    Public Sub MostrarRegistroCap()
        lblCedula.Text = oCedula
        lblHoraCap.Text = oHoraCap
        lblHorario.Text = oHorario
        lblJornada.Text = oJornada
        lblNombre.Text = oNombre & "  " & oApellido
        Me.Show()
    End Sub
    Public Sub ConsultarRegistroCap()
        lblCedula.Text = oCedula
        lblHoraCap.Text = oHoraCap
        lblHorario.Text = oHorario
        lblJornada.Text = oJornada
        lblNombre.Text = oNombre & "  " & oApellido
        Me.Show()
    End Sub

    Public Sub Cumplefrm()
        Me.Height = 457
        Me.Width = 520

    End Sub
    Public Sub Restaurarfrm()
        Me.Height = 261
        Me.Width = 520

    End Sub
    Private Sub frmMostrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Limpiar()
        End If
    End Sub

    Private Sub TimerCloser_Tick(sender As Object, e As EventArgs) Handles TimerCloser.Tick


        TiempoLimite = (TimeCap - DateTime.Now.Second.ToString)
        lblClose.Text = Math.Abs(TiempoLimite)

        If Math.Abs(TiempoLimite) = 5 Then
            Limpiar()
        End If
    End Sub
    Sub Limpiar()
        lblCedula.Text = ""
        lblHoraCap.Text = ""
        lblHorario.Text = ""
        lblJornada.Text = ""
        lblNombre.Text = ""
        TimerCloser.Stop()
        Me.Close()
    End Sub
    Private Sub frmMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerCloser.Start()
        TimerCloser.Interval = 1000
        TimeCap = DateTime.Now.Second.ToString
        FrmMarcaje.txtCodigo.Text = ""
        FrmMarcaje.txtCodigo.Focus()
    End Sub
End Class