Imports LayerEntity
Imports BLL
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Class RegistroClientes
    Inherits System.Web.UI.Page
    Dim MiCliente As New LayerEntity.ClsCliente
    Dim BuscarCliente As New DAL.DALCliente
    Dim ModificarCliente As New DAL.DALCliente
    Dim EliminarCliente As New DAL.DALCliente
    Protected Sub BTN_GUA_Click(sender As Object, e As EventArgs) Handles BTN_GUA.Click
        MiCliente.ID_CLIENTE = TXT_IC.Text
        MiCliente.NOMBRE_C = TXT_NC.Text
        MiCliente.SEXO = TXT_SEX.Text
        MiCliente.EDAD = TXT_EDAD.Text
        MiCliente.OBSERVACIONES = TXT_OBS.Text
        Dim bllClientes As New BllCliente
        If bllClientes.AgregarCliente(MiCliente) Then
            LBL_RESPUESTA.Text = "CLIENTE'" + TXT_NC.Text + "' AGREGADO EXITOSAMENTE"
            LIMPIAR()
        Else
            LBL_RESPUESTA.Text = "CLIENTE '" + TXT_NC.Text + "'NO SE AGREGO"
        End If

    End Sub
    Protected Sub BTN_BUS_Click(sender As Object, e As EventArgs) Handles BTN_BUS.Click
        TXT_IC.Text = TXT_IC.Text
        TXT_EDAD.Text = 0

        BuscarCliente.BuscarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEX.Text, TXT_EDAD.Text, TXT_OBS.Text)
        LBL_RESPUESTA.Text = "BUSQUEDA REALIZADA EXITOSAMENTE"
    End Sub
    Protected Sub BTN_MOD_Click(sender As Object, e As EventArgs) Handles BTN_MOD.Click
        ModificarCliente.ModificarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEX.Text, TXT_EDAD.Text, TXT_OBS.Text)
        LBL_RESPUESTA.Text = "CLIENTE MODIFICADO EXITOSAMENTE"
        LIMPIAR()
    End Sub
    Protected Sub BTN_ELI_Click(sender As Object, e As EventArgs) Handles BTN_ELI.Click


        EliminarCliente.EliminarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEX.Text, TXT_EDAD.Text, TXT_OBS.Text)
        LIMPIAR()
        LBL_RESPUESTA.Text = "ELIMINADO EXITOSAMENTE"
    End Sub

    Public Sub LIMPIAR()
        TXT_IC.Text = ""
        TXT_NC.Text = ""
        TXT_SEX.Text = ""
        TXT_EDAD.Text = ""
        TXT_OBS.Text = ""


    End Sub
    Protected Sub BTN_LIMP_Click(sender As Object, e As EventArgs) Handles BTN_LIMP.Click
        LIMPIAR()
    End Sub
End Class
