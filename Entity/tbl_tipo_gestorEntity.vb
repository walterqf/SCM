    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_tipo_gestor_Entity

#Region "Private Properties"

        Private _idtipogestor As Int32
        Private _nombretipogestor As String

#End Region

#Region "Public Properties"


 Public Property Idtipogestor() As Int32
            Get
                Return _idtipogestor
            End Get
            Set(ByVal value As Int32)
                _idtipogestor = value
            End Set
        End Property


 Public Property Nombretipogestor() As String
            Get
                Return _nombretipogestor
            End Get
            Set(ByVal value As String)
                _nombretipogestor = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

