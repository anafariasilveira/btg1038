namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //os métodos são referentes a interface e não a classe
            //por isso eu só consigo invocar os métodos referentes a
            //interface do objeto.
            //a interface não é instanciada
            //eu tenho um objeto do tipo interface,
            //mas com a instancia da classe

            IReinoAnimale pessoa = new Humano();
            pessoa.Movimentar();
            pessoa.Reproduzir();
            pessoa.Comer();
            //pessoa.Casar();
            pessoa.Respirar();
            pessoa.Idade = 10;
            
            IHumano humano2 = new Humano();
            //humano2.Movimentar();
            //humano2.Reproduzir();
            //humano2.Comer();
            humano2.Pensar();

            IExercitar pessoa2 = new Humano();
            //pessoa2.Movimentar();
            //pessoa2.Reproduzir();
            //pessoa2.Comer();
            //pessoa2.Pensar();
            pessoa2.Movimentar();

            Humano humano3 = new();
            // Nao consigo acesso pois elas são exclusivamentes da interface
            //humano3.Movimentar();

            /*
             * 
                Crie uma interface Exercicio contendo os contratos para:
                FazerProva - implementado
                FazerTreino - implementado
                FazerFortalecimento - contrato
                FazerAlongamento - contrato

                Crie uma classe Natacao que implemente os métodos
                Fortalecimento -> Malhar membros superiores e inferiores
                Alongamento -> Alongar membros superiores e inferiores

                Crie uma classe CorridaObstaculos que implemente os métodos
                Fortalecimento -> Malhar membros inferiores
                Alongamento -> Alongar membros inferiores

                Crie uma classe teste
             */
        }
    }
}