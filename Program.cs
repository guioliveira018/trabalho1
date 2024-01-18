using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {//trabalho

            decimal numero_um;
            decimal numero_dois;

            //solicitar valores
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Digite um numero");
            numero_um = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digete outro valor");
            numero_dois = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual operaçao voce escolhe (+, -, /, *)");

            string operacao;
            operacao = Console.ReadLine();

            //Escolher os valores


            //Resuldados

            decimal soma = numero_um + numero_dois;
            decimal sub = numero_um - numero_dois;
            decimal mult = numero_um * numero_dois;
            decimal div = numero_um / numero_dois;

            if (operacao == "+")
                Console.WriteLine("A soma do valor é:" + soma);

            if (operacao == "-")
                Console.WriteLine("A sub do valor é:" + sub);

            if (operacao == "*")
                Console.WriteLine("A mult do valor é:" + mult);

            if (operacao == "/")
                Console.WriteLine("A div do valor é:" + div);





        }
    }
}
