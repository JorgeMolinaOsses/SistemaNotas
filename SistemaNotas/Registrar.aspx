<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="SistemaNotas.Registrar" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
            .frmRegistro {

                position:fixed;
    top: 50%;
    left: 50%;
    width:30em;
    height:26em;
    margin-top: -15em;
    margin-left: -15em;
    border: 1px solid #ccc;
    background-color: #f3f3f3;
            }
   .frmRegistro section {
       margin-left:5%;
     margin-top:5%;
     }
        </style>
        <div class="row frmRegistro">
        <div class="col-md-12">
                 <h4>Registro de Usuarios.</h4>
            <section>
               <div class="row">
                   <div class="col-md-3"> <label>Rut</label></div>
                    <div class="col-md-9"> <asp:TextBox runat="server" ID="txtRut" CssClass="form-control"></asp:TextBox></div>
                 
               </div>
                <br />
                  <div class="row">
                        <div class="col-md-3"> <label>Nombre</label></div>
                         <div class="col-md-9"><asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox></div>
                  </div>
                 <br />
                  <div class="row">
                        <div class="col-md-3"> <label>Apellido</label></div>
                         <div class="col-md-9"><asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox></div>
                  </div>
                 <br />
                 <div class="row">
                        <div class="col-md-3"> <label>Sexo</label></div>
                         <div class="col-md-9"><asp:DropDownList runat="server" ID="txtSexo" CssClass="form-control">
                                                <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                              <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                                               </asp:DropDownList></div>
                  </div>
                 <br />
                   <div class="row">
                        <div class="col-md-3" > <a href="#">Usuario</a></div>
                         <div class="col-md-9"><asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control"></asp:TextBox></div>
                  </div>
                 <br />
                  <div class="row">
                        <div class="col-md-3"> <a style="text-align:start" href="#">Contraseña</a></div>
                         <div class="col-md-9"><asp:TextBox runat="server" ID="txtContrasena" CssClass="form-control"></asp:TextBox></div>
                  </div>
            </section>
        </div>
        <br />
            <div class="row">
                <asp:LinkButton ID="btnRegistro"  runat="server" CssClass="btn btn-primary col-md-offset-5" OnClick="btnRegistro_Click">Registrarse</asp:LinkButton>
            </div>

    </div>
 
    
</asp:Content>