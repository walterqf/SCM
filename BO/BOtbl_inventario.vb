Imports DAL
Imports Entity

Public Class BOtbl_inventario

    'Derechos reservados  12/07/2016 19:26:33
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) as tbl_inventario_Entity
        Try
            Return DALtbl_inventario.Insert(pConnection, ptbl_inventario)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  12/07/2016 19:26:33
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) as Boolean
        Try
             Return DALtbl_inventario.Update(pConnection, ptbl_inventario)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  12/07/2016 19:26:33
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) 
        Try
            DALtbl_inventario.Delete(pConnection, ptbl_inventario)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados  12/07/2016 19:26:33
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) as DataTable
        Try
            Return DALtbl_inventario.getAll(pConnection, ptbl_inventario)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  12/07/2016 19:26:33
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) as tbl_inventario_Entity
        Try
            Return DALtbl_inventario.getSingle(pConnection, ptbl_inventario)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

