using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

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

        [WebMethod]
        [WebInvoke(Method = "POST")]
        [ScriptMethod(UseHttpGet = true)]
        public void Rol()
        {
          var request =  Context.Request;
            NameValueCollection formVariables = request.Form;
            Context.Response.Output.Write(formVariables.Get(1));
        }
    }
}
