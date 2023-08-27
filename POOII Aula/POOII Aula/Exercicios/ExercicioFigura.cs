using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Aula.Exercicios
{
    /*
     * Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

        Elas podem conter propriedades e métodos abstratos ou não abstratos,
    mas não podem ser instanciadas e podem forçar novas implementações de métodos virtuais.

        Crie uma classe abstrata chamada Figura.
    Nessa classe, nós teremos uma propriedade abstrata cor do tipo string e
    um método abstrato double area().

        Em seguida, vamos criar a classe Retangulo que vai herdar a classe Figura
    e declarar dois atributos nela como double (lado1 e lado2).
    Vamos também sobrescrever o método double area(), onde colocaremos um return com
    a função lado 1 * lado 2, para obtermos a área.

        Vamos criar uma classe Triangulo que vai herdar a classe Figura com
    os atributos base e altura e um método double area() que retorna base * altura.

        Para finalizar, vamos criar uma classe estática chamada Teste
    com um método estático chamado DetalhesFigura que receberá um objeto do tipo Figura
    e retornará as informações sobre o objeto.
    */
    public abstract class Figura
    {
        public abstract string Cor { get; set; }

        public abstract double Area();
    }

    public class Retangulo : Figura
    {
        public double lado1;
        public double lado2;

        public override string Cor { get; set; }

        public override double Area()
        {
            return lado1 * lado2;
        }
    }

    public class Triangulo : Figura
    {
        public override string Cor { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }
    }

    public static class Teste
    {
        public static string DetalhesFigura(Figura figura)
        {
            return $"Cor da figura: {figura.Cor} - Área da figura: {figura.Area()}";
        }
    }
}
