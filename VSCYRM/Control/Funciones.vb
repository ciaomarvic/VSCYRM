Public Class Funciones
    Public Function ValidarSupervisor(Codigo As String) As Boolean
        Dim Resp As Boolean
        If Codigo = "123" Then
            Resp = True
        Else
            Resp = False
        End If
        Return Resp
    End Function
End Class
