using PostSocialMedia.Entities;

namespace PostSocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POSTAGEM NÚMERO 1
            Postagens post1 = new Postagens(
               DateTime.Parse("21/06/2018 13:05:44"),
               "Trevelling New Zealand!",
               "I'm going to visit this wonderful country!",
               12);

            Comentarios coment1 = new Comentarios("Have a nice trip!");
            Comentarios coment2 = new Comentarios("Wow that's awesome!");

            post1.AdicionaComentario(coment1);
            post1.AdicionaComentario(coment2);

            //POSTAGEM NÚMERO 2
            Postagens post2 = new Postagens(
                DateTime.Parse("28/07/2019 23:14:19"),
                "Good night guys!",
                "See you tomorrow!",
                5);

            Comentarios coment3 = new Comentarios("Good night!");
            Comentarios coment4 = new Comentarios("May the Force be with you");

            post2.AdicionaComentario(coment3);
            post2.AdicionaComentario(coment4);

            //IMPRIME POSTAGENS NA TELA
            Console.WriteLine();

            Console.WriteLine("Postagem 01");
            Console.WriteLine(post1);

            Console.WriteLine();

            Console.WriteLine("Postagem 02");
            Console.WriteLine(post2);
        }
    }
}