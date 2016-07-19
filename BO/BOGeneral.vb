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

    Public Shared Function GetBodega(ByVal pConnection As Connection_Entity, ByVal id_producto As Integer) As DataTable
        Try
            Return DALGeneral.GetBodega(pConnection, id_producto)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function



    Public Shared Function get_detalle_orden(ByVal pConnection As Connection_Entity, ByVal pc_detalle_orden As tbl_ordenes_detalle_Entity) As DataTable
        Try
            Return DALGeneral.get_detalle_orden(pConnection, pc_detalle_orden)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    Public Shared Function get_productos(ByVal pConnection As Connection_Entity) As DataTable
        Try
            Return DALGeneral.get_productos(pConnection)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    Public Shared Function GetAll_ordenes_empresa_estado(ByVal pConnection As Connection_Entity, ByVal id_empresa As Integer, ByVal id_estado As Integer, ByVal id_tipo As Integer) As DataTable
        Try
            Return DALGeneral.GetAll_ordenes_empresa_estado(pConnection, id_empresa, id_estado, id_tipo)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    Public Shared Function modificar_estados_lote(ByVal pConnection As Connection_Entity, ByVal ids As String, ByVal estado As Integer) As Boolean
        Try
            Return DALGeneral.modificar_estados_lote(pConnection, ids, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    Public Shared Function get_detalle_producto(ByVal pConnection As Connection_Entity, ByVal pc_inventario As tbl_inventario_Entity) As DataTable
        Try
            Return DALGeneral.get_detalle_producto(pConnection, pc_inventario)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
End Class

