Imports MySql.Data.MySqlClient
Imports System

Namespace DesignMysql
    Public Class Conexion
        Implements IDisposable
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
        Protected Overridable Overloads Sub Dispose(disposing As Boolean)

            If disposing Then
                ' dispose managed resources
                Connection.Close()
            End If
        End Sub 'Dispose


        Public Overloads Sub Dispose() Implements IDisposable.Dispose

            Dispose(True)
            GC.SuppressFinalize(Me)

        End Sub 'Dispose


    End Class
End Namespace

