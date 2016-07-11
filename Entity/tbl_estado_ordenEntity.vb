    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_estado_orden_Entity

#Region "Private Properties"

        Private _idestadoorden As Int32
        Private _nombreestadoorden As String

#End Region

#Region "Public Properties"


 Public Property Idestadoorden() As Int32
            Get
                Return _idestadoorden
            End Get
            Set(ByVal value As Int32)
                _idestadoorden = value
            End Set
        End Property


 Public Property Nombreestadoorden() As String
            Get
                Return _nombreestadoorden
            End Get
            Set(ByVal value As String)
                _nombreestadoorden = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

