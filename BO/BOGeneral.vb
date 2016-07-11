Imports DAL
Imports Entity

Public Class BOGeneral


    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAllUsuarios(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity) As DataTable
        Try
            Return DALGeneral.GetAllUsuarios(pConnection, ptbl_scm_usuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    Public Shared Function GetAllGestores(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_gestores As tbl_gestor_ordenes_Entity) As DataTable
        Try
            Return DALGeneral.GetAllGestores(pConnection, ptbl_scm_gestores)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

