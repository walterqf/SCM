    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_monedas_Entity

#Region "Private Properties"

        Private _idmoneda As Int32
        Private _simbolomoneda As String
        Private _nombremoneda As String

#End Region

#Region "Public Properties"


 Public Property Idmoneda() As Int32
            Get
                Return _idmoneda
            End Get
            Set(ByVal value As Int32)
                _idmoneda = value
            End Set
        End Property


 Public Property Simbolomoneda() As String
            Get
                Return _simbolomoneda
            End Get
            Set(ByVal value As String)
                _simbolomoneda = value
            End Set
        End Property


 Public Property Nombremoneda() As String
            Get
                Return _nombremoneda
            End Get
            Set(ByVal value As String)
                _nombremoneda = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

