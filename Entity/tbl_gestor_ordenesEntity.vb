    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_gestor_ordenes_Entity

#Region "Private Properties"

        Private _idgestorordenes As Int32
        Private _nombresolicitanteorden As String
        Private _nombrecomercialsolicitanteorden As String
        Private _nitsolicitanteorden As String
        Private _direccionsolicitanteorden As String
        Private _telefonosolicitanteorden As String
        Private _idtipogestor As Int32
        Private _idempresa As Int32
        Private _idusuario As Int32

#End Region

#Region "Public Properties"


 Public Property Idgestorordenes() As Int32
            Get
                Return _idgestorordenes
            End Get
            Set(ByVal value As Int32)
                _idgestorordenes = value
            End Set
        End Property


 Public Property Nombresolicitanteorden() As String
            Get
                Return _nombresolicitanteorden
            End Get
            Set(ByVal value As String)
                _nombresolicitanteorden = value
            End Set
        End Property


 Public Property Nombrecomercialsolicitanteorden() As String
            Get
                Return _nombrecomercialsolicitanteorden
            End Get
            Set(ByVal value As String)
                _nombrecomercialsolicitanteorden = value
            End Set
        End Property


 Public Property Nitsolicitanteorden() As String
            Get
                Return _nitsolicitanteorden
            End Get
            Set(ByVal value As String)
                _nitsolicitanteorden = value
            End Set
        End Property


 Public Property Direccionsolicitanteorden() As String
            Get
                Return _direccionsolicitanteorden
            End Get
            Set(ByVal value As String)
                _direccionsolicitanteorden = value
            End Set
        End Property


 Public Property Telefonosolicitanteorden() As String
            Get
                Return _telefonosolicitanteorden
            End Get
            Set(ByVal value As String)
                _telefonosolicitanteorden = value
            End Set
        End Property


 Public Property Idtipogestor() As Int32
            Get
                Return _idtipogestor
            End Get
            Set(ByVal value As Int32)
                _idtipogestor = value
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


 Public Property Idusuario() As Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As Int32)
                _idusuario = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

