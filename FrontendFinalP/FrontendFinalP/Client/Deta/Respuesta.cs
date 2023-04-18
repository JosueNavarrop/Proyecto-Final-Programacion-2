namespace FrontendFinalP.Client.Deta
{
    public class Respuesta<T>
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public T Data { get; set; }
 

    }
}
