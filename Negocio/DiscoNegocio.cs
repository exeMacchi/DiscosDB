using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Disco> CargarDiscos()
        {
            List<Disco> discos = new List<Disco>();

            AccesoDB db = new AccesoDB();
            // SqlConnection conexion = new SqlConnection();
            // SqlCommand comando = new SqlCommand();
            // SqlDataReader lector;
            // conexion.ConnectionString = "server=DESKTOP-FUV4AD1;" +
            //                             "database=DISCOS_DB;" + 
            //                             "integrated security=true;";

            try
            {
                db.SetQuery("SELECT D.Id AS ID, " +
                            "       D.Titulo AS Titulo, " +
                            "       D.FechaLanzamiento AS Lanzamiento, " +
                            "       D.CantidadCanciones AS CantidadCanciones, " +
                            "       D.IdEstilo AS IdEstilo, " +
                            "       E.Descripcion AS Estilo, " +
                            "       D.IdTipoEdicion AS IdEdicion, " +
                            "       TE.Descripcion AS Edicion, " +
                            "       D.UrlImagenTapa AS Portada " +
                            "FROM DISCOS AS D " +
                            "INNER JOIN ESTILOS AS E ON D.IdEstilo = E.Id " +
                            "INNER JOIN TIPOSEDICION AS TE ON D.IdTipoEdicion = TE.Id;");
                // comando.CommandType = System.Data.CommandType.Text;
                // comando.CommandText = ;

                db.ExecuteRead();
                // comando.Connection = conexion;
                // conexion.Open();
                // lector = comando.ExecuteReader();

                while (db.Lector.Read())
                {
                    Disco d = new Disco();
                    d.Id = (int)db.Lector["ID"];

                    if (!(db.Lector["Titulo"] is DBNull))
                        d.Titulo = (string)db.Lector["Titulo"];

                    if (!(db.Lector["Lanzamiento"] is DBNull))
                        d.FechaLanzamiento = (DateTime)db.Lector["Lanzamiento"];

                    if (!(db.Lector["CantidadCanciones"] is DBNull)) 
                        d.CantidadCanciones = (int)db.Lector["CantidadCanciones"];

                    // Es necesario crear la instancia, ya que no hay constructor en la clase Disco.
                    d.Estilo = new Estilo(); 
                    if (!(db.Lector["Estilo"] is DBNull))
                        d.Estilo.Descripcion = (string)db.Lector["Estilo"];
                    d.Estilo.ID = (int)db.Lector["IdEstilo"];

                    // Es necesario crear la instancia, ya que no hay constructor en la clase Disco.
                    d.Edicion = new Edicion();
                    if (!(db.Lector["Edicion"] is DBNull))
                        d.Edicion.Descripcion = (string)db.Lector["Edicion"];
                    d.Edicion.ID = (int)db.Lector["IdEdicion"];

                    if (!(db.Lector["Portada"] is DBNull))
                        d.Portada = (string)db.Lector["Portada"];

                    discos.Add(d);
                }

                return discos;
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

        public void AgregarDisco(Disco nuevoDisco)
        {
            AccesoDB db = new AccesoDB();

            try
            {
                db.SetQuery("INSERT INTO DISCOS " +
                            "VALUES (@Titulo, @FechaLanzamiento, @CantidadCanciones, " + 
                            "        @UrlPortada, @Estilo, @Edicion);");
                db.SetParametro("@Titulo", nuevoDisco.Titulo);
                db.SetParametro("@FechaLanzamiento", nuevoDisco.FechaLanzamiento);
                db.SetParametro("@CantidadCanciones", nuevoDisco.CantidadCanciones);
                db.SetParametro("@UrlPortada", nuevoDisco.Portada);
                db.SetParametro("@Estilo", nuevoDisco.Estilo.ID);
                db.SetParametro("@Edicion", nuevoDisco.Edicion.ID);
                db.ExecuteNonQuery();
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

        public void ModificarDisco(Disco modificarDisco)
        {
            AccesoDB db = new AccesoDB();

            try
            {
                db.SetQuery("UPDATE DISCOS " +
                            "SET Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento, " + 
                            "CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlPortada," +
                            "IdEstilo = @IdEstilo,  IdTipoEdicion = @IdEdicion " +
                            "WHERE DISCOS.Id = @ID;");
                db.SetParametro("@Titulo", modificarDisco.Titulo);
                db.SetParametro("@FechaLanzamiento", modificarDisco.FechaLanzamiento);
                db.SetParametro("@CantidadCanciones", modificarDisco.CantidadCanciones);
                db.SetParametro("@UrlPortada", modificarDisco.Portada);
                db.SetParametro("@IdEstilo", modificarDisco.Estilo.ID);
                db.SetParametro("@IdEdicion", modificarDisco.Edicion.ID);
                db.SetParametro("@ID", modificarDisco.Id);

                db.ExecuteNonQuery();
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

        public void BorrarDisco(int ID)
        {
            AccesoDB db = new AccesoDB();
            try
            {
                db.SetQuery("DELETE FROM DISCOS WHERE DISCOS.Id = @ID");
                db.SetParametro("@ID", ID);
                db.ExecuteNonQuery();
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
