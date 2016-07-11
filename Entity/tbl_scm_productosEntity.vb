    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_scm_productos_Entity

#Region "Private Properties"

        Private _idproducto As Int32
        Private _prddescripcion As String
        Private _prdestado As Nullable(Of Int32)
        Private _prdnivel As Nullable(Of Int32)
        Private _idmedida As Int32

#End Region

#Region "Public Properties"


 Public Property Idproducto() As Int32
            Get
                Return _idproducto
            End Get
            Set(ByVal value As Int32)
                _idproducto = value
            End Set
        End Property


 Public Property Prddescripcion() As String
            Get
                Return _prddescripcion
            End Get
            Set(ByVal value As String)
                _prddescripcion = value
            End Set
        End Property


 Public Property Prdestado() As Nullable(Of Int32)
            Get
                Return _prdestado
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _prdestado = value
            End Set
        End Property


 Public Property Prdnivel() As Nullable(Of Int32)
            Get
                Return _prdnivel
            End Get
            Set(ByVal value As Nullable(Of Int32))
                _prdnivel = value
            End Set
        End Property


 Public Property Idmedida() As Int32
            Get
                Return _idmedida
            End Get
            Set(ByVal value As Int32)
                _idmedida = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

