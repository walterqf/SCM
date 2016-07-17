    'Derechos reservados    14/07/2016 4:44:29 p. m.
Public Class tbl_scm_detalle_ordenes_Entity

#Region "Private Properties"

        Private _iddetalleordenes As Int32
        Private _idordenesentrega As Int32
        Private _detcostototal As Decimal
        Private _idruta As Int32
        Private _idscmestadoorden As Int32
        Private _idcliente As Int32
        Private _detvolumenpeso As String
        Private _detcantidadproducto As String
        Private _detfechasolicitud As String
        Private _detfechaentrega As String
        Private _idproducto As Nullable(Of Int32)

#End Region

#Region "Public Properties"


 Public Property Iddetalleordenes() As Int32
            Get
                Return _iddetalleordenes
            End Get
            Set(ByVal value As Int32)
                _iddetalleordenes = value
            End Set
        End Property


 Public Property Idordenesentrega() As Int32
            Get
                Return _idordenesentrega
            End Get
            Set(ByVal value As Int32)
                _idordenesentrega = value
            End Set
        End Property


 Public Property Detcostototal() As Decimal
            Get
                Return _detcostototal
            End Get
            Set(ByVal value As Decimal)
                _detcostototal = value
            End Set
        End Property


 Public Property Idruta() As Int32
            Get
                Return _idruta
            End Get
            Set(ByVal value As Int32)
                _idruta = value
            End Set
        End Property


 Public Property Idscmestadoorden() As Int32
            Get
                Return _idscmestadoorden
            End Get
            Set(ByVal value As Int32)
                _idscmestadoorden = value
            End Set
        End Property


 Public Property Idcliente() As Int32
            Get
                Return _idcliente
            End Get
            Set(ByVal value As Int32)
                _idcliente = value
            End Set
        End Property


 Public Property Detvolumenpeso() As String
            Get
                Return _detvolumenpeso
            End Get
            Set(ByVal value As String)
                _detvolumenpeso = value
            End Set
        End Property


 Public Property Detcantidadproducto() As String
            Get
                Return _detcantidadproducto
            End Get
            Set(ByVal value As String)
                _detcantidadproducto = value
            End Set
        End Property


 Public Property Detfechasolicitud() As String
            Get
                Return _detfechasolicitud
            End Get
            Set(ByVal value As String)
                _detfechasolicitud = value
            End Set
        End Property


 Public Property Detfechaentrega() As String
            Get
                Return _detfechaentrega
            End Get
            Set(ByVal value As String)
                _detfechaentrega = value
            End Set
        End Property


 Public Property Idproducto() As Nullable(Of Int32)
            Get
                Return _idproducto
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idproducto = value
            End Set
        End Property

    'Derechos reservados    14/07/2016 4:44:29 p. m.

#End Region

End Class

