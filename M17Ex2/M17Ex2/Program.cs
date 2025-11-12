using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Incío de Programa");
                Console.WriteLine("Escolher 8 números");
                for (int i = 0; i < 8; i++)
                {
                    int N = int.Parse(Console.ReadLine());
                }

            }
            catch (Exception Num)
            {
                Console.WriteLine("Erro: " + Num.Message);
            }
        }
    }
}