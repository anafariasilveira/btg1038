using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Aula.Exercicios
{
    /*
     * Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

        Escreva uma classe abstrata chamada CartaoWeb.

    Essa classe representa todos os tipos de cartões virtuais e conterá apenas um atributo:
    Destinatario (string).
    
    Nessa classe você deverá também declarar o método public abstract void ShowMessage().
    
    Crie classes filhas da classe CartaoWeb: DiaDosNamorados, Natal, Aniversario.
    
    Cada uma dessas classes deve conter um método construtor que
    receba o nome do destinatário do cartão.
    
    Cada classe também deve implementar o método ShowMessage(),
    mostrando uma mensagem ao usuário com seu nome e que seja específica para
    a data de comemorativa do cartão.
    Ex: "Feliz Dia dos Namorados, José!", "Feliz Natal, Maria!", "Feliz Aniversário, João!"

     */

    public abstract class CartaoWeb
    {
        public string destinatario;

        public abstract string ShowMessage();
    }

    public class DiaDosNamorados : CartaoWeb
    {
        public DiaDosNamorados(string destinatario)
        {
            this.destinatario = destinatario;
        }

        public override string ShowMessage()
        {
            return $"Feliz Dia dos Namorados, {destinatario}!";
        }
    }

    public class Natal : CartaoWeb
    {
        public Natal(string destinatario)
        {
            this.destinatario = destinatario;
        }

        public override string ShowMessage()
        {
            return $"Feliz Natal, {destinatario}!";
        }
    }

    public class Aniversario : CartaoWeb
    {
        public Aniversario(string destinatario)
        {
            this.destinatario = destinatario;
        }

        public override string ShowMessage()
        {
            return $"Feliz Aniversário, {destinatario}!";
        }
    }
}
