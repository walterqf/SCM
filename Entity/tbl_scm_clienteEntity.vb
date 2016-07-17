    'Derechos reservados    12/07/2016 6:50:52 p. m.
Public Class tbl_scm_cliente_Entity

#Region "Private Properties"

        Private _idcliente As Int32
        Private _cliprimernombre As String
        Private _clisegundonombre As String
        Private _cliprimerapellido As String
        Private _clisegundoapellido As String
        Private _clidireccion As String
        Private _clitelefono As String

#End Region

#Region "Public Properties"


 Public Property Idcliente() As Int32
            Get
                Return _idcliente
            End Get
            Set(ByVal value As Int32)
                _idcliente = value
            End Set
        End Property


 Public Property Cliprimernombre() As String
            Get
                Return _cliprimernombre
            End Get
            Set(ByVal value As String)
                _cliprimernombre = value
            End Set
        End Property


 Public Property Clisegundonombre() As String
            Get
                Return _clisegundonombre
            End Get
            Set(ByVal value As String)
                _clisegundonombre = value
            End Set
        End Property


 Public Property Cliprimerapellido() As String
            Get
                Return _cliprimerapellido
            End Get
            Set(ByVal value As String)
                _cliprimerapellido = value
            End Set
        End Property


 Public Property Clisegundoapellido() As String
            Get
                Return _clisegundoapellido
            End Get
            Set(ByVal value As String)
                _clisegundoapellido = value
            End Set
        End Property


 Public Property Clidireccion() As String
            Get
                Return _clidireccion
            End Get
            Set(ByVal value As String)
                _clidireccion = value
            End Set
        End Property


 Public Property Clitelefono() As String
            Get
                Return _clitelefono
            End Get
            Set(ByVal value As String)
                _clitelefono = value
            End Set
        End Property

    'Derechos reservados    12/07/2016 6:50:52 p. m.

#End Region

End Class

