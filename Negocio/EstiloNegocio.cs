using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> CargarEstilos()
        {
            List<Estilo> estilos = new List<Estilo>();
            AccesoDB db = new AccesoDB();
            try
            {
                db.SetQuery("SELECT E.Id AS ID, " +
	                        "       E.Descripcion AS Descripcion " +
                            "FROM ESTILOS AS E " + 
                            "ORDER BY E.Descripcion ASC;");
                db.ExecuteRead();
                
                while (db.Lector.Read())
                {
                    Estilo e = new Estilo();
                    e.ID = (int)db.Lector["ID"];
                    e.Descripcion = (string)db.Lector["Descripcion"];

                    estilos.Add(e);
                }

                return estilos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
