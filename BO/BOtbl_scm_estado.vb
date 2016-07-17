Imports DAL
Imports Entity

Public Class BOtbl_scm_estado

    'Derechos reservados    11/07/2016 7:21:37 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) as tbl_scm_estado_Entity
        Try
            Return DALtbl_scm_estado.Insert(pConnection, ptbl_scm_estado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    11/07/2016 7:21:37 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) as Boolean
        Try
             Return DALtbl_scm_estado.Update(pConnection, ptbl_scm_estado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    11/07/2016 7:21:37 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) 
        Try
            DALtbl_scm_estado.Delete(pConnection, ptbl_scm_estado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados    11/07/2016 7:21:37 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) as DataTable
        Try
            Return DALtbl_scm_estado.getAll(pConnection, ptbl_scm_estado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    11/07/2016 7:21:37 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) as tbl_scm_estado_Entity
        Try
            Return DALtbl_scm_estado.getSingle(pConnection, ptbl_scm_estado)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

