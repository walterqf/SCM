    'Derechos reservados    12/07/2016 6:50:52 p. m.
Public Class tbl_scm_marca_vehiculo_Entity

#Region "Private Properties"

        Private _idmarca As Int32
        Private _mrcmarca As String

#End Region

#Region "Public Properties"


 Public Property Idmarca() As Int32
            Get
                Return _idmarca
            End Get
            Set(ByVal value As Int32)
                _idmarca = value
            End Set
        End Property


 Public Property Mrcmarca() As String
            Get
                Return _mrcmarca
            End Get
            Set(ByVal value As String)
                _mrcmarca = value
            End Set
        End Property

    'Derechos reservados    12/07/2016 6:50:52 p. m.

#End Region

End Class

