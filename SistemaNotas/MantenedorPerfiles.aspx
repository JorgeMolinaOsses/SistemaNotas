<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMantenedor.Master" CodeBehind="MantenedorPerfiles.aspx.cs" Inherits="SistemaNotas.MantenedorPerfiles" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentMantenedor" runat="server">
    <br />
    <div class="row">
        <h2>Lista de Usuarios Registrados</h2>
    </div>
    <br />
     <div class="row">
         <div class="col-md-12">
             <table  class="table">
                   <thead>
                       <tr>
                            <td>Rut</td>
                             <td>Nombre</td>
                             <td>Apellido</td>
                             <td>Sexo</td>
                             <td>Rol</td>
                         </tr>
                      
                   </thead>
                 <tbody runat="server" id="tbody">
                     <%  Response.Write(getTable());    %>
                 </tbody>
             </table>
           
         </div>   
     </div>
    <script>
        $(document).ready(function () {

            $("select").change(function () {

                var numerofila = $(this).attr("data-numero");
                var rut = $(".fila" + numerofila + " #td1").text();
             $.ajax({
                    type: "POST",
                    url: "WebService.asmx/Rol",
                    async: false,
                    data: {
                        "Value": $(this).val(),
                        "Rut": rut
                    },
                    contentType: "application/x-www-form-urlencoded",
                    success: function (data) {
                        alert(data);
                    }
               });
               
            })
        });

    </script>
</asp:Content>
