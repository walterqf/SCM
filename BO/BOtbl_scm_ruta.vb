Imports DAL
Imports Entity

Public Class BOtbl_scm_ruta

    'Derechos reservados    18/07/2016 9:31:13 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) as tbl_scm_ruta_Entity
        Try
            Return DALtbl_scm_ruta.Insert(pConnection, ptbl_scm_ruta)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    18/07/2016 9:31:13 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) as Boolean
        Try
             Return DALtbl_scm_ruta.Update(pConnection, ptbl_scm_ruta)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    18/07/2016 9:31:13 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) 
        Try
            DALtbl_scm_ruta.Delete(pConnection, ptbl_scm_ruta)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados    18/07/2016 9:31:13 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) as DataTable
        Try
            Return DALtbl_scm_ruta.getAll(pConnection, ptbl_scm_ruta)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    18/07/2016 9:31:13 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) as tbl_scm_ruta_Entity
        Try
            Return DALtbl_scm_ruta.getSingle(pConnection, ptbl_scm_ruta)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

