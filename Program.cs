using System;
using ConditionalOperator;
using NullCoalescingOperator;
using NullConditionalOperator;
using NullForgivingOperator;
using NullOperator;

namespace ValoresNulosCSharpNet3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Clear();
            
            NullConditionalOperator();
            NullCoalescingOperator();
            NullForgivingOperator();
            ConditionalOperator();
            NullOperator();

            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }
        private static void NullConditionalOperator()
        {
            var nullConditional = new OperadorCondicionalNulo();
            nullConditional.LerOperadorCondicionalNulo(); 
        }
        private static void NullCoalescingOperator()
        {
            var nullConditional = new OperadorAtribuicaoUniaoNula();
            nullConditional.LerOperadorAtribuicaoUniaoNula(); 
        }
        private static void NullForgivingOperator()
        {
            var nullConditional = new OperadorPerdoNulos();
            nullConditional.LerOperadorPerdoNulos(); 
        }
        private static void ConditionalOperator()
        {
            var nullConditional = new OperadorCondicional();
            nullConditional.LerOperadorCondicional(); 
        }
        private static void NullOperator()
        {
            var nullConditional = new Operador();
            nullConditional.LerOperador(); 
        }
    }
}
