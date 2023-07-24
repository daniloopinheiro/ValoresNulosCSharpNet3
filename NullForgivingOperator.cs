using System;

namespace NullForgivingOperator
{
    public class OperadorPerdoNulos
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }

        public OperadorPerdoNulos(){}

        public void LerOperadorPerdoNulos()
        {
            try
            {
                Console.WriteLine("Exemplo (C): System.NullReferenceException");
                
                OperadorPerdoNulos operadorNulo = new OperadorPerdoNulos();
                operadorNulo.Nome = "Fulano";
                operadorNulo.CPF = null!;
                int length = operadorNulo.CPF.Length;
                
                Console.WriteLine(length);
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