namespace POOII_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado formaQuadrada = new();
            formaQuadrada.Lado = 15;

            formaQuadrada.Area = formaQuadrada.CalcularArea();

            formaQuadrada.ImprimirArea();
        }
    }
}