namespace BackendProF.EntityF.Models
{
    public class movieDtocs
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime Año { get; set; }

        public string Director { get; set; }

        public string Genero { get; set; }

        public IFormFile Poster { get; set; }



    }
}
