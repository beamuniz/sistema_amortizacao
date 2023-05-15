using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AmortizacaoMisto
{
    public static void Executar()
    {
        // Dados do empréstimo
        double valorEmprestimo = 160000.00;
        double taxaJurosAnual = 0.1136;
        int numParcelasSemestrais = 5;
        int numParcelasAnuais = 2;
        int numParcelas = numParcelasSemestrais * numParcelasAnuais;
        double taxaJurosSemestral = taxaJurosAnual / numParcelasAnuais;

        double amortizacaoMista = Math.Round(valorEmprestimo / numParcelas, 2);
        double saldoDevedor = valorEmprestimo;
        double jurosAcumulados = 0;

        Console.WriteLine();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Sistema de Amortização Mista (SAM)");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Parcela\t\tSaldo\t\tAmort.\t\tJuros\t\tPrestação");

        for (int i = 0; i <= numParcelas; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}\t\t{1}\t\t-\t\t-\t\t-", i, saldoDevedor);
            }
            else
            {
                double juros = Math.Round(saldoDevedor * taxaJurosSemestral, 2);
                double parcela = i <= numParcelasSemestrais ? Math.Round(amortizacaoMista + juros, 2) : Math.Round(saldoDevedor + juros, 2);
                double amortizacao = Math.Round(parcela - juros, 2);
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", i, saldoDevedor, amortizacao, juros, parcela);
                saldoDevedor = Math.Round(saldoDevedor - amortizacao, 2);
                jurosAcumulados += juros;
            }
        }
        Console.WriteLine("Total\t\t\t\t{0}\t\t{1}\t\t{2}\n\n", Math.Round(amortizacaoMista * numParcelas), Math.Round(jurosAcumulados), Math.Round(amortizacaoMista * numParcelas + jurosAcumulados));

        Console.WriteLine();
    }
}




