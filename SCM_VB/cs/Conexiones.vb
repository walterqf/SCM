
Public Class Conexiones
    ''' <summary>
    ''' Conexion con la base de datos STF
    ''' </summary>
    ''' <param name="pUsuario"></param>
    ''' <param name="pPassword"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Public Shared Function EntityConnection_DB(ByVal pUsuario As String, ByVal pPassword As String) As Entity.Connection_Entity
        'Conecta con la base de datos y servidor de seguridad
        Dim gConnection As New Entity.Connection_Entity

        If pUsuario = "" Or pPassword = "" Then
            gConnection.Login = System.Configuration.ConfigurationManager.AppSettings("userhdv").ToString
            gConnection.Password = Globales.Encripta(System.Configuration.ConfigurationManager.AppSettings("passhdv").ToString)
        Else
            gConnection.Login = pUsuario
            gConnection.Password = Globales.Encripta(pPassword)
        End If


        gConnection.ServerName = System.Configuration.ConfigurationManager.AppSettings("srvadmin").ToString
        gConnection.DataBaseName = System.Configuration.ConfigurationManager.AppSettings("bdDB5").ToString


        Return gConnection

    End Function

End Class
