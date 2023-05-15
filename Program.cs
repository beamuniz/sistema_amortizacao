using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Sistema_Amortizacao
{
    class Program
    {
        enum Opcao { AmortizacaoConstante = 1, PrestacaoConstante = 2, AmortizacaoMisto = 3, EncerrarPrograma = 4 }

        static void Main(string[] args)
        {
            while (true)
            {
                Menu.Exibir();
                Opcao opcao;

                while (!Enum.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente:");
                }

                switch (opcao)
                {
                    case Opcao.AmortizacaoConstante:
                        AmortizacaoConstante.Executar();
                        break;
                    case Opcao.PrestacaoConstante:
                        PrestacaoConstante.Executar();
                        break;
                    case Opcao.AmortizacaoMisto:
                        AmortizacaoMisto.Executar();
                        break;
                    case Opcao.EncerrarPrograma:
                        Console.WriteLine("Programa Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                if (opcao == Opcao.EncerrarPrograma)
                {
                    break;
                }
            }
        }
    }
}
