using System;

namespace ConditionalOperator
{
    public class OperadorCondicional
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }

        public OperadorCondicional(){}

        public void LerOperadorCondicional()
        {
            try
            {
                Console.WriteLine("Exemplo (D): System.NullReferenceException");
                
                OperadorCondicional operadorNulo = new OperadorCondicional();
                operadorNulo.Nome = "Fulano";
                operadorNulo.CPF = null!;
                string result = (operadorNulo.CPF != null) ? operadorNulo.CPF : "Unknown";
                
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}