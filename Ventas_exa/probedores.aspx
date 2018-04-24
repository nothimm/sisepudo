<%@ Page Language="VB" AutoEventWireup="false" CodeFile="probedores.aspx.vb" Inherits="probedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap-reboot.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" role="form">
        <div class="form-control"><h1> Proveedores</h1></div>
        <div class="form-control"><asp:Label ID="lbl_rut" runat="server" Text="Rut"></asp:Label>&nbsp; <asp:TextBox ID="txt_rut" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="nombre" runat="server" Text="nombre"></asp:Label> &nbsp;<asp:TextBox ID="txt_nom" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="Label6" runat="server" Text="web"></asp:Label> &nbsp;<asp:TextBox ID="txt_web" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="Label" runat="server" Text="telefono"></asp:Label> &nbsp;<asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="telefono" runat="server" Text="descriccion del telefono"></asp:Label> &nbsp;<asp:TextBox ID="txt_des" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="Label2" runat="server" Text="calle"></asp:Label>&nbsp; <asp:TextBox ID="txt_calle" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="Label3" runat="server" Text="numero de calle"></asp:Label> &nbsp; <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox> </div>
        <div class="form-control"><asp:Label ID="Label4" runat="server" Text="comuidad"></asp:Label> &nbsp; <asp:TextBox ID="txt_comunidad" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Label ID="Label5" runat="server" Text="ciudad"></asp:Label> &nbsp; <asp:TextBox ID="txt_ciudad" runat="server"></asp:TextBox></div>
        <div class="form-control"><asp:Button ID="btn_insertar_cliente" runat="server" Text="Insertar" /> <asp:Button ID="btn_actualizar" runat="server" Text="actulizar" /> <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" /> 
        <asp:Button ID="btn_consultar" runat="server" Text="Consultar" /> <asp:Button ID="btn_telefonos" runat="server" Text="Mas telefonos" /></div>
        <div class="form-control">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

        </div>
        <div class="form-control">
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="153px" Width="2023px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
