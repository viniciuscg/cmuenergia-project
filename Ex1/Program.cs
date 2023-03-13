using System.Globalization;
using System.Linq;
using System.Text;

namespace exercicio1
{
    public class Program
    {
        public static List<string> RetornaTerminadasEmA(List<string> array)
        {
            if (array == null)
            {
                return new List<string>();
            }
            return array.FindAll(item => item != null && new string(item.Normalize(NormalizationForm.FormD)
                                                                        .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                                                                        .ToArray()).EndsWith("a", true, null ));
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            Console.WriteLine("resultado1");
            RetornaTerminadasEmA(new List<string> {"Pera", "Maçã", "Banana", "Uva", "Abacate"}).ForEach(Console.WriteLine); // new List<string> {"Pera", "Banana", "Uva"}
            Console.WriteLine("resultado2");
            RetornaTerminadasEmA(new List<string> {"BANANA", "AZEITE", "Sacola", "MERCADO"}).ForEach(Console.WriteLine); // new List<string> {"BANANA", "Sacola"}
            Console.WriteLine("resultado3");
            RetornaTerminadasEmA(new List<string> {}).ForEach(Console.WriteLine); // new List<string> {}
        }
    }
}

