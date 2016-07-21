    'Derechos reservados    12/07/2016 6:50:52 p. m.
Public Class tbl_scm_empleados_Entity

#Region "Private Properties"

        Private _idempleado As Int32
        Private _emptelefono As String
        Private _empprimernombre As String
        Private _empsegundonombre As String
        Private _empprimerapellido As String
        Private _empsegundoapellido As String
        Private _empcargo As String
        Private _empsueldo As Decimal

#End Region

#Region "Public Properties"


 Public Property Idempleado() As Int32
            Get
                Return _idempleado
            End Get
            Set(ByVal value As Int32)
                _idempleado = value
            End Set
        End Property


 Public Property Emptelefono() As String
            Get
                Return _emptelefono
            End Get
            Set(ByVal value As String)
                _emptelefono = value
            End Set
        End Property


 Public Property Empprimernombre() As String
            Get
                Return _empprimernombre
            End Get
            Set(ByVal value As String)
                _empprimernombre = value
            End Set
        End Property


 Public Property Empsegundonombre() As String
            Get
                Return _empsegundonombre
            End Get
            Set(ByVal value As String)
                _empsegundonombre = value
            End Set
        End Property


 Public Property Empprimerapellido() As String
            Get
                Return _empprimerapellido
            End Get
            Set(ByVal value As String)
                _empprimerapellido = value
            End Set
        End Property


 Public Property Empsegundoapellido() As String
            Get
                Return _empsegundoapellido
            End Get
            Set(ByVal value As String)
                _empsegundoapellido = value
            End Set
        End Property


 Public Property Empcargo() As String
            Get
                Return _empcargo
            End Get
            Set(ByVal value As String)
                _empcargo = value
            End Set
        End Property


 Public Property Empsueldo() As Decimal
            Get
                Return _empsueldo
            End Get
            Set(ByVal value As Decimal)
                _empsueldo = value
            End Set
        End Property

    'Derechos reservados    12/07/2016 6:50:52 p. m.

#End Region

End Class

