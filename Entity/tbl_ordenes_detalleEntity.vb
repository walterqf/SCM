'Derechos reservados 12/07/2016 18:01:33
Public Class tbl_ordenes_detalle_Entity

#Region "Private Properties"

    Private _idordenesdetalle As Int32
    Private _costounitarioproducto As Decimal
    Private _cantidadproducto As Int32
    Private _tipocambio As Decimal
    Private _idorden As Int32
    Private _idmoneda As Int32
    Private _idproducto As Int32
    Private _idbodega As Int32

#End Region

#Region "Public Properties"


    Public Property Idordenesdetalle() As Int32
        Get
            Return _idordenesdetalle
        End Get
        Set(ByVal value As Int32)
            _idordenesdetalle = value
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


    Public Property Cantidadproducto() As Int32
        Get
            Return _cantidadproducto
        End Get
        Set(ByVal value As Int32)
            _cantidadproducto = value
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


    Public Property Idmoneda() As Int32
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As Int32)
            _idmoneda = value
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


    Public Property Idbodega() As Int32
        Get
            Return _idbodega
        End Get
        Set(ByVal value As Int32)
            _idbodega = value
        End Set
    End Property

    'Derechos reservados 12/07/2016 18:01:33

#End Region

End Class

