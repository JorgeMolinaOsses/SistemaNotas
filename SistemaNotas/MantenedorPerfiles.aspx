<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMantenedor.Master" CodeBehind="MantenedorPerfiles.aspx.cs" Inherits="SistemaNotas.MantenedorPerfiles" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentMantenedor" runat="server">
   <br />
    <div class="row">
        <h2>Lista de Usuarios Registrados</h2>
    </div>
    <br />
     <div class="row">
         <table class="table">
             <thead>
                 <tr>
                     <td>Rut</td>
                     <td>Nombre</td>
                     <td>Apellido</td>
                     <td>Dirección</td>
                     <td>Fono</td>
                     <td>ROL</td>
                 </tr>
             </thead>
             <tbody>
                 <tr>
                      <td>17061661-8</td>
                      <td>Jorge</td>
                      <td>Molina</td>
                      <td>xxxxxxxx</td>
                      <td>Apoderado</td>
                      <td><asp:DropDownList CssClass="form-control" runat="server" ID="slcRol">
                            <asp:ListItem  Value="Ninguno">Ninguno</asp:ListItem>
                          <asp:ListItem  Value="Apoderado">Apoderado</asp:ListItem>
                           <asp:ListItem Value="Profesor">Profesor</asp:ListItem>
                          </asp:DropDownList></td>
                 </tr>

             </tbody>
         </table>
     </div>
    
</asp:Content>
