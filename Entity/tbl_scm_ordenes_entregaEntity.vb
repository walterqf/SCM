    'Derechos reservados    11/07/2016 7:07:10 p. m.
Public Class tbl_scm_ordenes_entrega_Entity

#Region "Private Properties"

        Private _idordenesentrega As Int32
        Private _orddescripcion As String

#End Region

#Region "Public Properties"


 Public Property Idordenesentrega() As Int32
            Get
                Return _idordenesentrega
            End Get
            Set(ByVal value As Int32)
                _idordenesentrega = value
            End Set
        End Property


 Public Property Orddescripcion() As String
            Get
                Return _orddescripcion
            End Get
            Set(ByVal value As String)
                _orddescripcion = value
            End Set
        End Property

    'Derechos reservados    11/07/2016 7:07:10 p. m.

#End Region

End Class

