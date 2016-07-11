Public Class Connection_Entity

    Dim _Login As String
    Dim _Password As String
    Dim _ServerName As String
    Dim _DataBaseName As String
    
    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal value As String)
            _Login = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property ServerName() As String
        Get
            Return _ServerName
        End Get
        Set(ByVal value As String)
            _ServerName = value
        End Set
    End Property

    Public Property DataBaseName() As String
        Get
            Return _DataBaseName
        End Get
        Set(ByVal value As String)
            _DataBaseName = value
        End Set
    End Property

End Class
