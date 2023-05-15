using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AmortizacaoConstante
{
    public static void Executar()
    {
        // Declarando váriaveis e atribuindo valores
        double valorEmprestimo = 160000;
        double taxaJurosAnual = 0.1136;
        int numParcelasSemestrais = 5;

        double taxaJurosSemestral = taxaJurosAnual / 2;
        int numParcelas = numParcelasSemestrais * 2;
        double amortizacao = valorEmprestimo / numParcelas;

        // Cálculos
        double saldoDevedorAC = valorEmprestimo;
        double jurosAC, prestacaoAC;
        double totalAmortizacaoAC = 0;
        double totalJurosAC = 0;
        double totalPrestacaoAC = 0;

        Console.WriteLine();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Sistema de Amortização Constante (SAC)");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Parcela\tSaldo\tAmort\tJuros\tPrestação");

        for (int i = 0; i <= numParcelas; i++)
        {
            if (i == 0) // Se a Parcela for igual a 0, escrevera apenas o saldo devedor
            {
                Console.WriteLine("{0}\t{1}\t-\t-\t-", i, saldoDevedorAC);
            }
            else // Caso contrário, continuará o loop preenchendo o restante das colunas
            {
                jurosAC = Math.Round(saldoDevedorAC * taxaJurosSemestral);
                prestacaoAC = amortizacao + jurosAC;
                saldoDevedorAC -= amortizacao;
                totalAmortizacaoAC += amortizacao;
                totalJurosAC += jurosAC;
                totalPrestacaoAC += prestacaoAC;

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, saldoDevedorAC, amortizacao, jurosAC, prestacaoAC);
            }
        }

        Console.WriteLine("Total\t\t{0}\t{1}\t{2}", totalAmortizacaoAC, totalJurosAC, totalPrestacaoAC);

        Console.WriteLine();

    }
}