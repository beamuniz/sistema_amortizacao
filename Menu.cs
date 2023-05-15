using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Menu
{
    public static void Exibir()
    {
        Console.WriteLine("Sistemas de Amortização");
        Console.WriteLine("===========================");
        Console.WriteLine("[1] Amortização Constante");
        Console.WriteLine("[2] Prestação Constante");
        Console.WriteLine("[3] Amortização Misto");
        Console.WriteLine("[4] Encerrar Programa");
        Console.WriteLine("===========================");
        Console.Write("\nEscolha uma Opção: ");
    }
}