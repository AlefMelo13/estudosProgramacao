namespace Lista
{
    internal class Lista
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Leandro");
            lista.Add("Karol");
            lista.Add("José");
            lista.Add("Lucas");
            lista.Add("Neto");
            lista.Add("Ronaldo");
            lista.Insert(2, "Teste");

            foreach (string a in lista) {
                Console.WriteLine(a);
            }

            Console.WriteLine("Tamanho da Lista: " + lista.Count);

            string nome = lista.Find(x => x[0] == 'L');
            Console.WriteLine("Primeiro nome que começa com L: " + nome);

            string nome2 = lista.Last(x => x[0] == 'L');
            Console.WriteLine("Último nome que começa com L: " + nome2);

            int posicao = lista.FindIndex(x => x[0] == 'L');
            Console.WriteLine("A posição do primeiro nome que comaça com L é: " + posicao);

            int posicao2 = lista.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("A posição do último nome que comaça com L é: " + posicao2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Nomes com 5 caracteres:");
            foreach (string a in lista2)
            {
                Console.WriteLine(a);
            }

            lista.Remove("Neto");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Removendo Neto: ");
            foreach (string a in lista)
            {
                Console.WriteLine(a);
            }

            lista.RemoveAll(x => x[0] == 'R');
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Removendo pessoas com nomes começados com R:");

            foreach (string a in lista)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Removendo a posição 3:");
            lista.RemoveAt(3);
            foreach (string a in lista)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Removendo dois nomes a partir da posição 2:");
            lista.RemoveRange(2, 2);
            foreach (string a in lista)
            {
                Console.WriteLine(a);
            }
        }
    }
}