<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCalificacion.aspx.cs" Inherits="PROSEGUR.UI.RegistroCalificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:90%;">
        <tr>
            <td colspan="1">
                E-mail:
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" Width="300px"></asp:TextBox>        
            </td>
        </tr>
        <tr>
            <td colspan="1">
                Nombres: 
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtNombres" runat="server" MaxLength="100" Width="500px"></asp:TextBox>        
            </td>
        </tr>
        <tr>
            <td colspan="1">
                Calificación:
            </td>
            <td colspan="3">
                <asp:RadioButtonList ID="rdbCalificacion" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="1" Value="1" />
                    <asp:ListItem Text="2" Value="2" />
                    <asp:ListItem Text="3" Value="3" />
                    <asp:ListItem Text="4" Value="4" />
                    <asp:ListItem Text="5" Value="5" />
                    <asp:ListItem Text="6" Value="6" />
                    <asp:ListItem Text="7" Value="7" />
                    <asp:ListItem Text="8" Value="8" />
                    <asp:ListItem Text="9" Value="9" />
                    <asp:ListItem Text="10" Value="10" />
                </asp:RadioButtonList>                
            </td>
        </tr>
        <tr>     
            <td colspan="4"> 
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
                <asp:Button ID="btnCalificar" runat="server" Text="Calificar" OnClick="btnCalificar_Click" style="height: 26px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRegresar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnMenuPrincipal" runat="server" OnClick="btnMenuPrincipal_Click" Text="&lt;&lt; Menú Principal" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
