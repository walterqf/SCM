Imports DAL
Imports Entity

Public Class BOtbl_ordenes_encabezado

    'Derechos reservados 12/07/2016 18:01:34
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) as tbl_ordenes_encabezado_Entity
        Try
            Return DALtbl_ordenes_encabezado.Insert(pConnection, ptbl_ordenes_encabezado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:34
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) as Boolean
        Try
             Return DALtbl_ordenes_encabezado.Update(pConnection, ptbl_ordenes_encabezado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:34
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) 
        Try
            DALtbl_ordenes_encabezado.Delete(pConnection, ptbl_ordenes_encabezado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados 12/07/2016 18:01:34
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) as DataTable
        Try
            Return DALtbl_ordenes_encabezado.getAll(pConnection, ptbl_ordenes_encabezado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados 12/07/2016 18:01:34
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) as tbl_ordenes_encabezado_Entity
        Try
            Return DALtbl_ordenes_encabezado.getSingle(pConnection, ptbl_ordenes_encabezado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

