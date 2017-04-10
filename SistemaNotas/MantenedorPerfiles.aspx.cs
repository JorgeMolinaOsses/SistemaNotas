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

                            response += "<tr class='fila"+count+"'>"+ "<td id= 'td1'>" + reader["Rut"]+"</td>"+
                                "<td id= 'td2'>" + reader["Nombre"] + "</td>" +
                                "<td id= 'td3'>" + reader["Apellido"] + "</td>" +
                                "<td id= 'td4'>" + reader["Sexo"] + "</td>" +
                                "<td id= 'td5'>" +
                                "<select id ='slcRol" +count+"' data-numero='"+count+"' class='form-control'>"+
                                "<option value='Apoderado'>Apoderado</option>" +
                                "<option value='Administrador'>Administrador</option>" +
                                "<option value='Docente'>Docente</option>" +
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