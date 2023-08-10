namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Amanda", "Mantovani");

            pessoa1.Idade = 29;

            Pessoa pessoa2 = new();

            Pessoa pessoa3 = new Pessoa("Amanda", "Mantovani", 29);

            Pessoa pessoa4 = new Pessoa("Taisa", "Mantovani", 25);
        }
    }
}