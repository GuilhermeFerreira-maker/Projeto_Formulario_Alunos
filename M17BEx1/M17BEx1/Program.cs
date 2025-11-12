using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Acesso negado - Precisas de ter 18 anos ou mais");
            }
            else
            {
                Console.WriteLine("Acesso concedido!!");

            }

        }

            static void Main(string[] args)
            {
            checkAge(20);
            Console.ReadKey();
            }
    }

