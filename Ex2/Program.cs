using System;
using System.Text.RegularExpressions;
namespace exercicio2
{
    public class Program
    {
        public static int ContaAparicoes(string frase, string palavra)
        {
            if (palavra == null || frase == null) 
            {
                return 0;
            }
            var contador = Regex.Matches(frase, palavra).Count;
            return contador;
        }   

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            Console.WriteLine(ContaAparicoes("Banana", "a")); // 3
            Console.WriteLine(ContaAparicoes("Banana", "a")); // 3
            Console.WriteLine(ContaAparicoes("Banana", "na")); // 2
            Console.WriteLine(ContaAparicoes("Banana", "ka")); // 0
            Console.WriteLine(ContaAparicoes("BBBBBBBBB", "BB")); // 4
        }
    }
}

