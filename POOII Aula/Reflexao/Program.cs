using System.Reflection;
using System.Text;

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
            /*
            Bicicleta bike = new Bicicleta("Caloi", 15, 16, 18, "Moutain Bike");
            Notebook note = new("Intel", "16Gb", "Intel I7", 14.7);
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

            ImprimeReflection(bike);
            ImprimeReflection(note);
            

            /*
            MethodInfo[] metodos = bike.GetType().GetMethods();
            Console.WriteLine($"Tenho {metodos.Length} métodos publicos e são eles:");

            foreach (MethodInfo metodo in metodos)
            {
                Console.WriteLine($"{metodo.Name} que retorna o tipo {metodo.ReturnType}");
            }

            //var metodoFreiar = metodos.FirstOrDefault()
            MethodInfo metodoFreiar = bike.GetType().GetMethod("Freiar");

            //Parametro 1 do Invoke -> objeto que terá o método invocado
            //Parametro 2 do Invoke -> array de object com os parametros que o método necessita
            metodoFreiar.Invoke(bike, new object[] { "devagar" });
            
            */

            //instancia com base em um objeto existente
            /*
            Bicicleta bike = new Bicicleta("Caloi", 15, 16, 18, "Moutain Bike");
            object? bikeEmExecucao2 = Activator.CreateInstance(bike.GetType());
            // new Bicicleta();
            */

            //instancia com base no tipo
            Type tipoBike = typeof(Bicicleta);

            object? bikeEmExecucao = Activator.CreateInstance(tipoBike, new object[] { "Terrestre", 21, 26, 21, "Corrida" });
            // new Bicicleta("Terrestre", 21, 26, 21, "Corrida");

            ImprimeReflection(bikeEmExecucao);
        }

        public static void ImprimeReflection(object objeto)
        {
            //obtem o tipo do objeto
            var tipo = objeto.GetType();

            StringBuilder builder = new StringBuilder();
            //obtem o nome do tipo
            builder.AppendLine("Log do " + tipo.Name);

            //Vamos obter agora todas as propriedades do tipo
            //Usamos o método GetProperties para obter
            //o nome das propriedades do tipo
            foreach (var prop in tipo.GetProperties())
            {
                //usa a propriedade Name para obter o nome da propriedade
                //e o método GetValue() para obter o valor da instância desse tipo
                builder.AppendLine(prop.Name + ": " + prop.GetValue(objeto));
            }
            Console.WriteLine(builder.ToString());

        }
    }

}