Imports DAL
Imports Entity

Public Class BOtbl_hist_mant_vehiculos

    'Derechos reservados  19/07/2016 18:02:10
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) as tbl_hist_mant_vehiculos_Entity
        Try
            Return DALtbl_hist_mant_vehiculos.Insert(pConnection, ptbl_hist_mant_vehiculos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  19/07/2016 18:02:10
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) as Boolean
        Try
             Return DALtbl_hist_mant_vehiculos.Update(pConnection, ptbl_hist_mant_vehiculos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  19/07/2016 18:02:10
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) 
        Try
            DALtbl_hist_mant_vehiculos.Delete(pConnection, ptbl_hist_mant_vehiculos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados  19/07/2016 18:02:10
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) as DataTable
        Try
            Return DALtbl_hist_mant_vehiculos.getAll(pConnection, ptbl_hist_mant_vehiculos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  19/07/2016 18:02:10
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) as tbl_hist_mant_vehiculos_Entity
        Try
            Return DALtbl_hist_mant_vehiculos.getSingle(pConnection, ptbl_hist_mant_vehiculos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

