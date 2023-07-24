using System;

namespace NullOperator
{
    public class Operador
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }
        public Operador(){}

        public void LerOperador()
        {
            try
            {
                Console.WriteLine("Exemplo (E): System.NullReferenceException");
                
                Operador operadorNulo = new Operador();
                operadorNulo.Nome = "Fulano";
                operadorNulo.CPF = null!;
                
                if(operadorNulo.CPF != null)
                {
                    Console.WriteLine(operadorNulo.CPF);
                }
                else
                {
                    Console.WriteLine("O valor da propriedade CPF é nulo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}