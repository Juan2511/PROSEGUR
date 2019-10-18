<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PROSEGUR.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    <h1>PROSEGUR</h1>
    </div>
    <br />
        <br />
    <div>
        <asp:HyperLink ID="linkRegistroCalificaciones" runat="server" NavigateUrl="~/RegistroCalificacion.aspx">
		    Registro Calificaciones
        </asp:HyperLink>
        <br />
        <br />
        
        <asp:HyperLink ID="linkReporteCalificaciones" runat="server" NavigateUrl="~/ReporteCalificaciones.aspx">
		    Reporte Calificaciones
        </asp:HyperLink>
    </div>
    </form>
</body>
</html>