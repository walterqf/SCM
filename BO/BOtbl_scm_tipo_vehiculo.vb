Imports DAL
Imports Entity

Public Class BOtbl_scm_tipo_vehiculo

    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_tipo_vehiculo as tbl_scm_tipo_vehiculo_Entity) as tbl_scm_tipo_vehiculo_Entity
        Try
            Return DALtbl_scm_tipo_vehiculo.Insert(pConnection, ptbl_scm_tipo_vehiculo)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_tipo_vehiculo as tbl_scm_tipo_vehiculo_Entity) as Boolean
        Try
             Return DALtbl_scm_tipo_vehiculo.Update(pConnection, ptbl_scm_tipo_vehiculo)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_tipo_vehiculo as tbl_scm_tipo_vehiculo_Entity) 
        Try
            DALtbl_scm_tipo_vehiculo.Delete(pConnection, ptbl_scm_tipo_vehiculo)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_tipo_vehiculo as tbl_scm_tipo_vehiculo_Entity) as DataTable
        Try
            Return DALtbl_scm_tipo_vehiculo.getAll(pConnection, ptbl_scm_tipo_vehiculo)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_tipo_vehiculo as tbl_scm_tipo_vehiculo_Entity) as tbl_scm_tipo_vehiculo_Entity
        Try
            Return DALtbl_scm_tipo_vehiculo.getSingle(pConnection, ptbl_scm_tipo_vehiculo)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

