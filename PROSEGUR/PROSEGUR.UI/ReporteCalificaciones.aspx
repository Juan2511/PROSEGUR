<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteCalificaciones.aspx.cs" Inherits="PROSEGUR.UI.ReporteCalificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:90%;">
        <tr style="text-align:center;">
            <td colspan="4">
                <h2>Reporte de calificaciones hasta la fecha</h2>
            </td>
        </tr>
        <tr>     
            <td colspan="4"> 
            </td>
        </tr>
        <%--<tr>
            <td colspan="1" class="auto-style1">
                E-mail cliente:
            </td>
            <td colspan="3" class="auto-style1">
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" Width="300px"></asp:TextBox>        
            </td>
        </tr>
        <tr>
            <td colspan="1">
                Nombre cliente: </td>
            <td colspan="3">
                <asp:TextBox ID="txtNombres" runat="server" MaxLength="100" Width="500px"></asp:TextBox>        
            </td>
        </tr>
        <tr>
            <td colspan="1">
                &nbsp;</td>
            <td colspan="3">
                &nbsp;</td>
        </tr>--%>
        <tr>     
            <td colspan="4"> 
                <asp:GridView ID="dgvCalificaciones" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>     
            <td colspan="4"> 
                <asp:label id="lblMensaje" runat="server"></asp:label>  
            </td>
        </tr>
        <tr>     
            <td colspan="4"> 
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <%--<asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" style="height: 26px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />   --%>  
                <asp:Button ID="btnMenuPrincipal" runat="server" Text="<< Menú Principal" OnClick="btnMenuPrincipal_Click" />      
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
