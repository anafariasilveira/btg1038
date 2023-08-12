using Classes;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2023, 08, 11);

            DateTime dataeHora = new DateTime(2023, 08, 11, 21, 24, 30);

            DateTime dataHoraAgora = DateTime.Now;

            Console.WriteLine(data.Year);

            Console.WriteLine(data.Month);

            data.AddDays(10);
            
            data.AddDays(-10);

            Console.WriteLine(dataeHora.ToShortDateString());

            Console.WriteLine(dataeHora.ToShortTimeString());

            if (data > dataeHora)
            {
                Console.WriteLine("data é maior que dataeHora");
            }

            DateOnly soData = new DateOnly(2023, 08, 11);
            //TimeSpan
        }
    }
}