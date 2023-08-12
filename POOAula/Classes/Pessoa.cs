using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pessoa
    {
        public string Identificador { get; set; }
        public string Nome { get; set; }
        internal string Sobrenome { get; set; }
        public int Idade { get; set; } = 1; //valor default caso nao informado
        private List<Animal> Animais { get; set; } = new();
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            Identificador = Guid.NewGuid().ToString();
            Animais = new();
        }

        // encapsulamento - através de um método
        public void AdicionarAnimal(Animal animal)
        {
            Animais.Add(animal);
        }

        public bool FazerAniversario(string nome, string especie)
        {
            //linq & lambda
            //Animais.First() -- retorna exception quando não encontra
            //Animais.FirstOrDefault() -- retorna null quando não encontra
            Animal? animalAniversariante = Animais.FirstOrDefault(obj => obj.Nome == nome &&
                                                                         obj.Especie == especie);
            //foreach(Animal obj in Animais)
            if (animalAniversariante == null)
            {
                return false;
            }

            animalAniversariante.Idade++;
            return true;
        }

        public List<Animal> BuscarAnimaisPorEspecie(string especie)
        {
            //SELECT * FROM ANIMAIS WHERE ESPECIE = GATO
            return Animais.Where(obj => obj.Especie == especie).ToList();
        }

        public void PossuiEspecie(string especie)
        {
            if (Animais.Any(x => x.Especie == especie))
                Console.WriteLine($"Possui {especie}");
            else
                Console.WriteLine($"Não possui {especie}");
        }

        public void ImprimirAnimais()
        {
            Animais.ForEach(x =>
            {
                Console.WriteLine($"Animal {x.Nome} da espécie {x.Especie} possui {x.Idade} anos");
            });
        }
    }
}
