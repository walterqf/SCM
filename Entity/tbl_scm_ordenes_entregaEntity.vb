    'Derechos reservados    20/07/2016 1:15:00 a. m.
Public Class tbl_scm_ordenes_entrega_Entity

#Region "Private Properties"

        Private _idordenesentrega As Int32
        Private _orddescripcion As String
        Private _idorden As Nullable(Of Int32)
        Private _idscmestadoorden As Nullable(Of Int32)
        Private _idcliente As Nullable(Of Int32)

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


 Public Property Idorden() As Nullable(Of Int32)
            Get
                Return _idorden
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idorden = value
            End Set
        End Property


 Public Property Idscmestadoorden() As Nullable(Of Int32)
            Get
                Return _idscmestadoorden
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idscmestadoorden = value
            End Set
        End Property


 Public Property Idcliente() As Nullable(Of Int32)
            Get
                Return _idcliente
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _idcliente = value
            End Set
        End Property

    'Derechos reservados    20/07/2016 1:15:00 a. m.

#End Region

End Class

