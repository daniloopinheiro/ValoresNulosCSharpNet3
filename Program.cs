using System;
using NullConditionalOperator;

namespace ValoresNulosCSharpNet3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Clear();
           
            // Console.WriteLine("Exemplo (D): System.NullReferenceException");
            // Console.WriteLine("Exemplo (E): System.NullReferenceException");
            
            NullConditionalOperator();

            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }

        private static void NullConditionalOperator()
        {
            var nullConditional = new OperadorCondicionalNulo();
            nullConditional.LerOperadorCondicionalNulo(); 
        }
    }
}
