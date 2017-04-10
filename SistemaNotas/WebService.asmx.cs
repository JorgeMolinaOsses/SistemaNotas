using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Windows.Forms;

namespace SistemaNotas
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "www.aiep.cl")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    public class WebService : System.Web.Services.WebService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SistemaNotasConnectionString"].ConnectionString;
        [WebMethod]
        [WebInvoke(Method = "POST")]
        [ScriptMethod(UseHttpGet = true)]
        public void Rol()
        {
          var request =  Context.Request;
            string[] tablas = { "Apoderados", "Administrador", "Docentes" };
            NameValueCollection formVariables = request.Form;
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                SqlCommand cmd3 = new SqlCommand();
                SqlCommand cmd4 = new SqlCommand();
               

                cmd1.Connection = conn;
                cmd1.CommandText = @"SELECT RutUsuario FROM " + tablas[Convert.ToInt32(formVariables.Get(0)) - 1] + " WHERE RutUsuario = " + formVariables.Get(1);

                cmd2.Connection = conn;
                cmd2.CommandText = @"DELETE FROM " + tablas[Convert.ToInt32(formVariables.Get(2)) - 1] + " WHERE RutUsuario = " + formVariables.Get(1);

                cmd3.Connection = conn;
                cmd3.CommandText = @"UPDATE dbo.Usuarios SET Rol = " + formVariables.Get(0) +
                        " WHERE Rut = "+formVariables.Get(1);
                
                cmd4.Connection = conn;
                cmd4.CommandText = @"INSERT INTO dbo."+ tablas[Convert.ToInt32(formVariables.Get(0))-1] + " (RutUsuario) VALUES(" + formVariables.Get(1)+")";

             
                try
                {
                    conn.Open();

                    reader  = cmd1.ExecuteReader();
                    try {
                        if (reader["RutUsuario"].ToString() != "")
                        {

                            cmd2.ExecuteNonQuery();
                            cmd3.ExecuteNonQuery();
                            cmd4.ExecuteNonQuery();

                        }
                        else {
                            cmd3.ExecuteNonQuery();
                            cmd4.ExecuteNonQuery();
                        }
                    } catch (Exception ex) {
                        reader.Close();
                        MessageBox.Show(ex.Message);
                            cmd3.ExecuteNonQuery();
                            cmd4.ExecuteNonQuery();

                    }
                    
                  
                           
                      
                            
                        
                      
                     
                     
                    
                      
                }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                
            }


        }
    }
}
