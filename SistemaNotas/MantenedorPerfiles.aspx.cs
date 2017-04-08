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
        public void datosTable()
        {
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
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["Nombre"].ToString());
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }
                }

            }
        }

    }
}