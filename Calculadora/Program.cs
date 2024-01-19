using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Qual Operação Você Deseja fazer: ");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Sair");


        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Multiplicacao();
                break;
            case 4:
                Divisao();
                break;
            case 5:
                break;
        }


    }
    static void Soma()

    {
        Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Valor: ");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");


        float resultado = n1 + n2;
        Console.WriteLine($"O Resultado da Soma é: " + resultado);


    }

    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Valor: ");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");


        float resultado = n1 - n2;
        Console.WriteLine($"O Resultado da Subtração é: " + resultado);


    }
    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Valor: ");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");


        float resultado = n1 * n2;
        Console.WriteLine($"O Resultado da Multiplicação é: " + resultado);


    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Valor: ");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");


        float resultado = n1 / n2;
        Console.WriteLine($"O Resultado da Divisão é: " + resultado);

    }
}
