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

    Public Shared Function GetAll_ordenes_empresa_estado_inv(ByVal pConnection As Connection_Entity, ByVal id_empresa As Integer, ByVal id_estado As Integer, ByVal id_tipo As Integer) As DataTable
        Try
            Return DALGeneral.GetAll_ordenes_empresa_estado_inv(pConnection, id_empresa, id_estado, id_tipo)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    Public Shared Function crear_orden_compra_auto(ByVal pConnection As Connection_Entity, ByVal id_orden As Integer) As Boolean
        Try
            Return DALGeneral.crear_orden_compra_auto(pConnection, id_orden)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    Public Shared Function autoriza_orden_entrega(ByVal pConnection As Connection_Entity, ByVal id_orden As Integer) As Boolean
        Try
            Return DALGeneral.autoriza_orden_entrega(pConnection, id_orden)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    Public Shared Function transportar_orden_entrega(ByVal pConnection As Connection_Entity, ByVal id_orden As Integer) As Boolean
        Try
            Return DALGeneral.transportar_orden_entrega(pConnection, id_orden)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function




    '/***************************************************************
    'NOMBRE:Getallrutas
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: Obtiene todas las rutas
    'DETALLE: Obtiene todas las rutas 
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function GetAllrutas(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta As tbl_scm_ruta_Entity) As DataTable
        Try
            Return DALGeneral.GetAllrutas(pConnection, ptbl_scm_ruta)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    '/***************************************************************
    'NOMBRE:Getdetallerutas
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: Obtiene todas las rutas
    'DETALLE: Obtiene todas las rutas 
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function GetAlldetallerutas(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta As tbl_scm_detalle_ruta_Entity) As DataTable
        Try
            Return DALGeneral.GetAlldetallerutas(pConnection, ptbl_scm_detalle_ruta)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function


    '/***************************************************************
    'NOMBRE:modifcar_estados_ord
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: Modifica el estado de la orden de aprobada, en ruta y entregada
    'DETALLE: Realiza un update de la tabla ordenes entrega
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function modificar_estados_ord(ByVal pConnection As Connection_Entity, ByVal ids As String, ByVal estado As Integer) As Boolean
        Try
            Return DALGeneral.modificar_estados_ord(pConnection, ids, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    '/***************************************************************
    'NOMBRE:modifcar_estados_ordmod
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: Modifica el estado de la orden de aprobada, en ruta y entregada
    'DETALLE: Realiza un update de la tabla ordenes entrega con el cambio de que recibe un id
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function modificar_estados_ordmod(ByVal pConnection As Connection_Entity, ByVal ids As String, ByVal estado As Integer) As Boolean
        Try
            Return DALGeneral.modificar_estados_ordmod(pConnection, ids, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    '/***************************************************************
    'NOMBRE:get_ordenes_ent
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: obtiene todas las ordenes de entrega disponibles
    'DETALLE: Realiza un update de la tabla ordenes entrega
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function get_ordenes_ent(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega As tbl_scm_ordenes_entrega_Entity) As DataTable
        Try
            Return DALGeneral.get_ordenes_ent(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    '/***************************************************************
    'NOMBRE:get_orden_mod
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: obtiene todas las ordenes de entrega disponibles
    'DETALLE: Se obtiene todas las ordenes bajo un dato determinado
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function get_orden_mod(ByVal pConnection As Connection_Entity, ByVal pc_detalle_ordenes_entrega As tbl_scm_ordenes_entrega_Entity) As DataTable
        Try
            Return DALGeneral.get_orden_mod(pConnection, pc_detalle_ordenes_entrega)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    '/***************************************************************
    'NOMBRE:get_vehiculosf
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: obtiene la informacion necesaria de los vehiculos de la empresa
    'DETALLE: Obtiene los vehiculos de la empresa
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function get_vehciulosf(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos As tbl_scm_vehiculos_Entity) As DataTable
        Try
            Return DALGeneral.get_vehiculosf(pConnection, ptbl_scm_vehiculos)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    '/***************************************************************
    'NOMBRE:GetAllgetalldetor
    'FECHA: 15/07/2016
    'CREADOR: Walter Ivan Quijada Folgar
    'DESCRIPCIÓN: obtiene todas el detalle de las ordenes de entrega
    'DETALLE: Obtiene todo el detalle de una orden de entrega
    'MODIFICACIÓN: 20/07/2016
    '***************************************************************/
    Public Shared Function getalldetor(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes As tbl_scm_detalle_ordenes_Entity) As DataTable
        Try
            Return DALGeneral.GetAllgetalldetor(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

