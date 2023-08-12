namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new()
            {
                Nome = "Amanda",
                Sobrenome = "Mantovani",
                Idade = 29
            };

            pessoa1.AdicionarAnimal(new Animal("Lassy", "Cachorro", 3));
            pessoa1.AdicionarAnimal(new Animal("Kira", "Cachorro", 6));

            pessoa1.ImprimirAnimais();
            pessoa1.PossuiEspecie("Gato");
            pessoa1.PossuiEspecie("Cachorro");

            pessoa1.FazerAniversario("Kira", "Cachorro");

            pessoa1.ImprimirAnimais();

            //Pessoa pessoa1 = new Pessoa("Amanda", "Mantovani");

            //pessoa1.Idade = 29;
            //Pessoa pessoa5 = new();

            //string nomeDigitado = "amanda";

            //Pessoa pessoa2 = new()
            //{
            //    Nome = nomeDigitado,
            //    Sobrenome = "Mantovani",
            //    Idade = 29
            //};

            //pessoa5.Nome = "Amanda";
            //pessoa5.Sobrenome = "Mantovani";
            //pessoa5.Idade = 29;

            //Console.WriteLine(pessoa2.Idade);

            ////pessoa2.setIdade(29);
            ////pessoa2.getIdade();

            //Pessoa pessoa3 = new Pessoa("Amanda", "Mantovani", 29);

            //Pessoa pessoa4 = new Pessoa("Taisa", "Mantovani", 25);
        }
    }
}