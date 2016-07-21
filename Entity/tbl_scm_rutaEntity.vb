    'Derechos reservados    18/07/2016 9:31:13 p. m.
Public Class tbl_scm_ruta_Entity

#Region "Private Properties"

        Private _idruta As Int32
        Private _rtanombre As String
        Private _rtaestado As Nullable(Of Int32)

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


 Public Property Rtaestado() As Nullable(Of Int32)
            Get
                Return _rtaestado
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _rtaestado = value
            End Set
        End Property

    'Derechos reservados    18/07/2016 9:31:13 p. m.

#End Region

End Class

