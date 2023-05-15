using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrestacaoConstante
{
    public static void Executar()
    {
        double valorEmprestimo = 160000;
        double taxaJurosAnual = 0.1136;
        int numParcelasSemestrais = 5;
        int numParcelas = numParcelasSemestrais * 2;
        double taxaJurosSemestral = taxaJurosAnual / 2;
        double amortizacao = valorEmprestimo / numParcelas;

        double saldoDevedor = valorEmprestimo;

        Console.WriteLine();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Sistema de Prestação Constante (SPC)");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Parcela\tSaldo\tAmort\tJuros\tPrestação");

        double fatorPrice = Math.Pow(1 + taxaJurosSemestral, numParcelas);
        double prestacaoPriceFixa = valorEmprestimo * taxaJurosSemestral * fatorPrice / (fatorPrice - 1);
        
        for (int i = 0; i <= numParcelas; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}\t{1}\t-\t-\t-", i, saldoDevedor);
            }
            else
            {
                double jurosPC = Math.Round(saldoDevedor * taxaJurosSemestral);
                double prestacaoPC = Math.Round(prestacaoPriceFixa);
                saldoDevedor -= amortizacao;
                double amortizacaoPC = Math.Round(prestacaoPC - jurosPC);

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, saldoDevedor, amortizacaoPC, jurosPC, prestacaoPC);
            }
        }

        double totalAmortizacao = Math.Round(amortizacao * numParcelas);
        double totalJuros = Math.Round(prestacaoPriceFixa * numParcelas - valorEmprestimo);
        double totalPrestacao = Math.Round(prestacaoPriceFixa * numParcelas);

        Console.WriteLine("Total\t\t{0}\t{1}\t{2}", totalAmortizacao, totalJuros, totalPrestacao);

        Console.WriteLine();
    }
}
