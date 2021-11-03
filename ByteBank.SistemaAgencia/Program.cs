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
            // Array de inteiros com 5 posições
            
            int [] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 55;

            int idadeNoIndice4 = idades[4];
        
            Console.WriteLine(idadeNoIndice4);

            int[] outroArray = idades;
            Console.WriteLine(outroArray[3]);

            Console.ReadLine();
        }
    }
}
