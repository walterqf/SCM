'Derechos reservados  19/07/2016 18:02:10
Public Class tbl_hist_mant_vehiculos_Entity

#Region "Private Properties"

    Private _idordenhistmant As Int32
    Private _fechamant As Nullable(Of DateTime)
    Private _idorden As Nullable(Of Int32)
    Private _idestado As Nullable(Of Int32)
    Private _idnivel As Nullable(Of Int32)

#End Region

#Region "Public Properties"


    Public Property Idordenhistmant() As Int32
        Get
            Return _idordenhistmant
        End Get
        Set(ByVal value As Int32)
            _idordenhistmant = value
        End Set
    End Property


    Public Property Fechamant() As Nullable(Of DateTime)
        Get
            Return _fechamant
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _fechamant = value
        End Set
    End Property


    Public Property Idorden() As Nullable(Of Int32)
        Get
            Return _idorden
        End Get
        Set(ByVal value As Nullable(Of Int32))
            _idorden = value
        End Set
    End Property


    Public Property Idestado() As Nullable(Of Int32)
        Get
            Return _idestado
        End Get
        Set(ByVal value As Nullable(Of Int32))
            _idestado = value
        End Set
    End Property


    Public Property Idnivel() As Nullable(Of Int32)
        Get
            Return _idnivel
        End Get
        Set(ByVal value As Nullable(Of Int32))
            _idnivel = value
        End Set
    End Property

    'Derechos reservados  19/07/2016 18:02:10

#End Region

End Class

