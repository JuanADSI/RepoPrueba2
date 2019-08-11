using appEscritorio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SERVICIO.Datos
{
    public class Publicaciones
    {

        public int IdPublicacion { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public string Estrato { get; set; }
        public string Direccion { get; set; }
        public int NumeroHabitaciones { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public int IdCiudad { get; set; }
        public int IdCategoria { get; set; }

        public DataSet mtdListar()
        {
            String consulta = "select * from Publicacion";
            DataSet dsProducto = new DataSet();
            clConexion objcone = new clConexion();
            dsProducto = objcone.mtdDesconectado(consulta);
            return dsProducto;
        }
        public int mtdRegistar(Publicaciones objpub)
        {
            clConexion objcone = new clConexion();
            string consulta = "insert into Publicacion(Nombre, Precio, Descripcion, Telefono, Estrato, Direccion, NumeroHabitaciones, IdUsuario, IdTipo, IdEstado, IdCiudad, IdCategoria) values('" + objpub.Nombre + "', " + objpub.Precio + ", '" + objpub.Descripcion + "', '" + objpub.Telefono + "', '" + objpub.Estrato + "', " + objpub.NumeroHabitaciones + ", " + objpub.IdUsuario + ", " + objpub.IdTipo + ", " + objpub.IdEstado + ", " + objpub.IdCiudad + ", " + objpub.IdCategoria + ")";
            int res = objcone.mtdConectado(consulta);
            return res;
        }

    }
}