

using System.Reflection.Metadata.Ecma335;

namespace BackendProF.EntityF.Request
{
    public class PeliculaRequest
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime Año { get; set; }

        public string Director { get; set; }

        public string Genero { get; set; }

        public string Poster { get; set; }

    }
}
