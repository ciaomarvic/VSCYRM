Imports MySql.Data.MySqlClient
Public Class Conexion
    Public Connection As MySqlConnection
    Public Command As MySqlCommand
    Public Sub ConectarMysql()
        Try
            Connection = New MySqlConnection()
            Connection.ConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=s3rv3r;" _
            & "port=3306;" _
            & "database=vscyrm;"

            Connection.Open()
            '  MsgBox("Conectado " &
            '  vbCrLf & vbCrLf,
            '  MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error al conectar al servidor MySQL " &
            vbCrLf & vbCrLf & ex.Message,
            MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub DesconectarMysql()
        Connection.Close()
    End Sub

End Class
