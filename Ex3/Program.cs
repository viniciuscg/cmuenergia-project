using System.Text.RegularExpressions;
namespace exercicio3
{
    public class Program
    {
        public static string ContaDias(string data1, string data2)
        {
            if ( (data1 == null || data1 == "") || (data2 == null || data2 == "")) return "ERROR";
            Regex validateDate = new Regex("^(?:\\d{4})-(?:\\d{2})-(?:\\d{2})");
            DateTime date1 = Convert.ToDateTime(data1);
            DateTime date2 = Convert.ToDateTime(data2);

            if (validateDate.IsMatch(data2) && validateDate.IsMatch(data1)) 
            {         
                if (date1 > date2)
                {
                    return ((date1.Date - date2.Date).Days).ToString();
                }
                if (date2 > date1)
                {
                    return ((date2.Date - date1.Date).Days).ToString();
                }
                return "0";
            } else return "ERRO";
            
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            Console.WriteLine(ContaDias("2023-02-01", null)); // ERRO
            Console.WriteLine(ContaDias("2023-02-01", "2023-02-15")); // 14
            Console.WriteLine(ContaDias("2023-02-01", "2022-02-01")); // 365
            Console.WriteLine(ContaDias("2022-02-01", "2023-02-01")); // 365
            Console.WriteLine(ContaDias("2023-02-01", "2023-02-01")); // 0
            Console.WriteLine(ContaDias("2023-02-01", "2023/02/01")); // ERRO
            Console.WriteLine(ContaDias("2023-02-01", "2023.02.01")); // ERRO
        }
    }
}

