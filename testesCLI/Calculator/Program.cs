using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            Console.Clear();
            v1 = PegaValores();


            Soma();
        }

        static double PegaValores(double valor)
        {
            Console.WriteLine("Insira o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            return valor;
        }

    }
}
//double v1 = Convert.ToDouble(Console.ReadLine());