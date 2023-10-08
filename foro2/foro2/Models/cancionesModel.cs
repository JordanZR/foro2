using System;


namespace foro2.Models
{
    public class cancionesModel
    {
        public int Id { get; set; } // Opcional: si deseas un identificador único para cada canción.

        public string NombreCancion { get; set; }

        public string Album { get; set; }

        public string RutaCancion { get; set; }

        public string ImagenCancion { get; set; }

        public DateTime FechaLanzamiento { get; set; }

    }
}
