using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDB
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return lector; } }

        public AccesoDB()
        {
            conexion = new SqlConnection("server=DESKTOP-FUV4AD1;" +
                                         "database=DISCOS_DB;" + 
                                         "integrated security=true;");
            comando = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void SetParametro(string param, object valor)
        {
            comando.Parameters.AddWithValue(param, valor);
        }

        public void ExecuteRead()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecuteNonQuery()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
