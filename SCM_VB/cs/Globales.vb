Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Imports Entity

Imports System
Imports System.Collections
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Globalization

Public Class Globales
    Public Shared Function Encripta(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Clave = "%ü&/@#$A"
        Pass2 = ""
        For i = 1 To Len(Pass)
            CAR = Mid(Pass, i, 1)
            Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Encripta = Pass2
    End Function


    Public Shared Function DesEncripta(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Dim j As Integer

        Clave = "%ü&/@#$A"
        Pass2 = ""
        j = 1
        For i = 1 To Len(Pass) Step 2
            CAR = Mid(Pass, i, 2)
            Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        DesEncripta = Pass2
    End Function

    Public Shared Function ObtenerID(ByVal longitud_Clave As Integer) As String
        Randomize()
        Dim i As Byte
        Dim tipoCaracter As Integer
        Dim j As Integer
        Dim h As Integer
        Dim resultado As String
        Dim Numeros(10) As String
        Dim Mayusculas(25) As String
        Dim Minusculas(25) As String
        Dim generacionPSS() As String
        ReDim generacionPSS(longitud_Clave)
        j = 0
        For i = 48 To 57
            Numeros(j) = Chr(i)
            j = j + 1
        Next i
        j = 0
        For i = 65 To 90
            Mayusculas(j) = Chr(i)
            j = j + 1
        Next i
        j = 0
        For i = 97 To 122
            Minusculas(j) = Chr(i)
            j = j + 1
        Next i
        For h = 0 To longitud_Clave - 1
            'aleatorio para saber si concateno numero, mayuscula o minuscula
            tipoCaracter = Int((3 * Rnd()))
            Select Case tipoCaracter
                'numero
                Case 0
                    generacionPSS(h) = Numeros(Int((UBound(Numeros) * Rnd())))
                    'minuscula
                Case 1
                    generacionPSS(h) = Minusculas(Int((UBound(Minusculas) * Rnd())))
                    'mayuscula
                Case 2
                    generacionPSS(h) = Mayusculas(Int((UBound(Mayusculas) * Rnd())))
            End Select

        Next h
        resultado = ""
        'concateno resultado para devolver solo un string y asi olvidarse de los vectores
        For j = 0 To longitud_Clave - 1
            resultado = resultado & generacionPSS(j)
        Next j
        ObtenerID = resultado
    End Function


    Public Shared Function ObtenerCampo(ByVal pConnection As Entity.Connection_Entity, ByVal iTabla As String, ByVal iCampo As String, ByVal iWhere As String) As Object

        Try

            Dim iConnection As New OleDbConnection
            iConnection.ConnectionString = "Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";"
            Dim sSQL As String
            sSQL = "SELECT " & iCampo & " FROM " & iTabla & " " & iWhere
            Dim iCommand As New OleDbCommand(sSQL, iConnection)
            Dim iResultado As String
            iConnection.Open()
            iResultado = iCommand.ExecuteScalar()
            iConnection.Close()
            If Len(Trim(iResultado)) <> 0 Then
                ObtenerCampo = NoNull(iResultado)
            Else
                ObtenerCampo = ""
            End If

        Catch ex As Exception
            ObtenerCampo = ex.Message
            'Throw New Exception(ex.Message, ex.InnerException)
        End Try

    End Function

    Public Shared Function GetServerDate(ByVal pConnection As Entity.Connection_Entity) As Date
        Try
            Dim iConnection As New OleDbConnection
            iConnection.ConnectionString = "Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";"
            Dim sSQL As String
            sSQL = "select getdate() as FechaServer"
            Dim iCommand As New OleDbCommand(sSQL, iConnection)
            Dim iResultado As Date
            iConnection.Open()
            iResultado = iCommand.ExecuteScalar()
            iConnection.Close()
            Return iResultado
        Catch
            MsgBox(Err.Number & "-" & Err.Description, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error del sistema...")
            Return Now
        End Try
    End Function

    Public Shared Function GetDataTable(ByVal pConnection As Entity.Connection_Entity, ByVal iQuery As String, ByVal DataTableName As String) As DataTable
        Try
            Dim iAdapter As New OleDbDataAdapter(iQuery, "Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")
            Dim iDataTable As DataTable = New DataTable(DataTableName)
            iAdapter.Fill(iDataTable)
            Return (iDataTable)
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Function GetSegment(ByVal i_String As String, ByVal i_Segment As Long, ByVal i_Separator As String) As String
        Dim i_Contador As Long
        Dim i_SegmentFound As Long
        Dim i_Portion As String
        GetSegment = ""
        If Trim(i_String) = System.String.Empty Then
            GetSegment = System.String.Empty
            Exit Function
        End If

        i_String = Trim(i_String) & i_Separator

        i_SegmentFound = 0
        i_Portion = System.String.Empty

        For i_Contador = 1 To Len(i_String)
            If Mid(i_String, i_Contador, 1) = i_Separator Then
                i_SegmentFound = i_SegmentFound + 1
                If i_SegmentFound = i_Segment Then
                    GetSegment = Trim(i_Portion)
                    Exit Function
                Else
                    i_Portion = System.String.Empty
                End If
            Else
                i_Portion = i_Portion & Mid(i_String, i_Contador, 1)
            End If
        Next
    End Function

    Public Shared Function NoNull(ByVal iValor As Object) As String
        If iValor Is System.DBNull.Value Then
            Return ""
        Else
            Return iValor
        End If
    End Function

    Public Shared Function EjecutarQuery(ByVal pConnection As Connection_Entity, ByVal pQuery As String) As Boolean
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")
            Dim iCommand As New OleDbCommand(pQuery, iConnection)
            iConnection.Open()
            iCommand.Connection = iConnection
            Try
                iCommand.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try
        End Using
    End Function


    Public Shared Function EnviaEmailNotificacion(ByVal mailDestino As String, ByVal asunto As String, ByVal iMensaje As String) As Boolean
        Try

            Dim lCuentaMail As String = System.Configuration.ConfigurationManager.AppSettings("mail_adress").ToString
            Dim lPass As String = System.Configuration.ConfigurationManager.AppSettings("mail_pwd").ToString
            Dim lSmtp As String = System.Configuration.ConfigurationManager.AppSettings("smtp").ToString
            Dim lPort As String = System.Configuration.ConfigurationManager.AppSettings("port").ToString
            Dim lSsl As Boolean = System.Configuration.ConfigurationManager.AppSettings("ssl")

            'Globales.SendMail(New Entity.stf_send_mail With {.MailAdress = lCuentaMail, .MailPwd = lPass, .Port = lPort, .Smtp = lSmtp, .Ssl = lSsl}, mailDestino, asunto, iMensaje)
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function


    'FECHA INPUT
    Public Shared Function getDateTimeInputHTML(ByVal inputasp As TextBox) As DateTime
        Return IIf(IsDate(inputasp.Text), DateTime.ParseExact((IIf(inputasp.Text = "", "1900-08-20", inputasp.Text)), "yyyy-MM-dd", CultureInfo.InvariantCulture), DateTime.ParseExact("1900-08-20", "yyyy-MM-dd", CultureInfo.InvariantCulture))
    End Function

    'FECHA INPUT
    Public Shared Function setDateTimeInputHTML(ByVal string_data As Date) As String
        Return IIf(string_data = "#1900-8-20#", "", string_data.ToString("yyyy-MM-dd"))
    End Function

    'CONVERT DATATABLE TO SEELECT
    Public Shared Function DatatabletoSELECT(ByVal dt_tmp As DataTable) As String
        Dim st_tmp As String = ""
        For J As Integer = 0 To dt_tmp.Rows.Count - 1
            st_tmp = st_tmp + "SELECT "
            For K As Integer = 0 To dt_tmp.Columns.Count - 1
                st_tmp = st_tmp + " '" + dt_tmp.Rows(J).Item(K).ToString() + "' as [" + dt_tmp.Columns(K).Caption + "]"
                If K = dt_tmp.Columns.Count - 1 Then
                    st_tmp = st_tmp + ""
                Else
                    st_tmp = st_tmp + ","
                End If
            Next
            If J = dt_tmp.Rows.Count - 1 Then
                st_tmp = st_tmp + ""
            Else
                st_tmp = st_tmp + " UNION "
            End If
        Next
        Return st_tmp
    End Function

    'DIFERENCE DATATABLE
    Public Shared Function getDiference(ByVal data_tmp1 As DataTable, ByVal data_tmp2 As DataTable) As DataTable
        Dim dt_tmp As New DataTable
        dt_tmp.Columns.Add("numverifica", Type.GetType("System.Int32"))
        dt_tmp.Columns.Add("correlativo", Type.GetType("System.Int32"))
        dt_tmp.Columns.Add("num_pregunta", Type.GetType("System.Int32"))
        dt_tmp.Columns.Add("respuesta", Type.GetType("System.Int32"))
        dt_tmp.Columns.Add("observaciones", Type.GetType("System.String"))
        dt_tmp.Columns.Add("id_detalle_verificacion", Type.GetType("System.Int32"))
        dt_tmp.Columns(0).AutoIncrement = True
        '1 ANTIGUA
        '2 NUEVA
        If (data_tmp1.Rows.Count = data_tmp2.Rows.Count) Then
            For J As Integer = 0 To data_tmp2.Rows.Count - 1
                If (data_tmp1.Rows(J).Item(3).ToString() <> data_tmp2.Rows(J).Item(3).ToString()) Or (data_tmp1.Rows(J).Item(4).ToString() <> data_tmp2.Rows(J).Item(4).ToString()) Then
                    dt_tmp.Rows.Add(data_tmp2.Rows(J).Item(0), data_tmp2.Rows(J).Item(1), data_tmp2.Rows(J).Item(2), data_tmp2.Rows(J).Item(3), data_tmp2.Rows(J).Item(4), data_tmp2.Rows(J).Item(5))
                End If
            Next
        End If
        Return dt_tmp
    End Function

    'SEGURIDAD
    Public Shared Function getAccessbtns(ByVal acceso_estado As String) As String
        getAccessbtns = "none"

        Select Case acceso_estado
            Case "0"
                getAccessbtns = "none"
            Case "1"
                getAccessbtns = "block"
            Case "2"
                getAccessbtns = "none"

            Case Else
        End Select

        'getAccessbtns = "block"

        Return getAccessbtns

    End Function


    Public Shared Function nullint(ByVal st As String) As Integer
        If (st = "") Then
            nullint = 0
        Else
            nullint = Val(st)
        End If
        Return nullint
    End Function


    Public Shared Function intnull(ByVal st As Integer) As String
        If (st = 0) Then
            intnull = ""
        Else
            intnull = st.ToString()
        End If
        Return intnull
    End Function



    Public Shared Function Converttomonths(ByVal year As Integer, ByVal month As Integer) As Integer
        Converttomonths = (year * 12) + month
        Return Converttomonths
    End Function



    Public Shared Function respuesta_rd(ByVal rds As Boolean, ByVal rdn As Boolean) As Integer
        If rds = False And rdn = False Then
            Return 2
        Else
            If rds = True Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function

    Public Shared Function respuesta_rd_b(ByVal rds As Boolean, ByVal rdn As Boolean) As Integer
        If rds = False And rdn = False Then
            Return -1
        Else
            If rds = True Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function

    Public Shared Function accion_estatus(ByVal id_estado_verificacion As String, ByVal numverifica As String) As String
        accion_estatus = ""

         Select id_estado_verificacion
            Case "1" 'PENDIENTES
                accion_estatus = "asignar_verificacion();"
            Case "2" 'EN PROCESO
                accion_estatus = "asignar_verificacion();"
            Case "3" 'COMPARTIDAS
                accion_estatus = "asignar_verificacion();"
            Case "4" 'FINALIZADAS
                accion_estatus = "modal_auto();"
            Case "5" 'AUTORIZADAS
                accion_estatus = ""
        End Select


        Return accion_estatus
    End Function



End Class
