using System.Reflection;

namespace Reflexao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int inteiro = 10;
            string texto = "Ada";

            Type tipo = inteiro.GetType();

            Console.WriteLine(tipo.Name);
            Console.WriteLine(texto.GetType().Name);*/

            Bicicleta bike = new Bicicleta("Caloi", 15, 16, 18, "Moutain Bike");
            bike.ImprimeDados();

            Console.WriteLine(bike.GetType().Name);

            //Mostrar todas as propriedades publicas
            PropertyInfo[] propriedades = bike.GetType().GetProperties();
            Console.WriteLine($"O tipo {bike.GetType().Name} possui {propriedades.Length} propriedades");
            foreach(var propriedade in propriedades)
            {
                Console.WriteLine($"Tenho a propriedade {propriedade.Name} que é do tipo {propriedade.PropertyType.Name} e meu valor é {propriedade.GetValue(bike)}.");
            }

            PropertyInfo propTipoQuadro = bike.GetType().GetProperty("TipoQuadro");

            //TipoQuadro
            propTipoQuadro.SetValue(bike, "Velocity");
            
            Console.WriteLine(propTipoQuadro.GetValue(bike));

            Console.WriteLine(bike.TipoQuadro);

            var propModelo = propriedades.FirstOrDefault(x => x.Name == "Modelo");
            propModelo.SetValue(bike, "Caloi2");

            bike.ImprimeDados();

            Notebook note = new("Intel", "16Gb", "Intel I7", 14.7);
            note.ImprimeDados();

        }
    }
}