<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SistemaNotas._Index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
            .frmLogin {

                position:fixed;
    top: 50%;
    left: 50%;
    width:30em;
    height:18em;
    margin-top: -15em;
    margin-left: -15em;
    border: 1px solid #ccc;
    background-color: #f3f3f3;
            }
        </style>
        <div class="row frmLogin">
        <div class="col-md-12">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Utilice una cuenta para iniciar sesión.</h4>
                    <hr />
                  
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtUsuario" CssClass="col-md-3 control-label">Usuario</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" TextMode="SingleLine" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtContrasena" CssClass="col-md-3 control-label">Contraseña</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="txtContrasena" TextMode="Password" CssClass="form-control" />
                        
                        </div>
                    </div>
                   
                    <div class="form-group">
                        <div class="col-md-offset-8 col-md-2">
                            <asp:Button runat="server" OnClick="LogIn" Text="Iniciar sesión" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                <p>
                    <asp:LinkButton runat="server" ID="btnRegistrarNuevo" OnClick="btnRegistrarNuevo_Click" >Registrarse como usuario nuevo</asp:LinkButton>
                </p>
                <p>

                </p>
            </section>
        </div>


    </div>
 
    
</asp:Content>
