<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex justify-content-center">
            <div class="p-2"><a role="menuitem" tabindex="-1" href="probedores.aspx">proveedores</a></div>
            <div class="p-2"><a role="menuitem" tabindex="-1" href="clientes.aspx">clientes</a></div>
            <div class="p-2"><a role="menuitem" tabindex="-1" href="productos.aspx">productos</a></div>
            <div class="p-2"><a role="menuitem" tabindex="-1" href="facturas.aspx">probedores</a></div>
        </div>
    
        <div class="dropdown">
  <button class="btn dropdown-toggle sr-only" type="button"
          id="dropdownMenu1" data-toggle="dropdown">
    Menú desplegable
    <span class="caret"></span>
  </button>
 
  <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu1">
                 <li role="presentation"><a role="menuitem" tabindex="-1" href="probedores.aspx">probedores</a></li>
                 <li role="presentation"><a role="menuitem" tabindex="-1" href="clientes.apsx">clientes</a></li>
                 <li role="presentation"><a role="menuitem" tabindex="-1" href="productos.apsx">productos</a></li>
                 <li role="presentation"><a role="menuitem" tabindex="-1" href="facturas.apsx">facturas</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
