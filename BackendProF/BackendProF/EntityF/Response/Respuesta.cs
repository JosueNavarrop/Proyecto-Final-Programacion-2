namespace BackendProF.EntityF.Response
{
    public class Respuesta<T>
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public T Data { get; set;}


        public Respuesta()
        { 
            this.Exito = 0;
        }
    }
}
