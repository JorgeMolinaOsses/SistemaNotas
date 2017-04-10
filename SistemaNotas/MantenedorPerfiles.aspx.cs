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
        public string getTable()
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
                            var defaultRol = reader["Rol"].ToString();
                            var slcOptions = "";
                            if (defaultRol == "")
                            {
                                slcOptions = "<option selected='selected' value='' >Aun Sin Asignar</option>" +
                                        "<option value='1'>Apoderado</option>" +
                                             "<option value='2'>Administrador</option>" +
                                              "<option value='3'>Docente</option>";
                            }
                            else if (defaultRol == "1") {
                                slcOptions = "<option value='' >Aun Sin Asignar</option>" +
                                        "<option selected='selected' value='1'>Apoderado</option>" +
                                             "<option value='2'>Administrador</option>" +
                                              "<option value='3'>Docente</option>";

                            }
                            else if (defaultRol == "2") {
                                slcOptions = "<option value='' >Aun Sin Asignar</option>" +
                                        "<option value='1'>Apoderado</option>" +
                                             "<option selected='selected' value='2'>Administrador</option>" +
                                              "<option value='3'>Docente</option>";
                            }
                            else if (defaultRol == "3") {
                                slcOptions = "<option value='' >Aun Sin Asignar</option>" +
                                        "<option value='1'>Apoderado</option>" +
                                             "<option value='2'>Administrador</option>" +
                                              "<option selected='selected' value='3'>Docente</option>";
                            }


                            response += "<tr class='fila"+count+"'>"+ "<td id= 'td1'>" + reader["Rut"]+"</td>"+
                                "<td id= 'td2'>" + reader["Nombre"] + "</td>" +
                                "<td id= 'td3'>" + reader["Apellido"] + "</td>" +
                                "<td id= 'td4'>" + reader["Sexo"] + "</td>" +
                                "<td id= 'td5'>" +
                                
                                "<select id ='slcRol" +count+"' data-numero='"+count+"' class='form-control'>"+ slcOptions +
                                "</select>" +"<td>"+
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