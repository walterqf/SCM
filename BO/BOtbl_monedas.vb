Imports DAL
Imports Entity

Public Class BOtbl_monedas

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) as tbl_monedas_Entity
        Try
            Return DALtbl_monedas.Insert(pConnection, ptbl_monedas)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) as Boolean
        Try
             Return DALtbl_monedas.Update(pConnection, ptbl_monedas)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) 
        Try
            DALtbl_monedas.Delete(pConnection, ptbl_monedas)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) as DataTable
        Try
            Return DALtbl_monedas.getAll(pConnection, ptbl_monedas)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) as tbl_monedas_Entity
        Try
            Return DALtbl_monedas.getSingle(pConnection, ptbl_monedas)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

