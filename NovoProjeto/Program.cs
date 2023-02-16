using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            // VERSAO 1
            /*

           Pessoa pessoa1 = new Pessoa();

           pessoa1.CalculaImc(60,1.88);
           pessoa1.CalculaIdade(1994, 2023);
           pessoa1.ContaString("Amanda");

           Console.WriteLine("O nome é: "+ pessoa1.nome + "\n");
           Console.WriteLine("A altura é: "+ pessoa1.altura + "\n");
           Console.WriteLine("O peso é: "+ pessoa1.peso + "\n");
           Console.WriteLine("O IMC é: "+ pessoa1.imc + "\n");
           Console.WriteLine("A idade é: " + pessoa1.idade + "\n");
           Console.WriteLine("A quantidade de caracteres no nome "+ 
               pessoa1.nome + " é: " + pessoa1.qtdString);
            */


            //VERSÃO 2
            
            Pessoa pessoa2= new Pessoa();
            Console.WriteLine("Digite um nome: ");
            pessoa2.nome = Console.ReadLine();
            pessoa2.ContaString(pessoa2.nome);
            Console.WriteLine("\n");

            Console.WriteLine("Digite a altura de " + pessoa2.nome);
            pessoa2.altura = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o peso de " + pessoa2.nome);
            pessoa2.peso = float.Parse(Console.ReadLine());
            pessoa2.CalculaImc(pessoa2.peso,pessoa2.altura);
            Console.WriteLine("\n");


            Console.WriteLine("Digite o ano de nascimento de " + pessoa2.nome + "\n");
            pessoa2.anoNasc = Convert.ToInt32(Console.ReadLine());
            pessoa2.CalculaIdade(pessoa2.anoNasc,2023);
            Console.WriteLine("\n");

            Console.WriteLine("Os dados de " + pessoa2.nome + " são esses: " + "\n");
            Console.WriteLine("IMC: " + pessoa2.imc + "\n");
            Console.WriteLine("Idade: " + pessoa2.idade + "\n");
            Console.WriteLine("Número de letras do nome digitado: " + pessoa2.qtdString);
            
            

            //VERSAO 3
            /*
            Pessoa pessoa3 = new Pessoa();
            Console.WriteLine("Digite a altura de " + pessoa3.nome);
            pessoa3.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o peso de " + pessoa3.nome);
            pessoa3.peso = double.Parse(Console.ReadLine());
            pessoa3.CalculaImc(pessoa3.peso, pessoa3.altura);
            Console.WriteLine("\n");
            Console.WriteLine("IMC: " + pessoa3.imc + "\n");
            */

            




            Console.ReadKey();

        
        }
    }

    
}
