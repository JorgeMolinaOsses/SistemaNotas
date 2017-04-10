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
            NameValueCollection formVariables = request.Form;
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE dbo.Usuarios SET Rol = " + formVariables.Get(0) +
                        " WHERE Rut = "+formVariables.Get(1);
                    

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                
            }


        }
    }
}
