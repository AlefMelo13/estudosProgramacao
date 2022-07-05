using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSocialMedia.Entities
{
    internal class Postagens
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();

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
    }
}