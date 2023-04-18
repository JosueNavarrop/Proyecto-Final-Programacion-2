using Microsoft.AspNetCore.Mvc;
using BackendProF.EntityF.Response;
using BackendProF.EntityF;
using BackendProF.EntityF.Request;
using BackendProF.Interfaces;
using BackendProF.EntityF.Models;

namespace BackendProF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : Controller
    {
        //ProyectoFinalContext contexto;

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Pelicula>> oResp = new Respuesta<List<Pelicula>>();


            try
            {
                using (ProyectoFinalContext db = new ProyectoFinalContext())
                {
                    var lst = db.Peliculas.ToList();
                    oResp.Exito = 1;

                    oResp.Data = lst;

                }
            }
            catch (Exception ex)
            {
                oResp.Mensaje = ex.Message;
            }
            return Ok(oResp);
        }



        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            Respuesta<Pelicula> oResp = new Respuesta<Pelicula>();


            try
            {
                using (ProyectoFinalContext db = new ProyectoFinalContext())
                {
                    var lst = db.Peliculas.Find(Id);
                    oResp.Exito = 1;

                    oResp.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oResp.Mensaje = ex.Message;
            }
            return Ok(oResp);
        }


        [HttpPost]
        public IActionResult Add(PeliculaRequest model)
        {
            Respuesta<object> oResp = new Respuesta<object>();

            try
            {


                using (ProyectoFinalContext db = new ProyectoFinalContext())
                {
                    Pelicula opeli = new Pelicula();
                    opeli.Titulo = model.Titulo;
                    opeli.Año = model.Año;
                    opeli.Director = model.Director;
                    opeli.Genero = model.Genero;
                    opeli.Poster = model.Poster;

                    db.Peliculas.Add(opeli);
                    db.SaveChanges();
                    oResp.Exito = 1;

                }
            }
            catch (Exception ex)
            {
                oResp.Mensaje = ex.Message;
            }
            return Ok(oResp);
        }


        [HttpPut]
        public IActionResult Edit(PeliculaRequest model)
        {
            Respuesta<object> oResp = new Respuesta<object>();
            try
            {

                using (ProyectoFinalContext db = new ProyectoFinalContext())
                {
                    Pelicula opeli = db.Peliculas.Find(model.Id);
                    opeli.Titulo = model.Titulo;
                    opeli.Año = model.Año;
                    opeli.Director = model.Director;
                    opeli.Genero = model.Genero;
                    opeli.Poster = model.Poster;
                    db.Entry(opeli).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oResp.Exito = 1;

                }
            }
            catch (Exception ex)
            {
                oResp.Mensaje = ex.Message;
            }

            return Ok(oResp);

        }



        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<object> oResp = new Respuesta<object>();


            try
            {
                using (ProyectoFinalContext db = new ProyectoFinalContext())
                {
                    Pelicula opeli = db.Peliculas.Find(Id);
                    db.Remove(opeli);
                    db.SaveChanges();
                    oResp.Exito = 1;

                }
            }
            catch (Exception ex)
            {
                oResp.Mensaje = ex.Message;
            }
            return Ok(oResp);
        }

        ////Guardar Imagenes
        //[HttpPost("GuardarImagen")]

        //public async Task<string> GuardarImagen([FromForm] SubirImagenAPI fichero)
        //{
        //    var ruta = string.Empty;
        //    var nombreArchivo = Guid.NewGuid().ToString() + ".jpg";
        //    ruta = $"Imagenes/{nombreArchivo}";
        //    using (var stream = new FileStream(ruta, FileMode.Create))
        //    {
        //        await fichero.Archivo.CopyToAsync(stream);
        //    }


        //    return ruta;
        //}



        //[HttpGet("Obtener imagenes")]
        //public IActionResult Get(string nombreimagen)
        //{
        //    var ruta = Path.Combine("Imagenes", nombreimagen);
        //    byte[] imagenbyte = System.IO.File.ReadAllBytes(ruta);
        //    return File(imagenbyte, "image/jpeg");

        //}


        //Guardar Peli new method (PROFESOR!!!!!!!!!!!)

        //private readonly IImagenes imagenServives;

        //public PeliculasController(IImagenes imagen)
        //{
        //    imagenServives = imagen;
        //}

        //[HttpPost("subir-imagen")]
        //public IActionResult SubirArchivo([FromForm] IFormFile file, PeliculaRequest model)
        //{
        //    return Ok(imagenServives.SubirImage(file));

        //}



    } 
}
