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

        Dim Cumpleaños As Boolean = False
        Dim Sql As String

        Dim Nombre As String
        Dim Apellido As String
        Dim Cedula As String
        Dim Cargo As String
        Dim Dia As String
        Dim Jornada As String
        Dim Fecha As String

        Dim J11 As String = ""
        Dim J12 As String = ""
        Dim J21 As String = ""
        Dim J22 As String = ""
        Dim NumJornadas As String
        Dim CompletaJor As Boolean
        Dim EmpRecord As frmMostrar

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

            If CmdReader.Read Then
                Fecha = DateTime.Now
                Debug.Print(Fecha)
                Cedula = CmdReader.GetString(0)
                NumJornadas = CmdReader.GetString(1)
                Nombre = CmdReader.GetString(2)
                Apellido = CmdReader.GetString(3)
                Cargo = CmdReader.GetString(4)
                Cumpleaños = IIf(CmdReader.GetString(5).Equals("S"), True, False)
                J11 = CmdReader.GetString(6)
                J12 = CmdReader.GetString(7)
                J21 = CmdReader.GetString(8)
                J22 = CmdReader.GetString(9)

                EmpRecord = New frmMostrar()
                EmpRecord.oCedula = Cedula
                EmpRecord.oHoraCap = lblHora.Text
                EmpRecord.oNombre = Nombre
                EmpRecord.oApellido = Apellido

                Select Case NumJornadas
                    Case "0"
                        EmpRecord.oJornada = "ENTRADA - 1º JORNADA"
                        EmpRecord.oHorario = J11
                        Jornada = Dia + "11"
                    Case "1"
                        EmpRecord.oJornada = "SALIDA  - 1º JORNADA"
                        EmpRecord.oHorario = J12
                        Jornada = Dia + "12"
                    Case "2"
                        EmpRecord.oJornada = "ENTRADA - 2º JORNADA"
                        EmpRecord.oHorario = J21
                        Jornada = Dia + "21"
                    Case "3"
                        EmpRecord.oJornada = "SALIDA  - 2º JORNADA"
                        EmpRecord.oHorario = J22
                        Jornada = Dia + "22"
                    Case Else
                        CompletaJor = True
                End Select

                If Not CompletaJor Then
                    If Cumpleaños Then
                        EmpRecord.Cumplefrm()
                    Else
                        EmpRecord.Restaurarfrm()
                    End If
                    EmpRecord.MostrarRegistroCap()
                Else
                    MsgBox("Registros del Dia Completados")

                    ' EmpRecord.ConsultarRegistroCap()
                End If

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


    Friend Sub InsertReg(I_Cedula As String, I_Fecha As String, I_HoraAsig As String, I_HoraCap As String, I_Jornada As String)
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