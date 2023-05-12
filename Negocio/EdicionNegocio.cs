using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EdicionNegocio
    {
        public List<Edicion> CargarEdiciones()
        {
            List<Edicion> ediciones = new List<Edicion>();
            AccesoDB db = new AccesoDB();
            try
            {
                db.SetQuery("SELECT TE.Id AS ID, " +
	                        "       TE.Descripcion AS Descripcion " +
                            "FROM TIPOSEDICION AS TE " +
                            "ORDER BY TE.Descripcion ASC;");
                db.ExecuteRead();
                
                while (db.Lector.Read())
                {
                    Edicion te = new Edicion();
                    te.ID = (int)db.Lector["ID"];
                    te.Descripcion = (string)db.Lector["Descripcion"];

                    ediciones.Add(te);
                }

                return ediciones;
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
