    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_scm_medidas_productos_Entity

#Region "Private Properties"

        Private _idmedida As Int32
        Private _meddescripcion As String
        Private _medsimbolo As String
        Private _medmedidas As Nullable(Of Int32)
        Private _medestado As Nullable(Of Int32)
        Private _mednivel As Nullable(Of Int32)

#End Region

#Region "Public Properties"


 Public Property Idmedida() As Int32
            Get
                Return _idmedida
            End Get
            Set(ByVal value As Int32)
                _idmedida = value
            End Set
        End Property


 Public Property Meddescripcion() As String
            Get
                Return _meddescripcion
            End Get
            Set(ByVal value As String)
                _meddescripcion = value
            End Set
        End Property


 Public Property Medsimbolo() As String
            Get
                Return _medsimbolo
            End Get
            Set(ByVal value As String)
                _medsimbolo = value
            End Set
        End Property


 Public Property Medmedidas() As Nullable(Of Int32)
            Get
                Return _medmedidas
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _medmedidas = value
            End Set
        End Property


 Public Property Medestado() As Nullable(Of Int32)
            Get
                Return _medestado
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _medestado = value
            End Set
        End Property


 Public Property Mednivel() As Nullable(Of Int32)
            Get
                Return _mednivel
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _mednivel = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

