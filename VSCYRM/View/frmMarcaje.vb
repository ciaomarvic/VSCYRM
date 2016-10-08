Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class FrmMarcaje
    Public Hora As String
    Public Fecha As Date
    Public Nombre As String
    Public Hora11 As String
    Public Hora12 As String
    Public Hora21 As String
    Public Hora22 As String
    Public Horario(28) As Timer
    Private Sub FrmMarcaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TimerMarcaje_Tick(sender As Object, e As EventArgs) Handles TimerMarcaje.Tick
        lblHora.Text = TimeOfDay
        lblFecha.Text = DateAndTime.Now.ToLongDateString
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        ' Al Precionar Enter Envio Codigo del Carnet 
        If Asc(e.KeyChar) = 13 And Len(txtCodigo.Text) > 0 Then
            BuscarDatos(txtCodigo.Text)
        End If
    End Sub
    Private Sub BuscarDatos(Codigo As String)
        Dim cnn As Conexion
        Dim SpCmd As MySqlCommand
        Dim Parm1 As MySqlParameter
        Dim CmdReader As MySqlDataReader
        Dim Sql As String
        Dim Nombre As String
        Dim Apellido As String
        Dim Cedula As String
        Dim Dia As String
        Dim J11 As String = ""
        Dim J12 As String = ""
        Dim J21 As String = ""
        Dim J22 As String = ""
        Dim HoraCap As String


        Try
            cnn = New Conexion()
            cnn.ConectarMysql()
            Sql = "Buscar_Horario"
            SpCmd = New MySqlCommand(Sql, cnn.Connection)
            SpCmd.CommandType = CommandType.StoredProcedure
            Parm1 = SpCmd.Parameters.Add("Codigo", MySqlDbType.VarChar)
            Parm1.Value = Codigo
            CmdReader = SpCmd.ExecuteReader

            Dia = UCase(Microsoft.VisualBasic.Left(DateValue(Now).ToString("dddd", New CultureInfo("es-ES")), 3))
            Debug.Print(Dia)
            If CmdReader.Read Then
                Cedula = CmdReader.GetString(0)
                Nombre = CmdReader.GetString(1)
                Apellido = CmdReader.GetString(2)
                Select Case Dia
                    Case "LUN"
                        J11 = CmdReader.GetString(4)
                        J12 = CmdReader.GetString(5)
                        J21 = CmdReader.GetString(6)
                        J22 = CmdReader.GetString(7)
                    Case "MAR"
                        J11 = CmdReader.GetString(8)
                        J12 = CmdReader.GetString(9)
                        J21 = CmdReader.GetString(10)
                        J22 = CmdReader.GetString(11)
                    Case "MIÉ"
                        J11 = CmdReader.GetString(12)
                        J12 = CmdReader.GetString(13)
                        J21 = CmdReader.GetString(14)
                        J22 = CmdReader.GetString(15)
                    Case "JUE"
                        J11 = CmdReader.GetString(16)
                        J12 = CmdReader.GetString(17)
                        J21 = CmdReader.GetString(18)
                        J22 = CmdReader.GetString(19)
                    Case "VIE"
                        J11 = CmdReader.GetString(20)
                        J12 = CmdReader.GetString(21)
                        J21 = CmdReader.GetString(22)
                        J22 = CmdReader.GetString(23)
                    Case "SÁB"
                        J11 = CmdReader.GetString(24)
                        J12 = CmdReader.GetString(25)
                        J21 = CmdReader.GetString(26)
                        J22 = CmdReader.GetString(27)
                    Case "DOM"
                        J11 = CmdReader.GetString(28)
                        J12 = CmdReader.GetString(29)
                        J21 = CmdReader.GetString(30)
                        J22 = CmdReader.GetString(31)
                End Select

                Dim EmpRecord As frmMostrar
                EmpRecord = New frmMostrar()
                EmpRecord.oCedula = CmdReader.GetString(0)
                EmpRecord.oHoraCap = lblHora.Text
                EmpRecord.oNombre = CmdReader.GetString(1)
                EmpRecord.oApellido = CmdReader.GetString(2)
                EmpRecord.oHorario = J11
                EmpRecord.oJornada = "ENTRADA - MAÑANA"
                EmpRecord.MostrarRegistroCap()
            Else
                MsgBox("Error al registrar marcaje " &
            vbCrLf & vbCrLf & "Informe de Inmediato",
            MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                txtCodigo.Text = ""
                txtCodigo.Focus()
            End If
            CmdReader.Close()

            cnn.DesconectarMysql()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub InsertReg()
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand

        '  conn.ConnectionString = strConnection

        Try
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO myTable VALUES(NULL, @number, @text)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@number", 1)
            cmd.Parameters.AddWithValue("@text", "One")

            For i = 1 To 1000
                cmd.Parameters("@number").Value = i
                cmd.Parameters("@text").Value = "A string value"

                cmd.ExecuteNonQuery()
            Next
        Catch ex As MySqlException
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MostrarReg()

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub FrmMarcaje_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus


    End Sub
End Class