using System.Linq;

namespace exercicio6
{
    public class Program
    {
        public static List<List<int>> QuebraLista(List<int> array, int divisor)
        {
            var resultado = new List<List<int>>();
            if (array == null) 
            {
                return resultado;
            }
            decimal iteracoes = array.Count/(decimal)divisor;
            if (iteracoes < 1) 
            {
                resultado.Add(array);
            } 
            for (int i = 0; i < Math.Truncate(iteracoes); i++)
            {
                if ((iteracoes % 1) > 0 && Math.Truncate(iteracoes) == (i + 1)) 
                {
                    resultado.Add(array.Skip(i * divisor).ToList());
                }
                else 
                {
                    resultado.Add(array.Skip(i * divisor).Take(divisor).ToList());
                }
            }
            return resultado;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            
            QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}}
            QuebraLista(null, 4); // new List<int>{}
            QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}, new List<int>{10}}
            QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 4); // new List<List<int>>{new List<int>{2, 4, 6, 8}, new List<int>{10, 12, 14, 16}}
            QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 40); // new List<List<int>>{new List<int>{2, 4, 6, 8, 10, 12, 14, 16}}
            QuebraLista(new List<int>{}, 4); // new List<int>{}
        }
    }
}

