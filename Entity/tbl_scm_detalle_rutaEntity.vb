    'Derechos reservados   18/07/2016 11:48:13 p. m.
Public Class tbl_scm_detalle_ruta_Entity

#Region "Private Properties"

        Private _idempleado As Int32
        Private _idvehiculos As Int32
        Private _idcliente As Int32
        Private _idordenesentrega As Nullable(Of Int32)
        Private _iddetruta As Int32
        Private _idruta As Nullable(Of Int32)

#End Region

#Region "Public Properties"


 Public Property Idempleado() As Int32
            Get
                Return _idempleado
            End Get
            Set(ByVal value As Int32)
                _idempleado = value
            End Set
        End Property


 Public Property Idvehiculos() As Int32
            Get
                Return _idvehiculos
            End Get
            Set(ByVal value As Int32)
                _idvehiculos = value
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


 Public Property Idordenesentrega() As Nullable(Of Int32)
            Get
                Return _idordenesentrega
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idordenesentrega = value
            End Set
        End Property


 Public Property Iddetruta() As Int32
            Get
                Return _iddetruta
            End Get
            Set(ByVal value As Int32)
                _iddetruta = value
            End Set
        End Property


 Public Property Idruta() As Nullable(Of Int32)
            Get
                Return _idruta
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idruta = value
            End Set
        End Property

    'Derechos reservados   18/07/2016 11:48:13 p. m.

#End Region

End Class

