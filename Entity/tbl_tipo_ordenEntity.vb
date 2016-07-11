    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_tipo_orden_Entity

#Region "Private Properties"

        Private _idtipoorden As Int32
        Private _descripcionorden As String

#End Region

#Region "Public Properties"


 Public Property Idtipoorden() As Int32
            Get
                Return _idtipoorden
            End Get
            Set(ByVal value As Int32)
                _idtipoorden = value
            End Set
        End Property


 Public Property Descripcionorden() As String
            Get
                Return _descripcionorden
            End Get
            Set(ByVal value As String)
                _descripcionorden = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

