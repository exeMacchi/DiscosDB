using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public int Id { get; set; }

        // Anotadores que dan formato al nombre de la columna en el DataGridView
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }

        [DisplayName("Estilo")]
        public Estilo Estilo { get; set; }

        [DisplayName("Edición")]
        public Edicion Edicion { get; set; }

        public string Portada { get; set; }

        public override string ToString()
        {
            return $"Título: {Titulo}\n" +
                   $"Fecha de lanzamiento: {FechaLanzamiento.ToShortDateString()}\n" +
                   $"Cantidad de canciones: {CantidadCanciones}\n" +
                   $"Estilo: {Estilo}\n" +
                   $"Edición: {Edicion}";
        }
    }
}
