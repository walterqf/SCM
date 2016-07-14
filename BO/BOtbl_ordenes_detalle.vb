Imports DAL
Imports Entity

Public Class BOtbl_ordenes_detalle

    'Derechos reservados 12/07/2016 18:01:33
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) as tbl_ordenes_detalle_Entity
        Try
            Return DALtbl_ordenes_detalle.Insert(pConnection, ptbl_ordenes_detalle)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:33
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) as Boolean
        Try
             Return DALtbl_ordenes_detalle.Update(pConnection, ptbl_ordenes_detalle)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:33
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) 
        Try
            DALtbl_ordenes_detalle.Delete(pConnection, ptbl_ordenes_detalle)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados 12/07/2016 18:01:33
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) as DataTable
        Try
            Return DALtbl_ordenes_detalle.getAll(pConnection, ptbl_ordenes_detalle)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:33
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) as tbl_ordenes_detalle_Entity
        Try
            Return DALtbl_ordenes_detalle.getSingle(pConnection, ptbl_ordenes_detalle)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

