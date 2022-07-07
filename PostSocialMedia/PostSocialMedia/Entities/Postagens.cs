using System.Text;

namespace PostSocialMedia.Entities
{
    internal class Postagens
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();

        //CONSTRUTORES
        public Postagens()
        {
        }

        public Postagens(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionaComentario(Comentarios comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentarios comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder post = new StringBuilder();
            post.AppendLine(Titulo);
            post.Append(Likes + " Likes - ");
            post.AppendLine(Momento.ToString());
            post.AppendLine(Conteudo);
            post.AppendLine();

            post.AppendLine("Comentários:");
            foreach (Comentarios coment in Comentarios)
            {
                post.AppendLine(coment.Texto);
            }

            return post.ToString();
        }
    }
}