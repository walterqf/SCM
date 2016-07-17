    'Derechos reservados    12/07/2016 6:50:52 p. m.
Public Class tbl_scm_ruta_Entity

#Region "Private Properties"

        Private _idruta As Int32
        Private _rtanombre As String

#End Region

#Region "Public Properties"


 Public Property Idruta() As Int32
            Get
                Return _idruta
            End Get
            Set(ByVal value As Int32)
                _idruta = value
            End Set
        End Property


 Public Property Rtanombre() As String
            Get
                Return _rtanombre
            End Get
            Set(ByVal value As String)
                _rtanombre = value
            End Set
        End Property

    'Derechos reservados    12/07/2016 6:50:52 p. m.

#End Region

End Class

