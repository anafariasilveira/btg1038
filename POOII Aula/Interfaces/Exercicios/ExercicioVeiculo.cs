using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Exercicios
{
    /*
     * Uma interface define um contrato.
     * Qualquer classe que implemente esse contrato
     * deve fornecer implementações dos membros definidos na interface.
     * 
     * Crie um programa em C# que contenha uma interface IVeiculo com dois métodos,
     * um para Dirigir do tipo STRING e
     * outro para Reabastecer do tipo bool que tenha um parâmetro
     *      do tipo int com a quantidade de gasolina a ser reabastecida.
     * 
     * Em seguida, crie uma classe Carro com um construtor
     * que receba um parâmetro com a quantidade de gasolina inicial do carro
     * e implemente os métodos Dirigir e Reabastecer do carro.
     * 
     * O método Dirigir retornará "Dirigindo", se a gasolina for maior que 0.
     * O método Reabastecer aumentará a gasolina do carro e retornará true.
     */

    using System;

    public interface IVeiculo
    {
        string Dirigir();
        bool Reabastecer(int quantidade);
    }

    public class Carro : IVeiculo
    {
        private int gasolina;

        public Carro(int quantidadeInicialGasolina)
        {
            gasolina = quantidadeInicialGasolina;
        }

        public string Dirigir()
        {
            if (gasolina == 0)
            {
                return "Sem gasolina, não é possível dirigir.";
            }

            return "Dirigindo";
        }

        public bool Reabastecer(int quantidade)
        {
            if (quantidade == 0)
                return false;

            gasolina += quantidade;
            Console.WriteLine($"Reabastecido com sucesso. Gasolina atual: {gasolina}");
            return true;
        }
    }
}
