    'Derechos reservados    12/07/2016 6:50:52 p. m.
Public Class tbl_scm_vehiculos_Entity

#Region "Private Properties"

        Private _idvehiculos As Int32
        Private _idestadovehiculo As Int32
        Private _idtipovehiculo As Int32
        Private _idmarca As Int32
        Private _vhcmatricula As String
        Private _vhccolor As String
        Private _vhcmodelo As String
        Private _vhckmoriginal As Decimal
        Private _vhckmactual As Decimal
        Private _vhcfechaultimoservicio As DateTime
        Private _vhcfechacompra As DateTime

#End Region

#Region "Public Properties"


 Public Property Idvehiculos() As Int32
            Get
                Return _idvehiculos
            End Get
            Set(ByVal value As Int32)
                _idvehiculos = value
            End Set
        End Property


 Public Property Idestadovehiculo() As Int32
            Get
                Return _idestadovehiculo
            End Get
            Set(ByVal value As Int32)
                _idestadovehiculo = value
            End Set
        End Property


 Public Property Idtipovehiculo() As Int32
            Get
                Return _idtipovehiculo
            End Get
            Set(ByVal value As Int32)
                _idtipovehiculo = value
            End Set
        End Property


 Public Property Idmarca() As Int32
            Get
                Return _idmarca
            End Get
            Set(ByVal value As Int32)
                _idmarca = value
            End Set
        End Property


 Public Property Vhcmatricula() As String
            Get
                Return _vhcmatricula
            End Get
            Set(ByVal value As String)
                _vhcmatricula = value
            End Set
        End Property


 Public Property Vhccolor() As String
            Get
                Return _vhccolor
            End Get
            Set(ByVal value As String)
                _vhccolor = value
            End Set
        End Property


 Public Property Vhcmodelo() As String
            Get
                Return _vhcmodelo
            End Get
            Set(ByVal value As String)
                _vhcmodelo = value
            End Set
        End Property


 Public Property Vhckmoriginal() As Decimal
            Get
                Return _vhckmoriginal
            End Get
            Set(ByVal value As Decimal)
                _vhckmoriginal = value
            End Set
        End Property


 Public Property Vhckmactual() As Decimal
            Get
                Return _vhckmactual
            End Get
            Set(ByVal value As Decimal)
                _vhckmactual = value
            End Set
        End Property


 Public Property Vhcfechaultimoservicio() As DateTime
            Get
                Return _vhcfechaultimoservicio
            End Get
            Set(ByVal value As DateTime)
                _vhcfechaultimoservicio = value
            End Set
        End Property


 Public Property Vhcfechacompra() As DateTime
            Get
                Return _vhcfechacompra
            End Get
            Set(ByVal value As DateTime)
                _vhcfechacompra = value
            End Set
        End Property

    'Derechos reservados    12/07/2016 6:50:52 p. m.

#End Region

End Class

