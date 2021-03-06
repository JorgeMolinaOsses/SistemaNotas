﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace SistemaNotas
{
    public partial class Registrar : System.Web.UI.Page
    {
        private string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.connectionString = ConfigurationManager
          .ConnectionStrings["connectionString"].ConnectionString;
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContrasena.Text != "" && txtRut.Text != "" && txtApellido.Text != "")
            {
 using (SqlConnection conn = new SqlConnection(ConfigurationManager
          .ConnectionStrings["SistemaNotasConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO dbo.Usuarios(Rut,Usuario,Contrasena,Nombre,Apellido,Sexo) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";

                    cmd.Parameters.AddWithValue("@param1", txtRut.Text);
                    cmd.Parameters.AddWithValue("@param2", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@param3", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@param4", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@param5", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@param6", txtSexo.SelectedValue);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario Registrado Exitosamente!!");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }
                }
            }


            }
            else {
                MessageBox.Show("campos vacios");
            }
           
        }
    }
}