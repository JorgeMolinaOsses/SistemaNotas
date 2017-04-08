<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMantenedor.Master" CodeBehind="MantenedorProfesores.aspx.cs" Inherits="SistemaNotas.MantenedorProfesores" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentMantenedor" runat="server">

     <br />
    <div class="row">
        <div class="row">       
        <div class="col-md-5">
            <label for="txtRut">Rut</label>
                <div class=" form-inline">
                    <asp:TextBox  Id="txtRut" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:LinkButton runat="server" ID="btnBuscar" CssClass="btn btn-default"><i class="glyphicon glyphicon-search"></i></asp:LinkButton></div>
             <label for="txtNombre">Nombre</label> <asp:TextBox  Id="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
             <label for="txtApellido">Apellido</label> <asp:TextBox  Id="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
            <div class="col-md-5">
            <label for="txtDireccion">Dirección</label> <asp:TextBox  Id="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
              <label for="txtSexo">Sexo</label>
                 <asp:DropDownList Width="50%" Id="slcSexo" runat="server" CssClass="form-control">
                  <asp:ListItem Value="M">Masculino</asp:ListItem>
                   <asp:ListItem Value="F">Femenino</asp:ListItem>
                      </asp:DropDownList>
              <label for="txtTelefono">Telefono</label> <asp:TextBox  Id="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
     <div class="col-md-2">
         <div class="row">  <img width="200" height="200" src="img/alumnos.png"/></div>

     </div>
            <br/>
        </div>
        <br />
        <div class="row form-inline">
            <div class="col-md-offset-5">
                  <asp:LinkButton runat="server" CssClass="btn btn-primary" ID="btnGuardar"><i class="glyphicon glyphicon-floppy-disk"></i>Guardar</asp:LinkButton>
            <asp:LinkButton runat="server" CssClass="btn btn-default" ID="btnModificar"><i class="glyphicon glyphicon-pencil"></i>Modificar</asp:LinkButton>
            <asp:LinkButton runat="server" CssClass="btn btn-danger" ID="btnElimar"><i class="glyphicon glyphicon-trash"></i>Eliminar</asp:LinkButton>
            </div>
          
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-md-12">
                <table class="table">
                    <thead>
                    <tr>
                        <td>Rut</td>
                         <td>Nombre</td>
                         <td>Apellido</td>
                         <td>Dirección</td>
                         <td>Sexo</td>
                         <td>Telefono</td>
                         <td>Alumnos Asociados</td>
                    </tr>
                    </thead>
                    <tbody>
                        <tr>
                    <td>sad</td>
                    <td>sad</td>
                              <td>sad</td>
                    <td>sad</td>
                              <td>sad</td>
                    <td>sad</td>
                     <td><asp:LinkButton runat="server" ID="btnAlumnos"  data-toggle="modal" data-target="#myModal" OnClick="btnAlumnos_Click" >Ver Lista de Alumnos</asp:LinkButton></td>
                     </tr>
                 
                    
                    </tbody>
                
                </table>
               <!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Lista de Alumnos</h4>
      </div>
      <div class="modal-body">
       <table class="table">
           <thead>
               <tr>
                   <td></td>
               </tr>
           </thead>
           <tbody></tbody>
       </table>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>
               
            </div>

        </div>
    </div>
  
    
</asp:Content>
