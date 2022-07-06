namespace PostSocialMedia.Entities
{
    class Comentarios
    {
        public string Texto { get; set; }

        //CONSTRUTORES
        public Comentarios()
        {
        }

        public Comentarios(string texto)
        {
            Texto=texto;
        }
    }
}