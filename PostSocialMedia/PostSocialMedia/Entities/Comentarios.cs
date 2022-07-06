using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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