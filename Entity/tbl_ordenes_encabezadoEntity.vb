'Derechos reservados 12/07/2016 18:01:34
Public Class tbl_ordenes_encabezado_Entity

#Region "Private Properties"

    Private _idorden As Int32
    Private _fechamovmiento As DateTime
    Private _ivaorden As Nullable(Of Decimal)
    Private _ivaorden1 As Decimal
    Private _totalorden As Decimal
    Private _idusuario As Int32
    Private _idtipoorden As Int32
    Private _idgestorordenes As Int32
    Private _idestadoorden As Int32
    Private _idempresa As Int32

#End Region

#Region "Public Properties"


    Public Property Idorden() As Int32
        Get
            Return _idorden
        End Get
        Set(ByVal value As Int32)
            _idorden = value
        End Set
    End Property


    Public Property Fechamovmiento() As DateTime
        Get
            Return _fechamovmiento
        End Get
        Set(ByVal value As DateTime)
            _fechamovmiento = value
        End Set
    End Property


    Public Property Ivaorden() As Nullable(Of Decimal)
        Get
            Return _ivaorden
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _ivaorden = value
        End Set
    End Property


    Public Property Ivaorden1() As Decimal
        Get
            Return _ivaorden1
        End Get
        Set(ByVal value As Decimal)
            _ivaorden1 = value
        End Set
    End Property


    Public Property Totalorden() As Decimal
        Get
            Return _totalorden
        End Get
        Set(ByVal value As Decimal)
            _totalorden = value
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


    Public Property Idtipoorden() As Int32
        Get
            Return _idtipoorden
        End Get
        Set(ByVal value As Int32)
            _idtipoorden = value
        End Set
    End Property


    Public Property Idgestorordenes() As Int32
        Get
            Return _idgestorordenes
        End Get
        Set(ByVal value As Int32)
            _idgestorordenes = value
        End Set
    End Property


    Public Property Idestadoorden() As Int32
        Get
            Return _idestadoorden
        End Get
        Set(ByVal value As Int32)
            _idestadoorden = value
        End Set
    End Property

    Public Property Idempresa() As Int32
        Get
            Return _idempresa
        End Get
        Set(ByVal value As Int32)
            _idempresa = value
        End Set
    End Property

    'Derechos reservados 12/07/2016 18:01:34

#End Region

End Class

