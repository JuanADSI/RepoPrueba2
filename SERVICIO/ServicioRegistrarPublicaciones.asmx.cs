using appEscritorio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SERVICIO
{
    /// <summary>
    /// Descripción breve de ServicioRegistrarPublicaciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioRegistrarPublicaciones : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet mtdListarProductos()
        {
            DataSet dsProductos = new DataSet();
            Datos.Publicaciones objpub = new Datos.Publicaciones();
            dsProductos = objpub.mtdListar();
            return dsProductos;
        }
        [WebMethod]
        public int mtdRegistrarPublicaciones(Datos.Publicaciones objpubli)
        {
            Datos.Publicaciones objpub = new Datos.Publicaciones();
            int res = objpub.mtdRegistar(objpubli);
            return res;
        }
    }
}
