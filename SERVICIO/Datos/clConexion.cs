using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEscritorio.Datos
{
    class clConexion
    {

        SqlConnection objConexion = null;
        public clConexion()
        {
            try
            {
                objConexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bdSaleYa.mdf;Integrated Security=True");
            }
            catch (Exception exe)
            {
                string salida = exe.Message;
            }
        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();
            SqlCommand comando = new SqlCommand(consulta, objConexion);
            int res = comando.ExecuteNonQuery();
            objConexion.Close();
            return res;
        }
        public DataSet mtdDesconectado(string consulta)
        {
            objConexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, objConexion);
            DataSet dsDatos = new DataSet();
            adaptador.Fill(dsDatos, "tblDatos");
            objConexion.Close();
            return dsDatos;
        }


    }
}
