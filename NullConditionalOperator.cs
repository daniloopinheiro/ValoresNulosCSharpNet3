using System;

namespace NullConditionalOperator
{
    public class OperadorCondicionalNulo
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }

        public OperadorCondicionalNulo(){}

        public void LerOperadorCondicionalNulo()
        {
            try
            {
                Console.WriteLine("Exemplo (A): Referência de objeto não definida para uma instância de um objeto"); 
                
                OperadorCondicionalNulo operadorNulo = new OperadorCondicionalNulo();
                operadorNulo.Nome = "Fulano";
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