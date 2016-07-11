    ' 26/06/2016 16:42:14
Public Class tbl_scm_usuarios_Entity

#Region "Private Properties"

        Private _idusuario As Int32
        Private _medloginid As String
        Private _medpassid As String
        Private _mednombre As String
        Private _medestado As Nullable(Of Int32)
        Private _mednivel As Nullable(Of Int32)
        Private _medfechacreacion As Nullable(Of Int32)

#End Region

#Region "Public Properties"


 Public Property Idusuario() As Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As Int32)
                _idusuario = value
            End Set
        End Property


 Public Property Medloginid() As String
            Get
                Return _medloginid
            End Get
            Set(ByVal value As String)
                _medloginid = value
            End Set
        End Property


 Public Property Medpassid() As String
            Get
                Return _medpassid
            End Get
            Set(ByVal value As String)
                _medpassid = value
            End Set
        End Property


 Public Property Mednombre() As String
            Get
                Return _mednombre
            End Get
            Set(ByVal value As String)
                _mednombre = value
            End Set
        End Property


 Public Property Medestado() As Nullable(Of Int32)
            Get
                Return _medestado
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _medestado = value
            End Set
        End Property


 Public Property Mednivel() As Nullable(Of Int32)
            Get
                Return _mednivel
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _mednivel = value
            End Set
        End Property


 Public Property Medfechacreacion() As Nullable(Of Int32)
            Get
                Return _medfechacreacion
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _medfechacreacion = value
            End Set
        End Property

    ' 26/06/2016 16:42:14

#End Region

End Class

