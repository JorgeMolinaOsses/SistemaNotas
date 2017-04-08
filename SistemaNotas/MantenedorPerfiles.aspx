<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMantenedor.Master" CodeBehind="MantenedorPerfiles.aspx.cs" Inherits="SistemaNotas.MantenedorPerfiles" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentMantenedor" runat="server">
    <br />
    <div class="row">
        <h2>Lista de Usuarios Registrados</h2>
    </div>
    <br />
     <div class="row">
         <div class ="table">
             <table>
                   <thead>
                       <tr>
                             <td>Nombre</td>
                             <td>Apellido</td>
                             <td></td>
                             <td></td>
                             <td></td>
                             <td></td>
                         </tr>

                   </thead>
                 <tbody id="tbody">
                     <% Response.Write(datosTable()); %>
                 </tbody>
             </table>
           
         </div>   
     </div>
    <script>


    </script>
</asp:Content>
