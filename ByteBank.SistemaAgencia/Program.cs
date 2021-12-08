using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1235));
            lista.Adicionar(new ContaCorrente(874, 1236));
            lista.Adicionar(new ContaCorrente(874, 1237));
            lista.Adicionar(new ContaCorrente(874, 1238));
            lista.Adicionar(new ContaCorrente(874, 1239));
            lista.Adicionar(new ContaCorrente(874, 12310));
            ContaCorrente contaDoJhojho = new ContaCorrente(1111, 1222);

            lista.Adicionar(contaDoJhojho);
            
            lista.EscreverListaNaTela();
            
            lista.Remover(contaDoJhojho);
            
            lista.EscreverListaNaTela();
            
            Console.ReadLine();
        }

        static void TestaArraydeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(873, 1234),
                new ContaCorrente(873, 1235),
                new ContaCorrente(873, 1236),
                new ContaCorrente(873, 1237),
                new ContaCorrente(873, 1238),
                new ContaCorrente(873, 1239),
                new ContaCorrente(873, 12310)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }
        
        static void TestaArrayInt()
        {
            // Array de inteiros com 5 posições
            
            int [] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            // idades[3] = 50;
            // idades[4] = 55;
            // idades[5] = 60;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                
                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");

            // ** Ctrl + k + c = comenta várias linhas
        }
    }
}
