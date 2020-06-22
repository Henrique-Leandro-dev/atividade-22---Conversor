using System;

namespace static__Convertor_de_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Doláres para Reais:");
            System.Console.WriteLine( Conversor.DolarParaReais(52));
            System.Console.WriteLine("Reais para Doláres:"); 
            System.Console.WriteLine( Conversor.RealParaDolar(52));
            System.Console.WriteLine("Euros para Reais:");
            System.Console.WriteLine(Conversor.EuroParaReais(52));
            System.Console.WriteLine("Reais para euros:");
            System.Console.WriteLine(Conversor.ReaisParaEuro(52));
        }
    }
}
