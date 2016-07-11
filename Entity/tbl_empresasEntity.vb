    'Derechos reservados  10/07/2016 14:14:51
Public Class tbl_empresas_Entity

#Region "Private Properties"

        Private _idempresa As Int32
        Private _empdireccion As String
        Private _empnit As String
        Private _empnombre As String
        Private _empactivo As Int32

#End Region

#Region "Public Properties"


 Public Property Idempresa() As Int32
            Get
                Return _idempresa
            End Get
            Set(ByVal value As Int32)
                _idempresa = value
            End Set
        End Property


 Public Property Empdireccion() As String
            Get
                Return _empdireccion
            End Get
            Set(ByVal value As String)
                _empdireccion = value
            End Set
        End Property


 Public Property Empnit() As String
            Get
                Return _empnit
            End Get
            Set(ByVal value As String)
                _empnit = value
            End Set
        End Property


 Public Property Empnombre() As String
            Get
                Return _empnombre
            End Get
            Set(ByVal value As String)
                _empnombre = value
            End Set
        End Property


 Public Property Empactivo() As Int32
            Get
                Return _empactivo
            End Get
            Set(ByVal value As Int32)
                _empactivo = value
            End Set
        End Property

    'Derechos reservados  10/07/2016 14:14:51

#End Region

End Class

