    'Derechos reservados  12/07/2016 19:26:33
Public Class tbl_inventario_Entity

#Region "Private Properties"

        Private _idinventario As Int32
        Private _costounitarioproducto As Decimal
        Private _tipocambio As Decimal
        Private _idorden As Int32
        Private _cantidadproducto As Int32
        Private _cantidadreal As Int32
        Private _idbodega As Int32
        Private _cantidadactual As Int32
        Private _productominimo As Int32
        Private _productomaximo As Int32
        Private _productooptimo As Int32
        Private _idusuario As Int32
        Private _idproducto As Int32

#End Region

#Region "Public Properties"


 Public Property Idinventario() As Int32
            Get
                Return _idinventario
            End Get
            Set(ByVal value As Int32)
                _idinventario = value
            End Set
        End Property


 Public Property Costounitarioproducto() As Decimal
            Get
                Return _costounitarioproducto
            End Get
            Set(ByVal value As Decimal)
                _costounitarioproducto = value
            End Set
        End Property


 Public Property Tipocambio() As Decimal
            Get
                Return _tipocambio
            End Get
            Set(ByVal value As Decimal)
                _tipocambio = value
            End Set
        End Property


 Public Property Idorden() As Int32
            Get
                Return _idorden
            End Get
            Set(ByVal value As Int32)
                _idorden = value
            End Set
        End Property


 Public Property Cantidadproducto() As Int32
            Get
                Return _cantidadproducto
            End Get
            Set(ByVal value As Int32)
                _cantidadproducto = value
            End Set
        End Property


 Public Property Cantidadreal() As Int32
            Get
                Return _cantidadreal
            End Get
            Set(ByVal value As Int32)
                _cantidadreal = value
            End Set
        End Property


 Public Property Idbodega() As Int32
            Get
                Return _idbodega
            End Get
            Set(ByVal value As Int32)
                _idbodega = value
            End Set
        End Property


 Public Property Cantidadactual() As Int32
            Get
                Return _cantidadactual
            End Get
            Set(ByVal value As Int32)
                _cantidadactual = value
            End Set
        End Property


 Public Property Productominimo() As Int32
            Get
                Return _productominimo
            End Get
            Set(ByVal value As Int32)
                _productominimo = value
            End Set
        End Property


 Public Property Productomaximo() As Int32
            Get
                Return _productomaximo
            End Get
            Set(ByVal value As Int32)
                _productomaximo = value
            End Set
        End Property


 Public Property Productooptimo() As Int32
            Get
                Return _productooptimo
            End Get
            Set(ByVal value As Int32)
                _productooptimo = value
            End Set
        End Property


 Public Property Idusuario() As Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As Int32)
                _idusuario = value
            End Set
        End Property


 Public Property Idproducto() As Int32
            Get
                Return _idproducto
            End Get
            Set(ByVal value As Int32)
                _idproducto = value
            End Set
        End Property

    'Derechos reservados  12/07/2016 19:26:34

#End Region

End Class

