    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_bodegas_Entity

#Region "Private Properties"

        Private _idbodega As Int32
        Private _nombrebodega As String
        Private _idempresa As Int32
        Private _bdgdireccion As String
        Private _idusuario As Int32

#End Region

#Region "Public Properties"


 Public Property Idbodega() As Int32
            Get
                Return _idbodega
            End Get
            Set(ByVal value As Int32)
                _idbodega = value
            End Set
        End Property


 Public Property Nombrebodega() As String
            Get
                Return _nombrebodega
            End Get
            Set(ByVal value As String)
                _nombrebodega = value
            End Set
        End Property


 Public Property Idempresa() As Int32
            Get
                Return _idempresa
            End Get
            Set(ByVal value As Int32)
                _idempresa = value
            End Set
        End Property


 Public Property Bdgdireccion() As String
            Get
                Return _bdgdireccion
            End Get
            Set(ByVal value As String)
                _bdgdireccion = value
            End Set
        End Property


 Public Property Idusuario() As Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As Int32)
                _idusuario = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

