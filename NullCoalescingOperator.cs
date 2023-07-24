using System;

namespace NullCoalescingOperator
{
    public class OperadorAtribuicaoUniaoNula
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }

        public OperadorAtribuicaoUniaoNula(){}

        public void LerOperadorAtribuicaoUniaoNula()
        {
            try
            {
                Console.WriteLine("Exemplo (B): System.NullReferenceException");
                
                OperadorAtribuicaoUniaoNula operadorNulo = new OperadorAtribuicaoUniaoNula();
                operadorNulo.Nome = "Fulano";
                operadorNulo.CPF ??= "Default";
                
                Console.WriteLine(operadorNulo.CPF);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        // static string EditOperadorCondigionalNulo(string nome, string cpf)
        // {
        //     var op = new OperadorCondicionalNulo()
        //     {
        //         Nome = nome,
        //         CPF = cpf
        //     };

        //     return op.ToString();
        // }
    }

}