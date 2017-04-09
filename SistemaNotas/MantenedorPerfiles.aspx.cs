using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaNotas
{
    public partial class MantenedorPerfiles : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlumnos_Click(object sender, EventArgs e)
        {

        }
        public string datosTable()
        {
            string response = "";
            SqlDataReader reader; 
            using (SqlConnection conn = new SqlConnection(ConfigurationManager
          .ConnectionStrings["SistemaNotasConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"Select * From [Usuarios]";
                    try
                    {
                        conn.Open();
                        reader =  cmd.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {

                            response += "<tr>"+"<td>"+reader["Rut"]+"</td>"+
                                "<td>" + reader["Nombre"] + "</td>" +
                                "<td>" + reader["Apellido"] + "</td>" +
                                "<td>" + reader["Sexo"] + "</td>" +
                                "<td>" +
                                "<asp:DropDownList runat='server' ID ='slcRol" +count+"' CssClass='form-control'>"+
                                "<asp:ListItem Value='Apoderado'>Apoderado</asp:ListItem>" +
                                 "<asp:ListItem Value='Administrador'>Administrador</asp:ListItem>" +
                                  "<asp:ListItem Value='Docente'>Apoderado</asp:ListItem>" +
                                "</asp:DropDownList >" +"<td>"+
                                "<tr>" ;

                            count++;
                        }
                        return response;
                    }
                    catch (SqlException ex)
                    {
                      
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }
                    return response;
                }

            }
        }

    }
}