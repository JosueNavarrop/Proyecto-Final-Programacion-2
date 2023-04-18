using BackendProF.EntityF;
using BackendProF.Interfaces;

namespace BackendProF.Servicios
{
    //public class ImagenService : IImagenes
    //{

    //    ProyectoFinalContext contexto;

    //    //public ImagenService(ProyectoFinalContext contexto)
    //    //{
    //    //    this.contexto = contexto;

    //    //}
    //    public string SubirImage(IFormFile file)
    //    {
    //        string ruta = @"C:\Imagenes de peliculas";
    //        string nombre = Guid.NewGuid().ToString() + file.FileName;

    //        var archivo = Path.Combine(ruta, nombre);

    //        using (var stream = File.Create(archivo))
    //        {
    //            file.CopyTo(stream);
    //        }
    //        guardarimagenBD(ruta);
    //        return "Archivo subio con exito";
    //    }

    //    private void guardarimagenBD(string ruta)
    //    {
    //        Pelicula peli = new Pelicula
    //        {

    //            Poster = ruta
    //        };

    //        contexto.Peliculas.Add(peli);
    //        contexto.SaveChanges();
    //    }
    //}
}
