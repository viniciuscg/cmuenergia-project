using System.Linq;

namespace exercicio4
{

    public class Usuario
    {
        public string Email { get; }
        public string Nome { get; }
        public string Senha { get; }

        public Usuario(string email, string nome)
        {
            this.Email = email;
            this.Nome = nome;
            this.Senha = Guid.NewGuid().ToString();
        }
    }
    public class Program
    {
        public static List<Usuario> IdentificaDuplicados(List<Usuario> array)
        {
            if (array == null) 
            {
                throw new NullReferenceException("ERRO");
            }
            var agrupar = array.GroupBy(u => u.Email);
            List<Usuario> repetido = new List<Usuario>();
            foreach (var grupo in agrupar)
            {
                if (grupo.Count() > 1) 
                {
                    repetido.AddRange(grupo.ToList());
                }
            }
            return repetido.ToList();
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto(s) retornados!
            try
            {
                var qualquer = IdentificaDuplicados(new List<Usuario> {
                    new Usuario("jc@cmu.com.br", "João Carlos"),
                    new Usuario("ana@cmu.com.br", "Ana Maria"),
                    new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                    new Usuario("joaozin@cmu.com.br", "João Marcelo"),
                    new Usuario("jc@cmu.com.br", "João Carlos"),
                    }); // new List<Usuario> {}
                foreach (var item in qualquer)
                {
                    Console.WriteLine(item.Email);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
              var qualquer = IdentificaDuplicados(new List<Usuario> {
                    new Usuario("joaozin@cmu.com.br", "João Carlos"),
                    new Usuario("ana@cmu.com.br", "Ana Maria"),
                    new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                    new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"João Carlos"}, Usuario{"João Marcelo"}}
                foreach (var item in qualquer)
                {
                    Console.WriteLine(item.Email);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
            var qualquer = IdentificaDuplicados(new List<Usuario> {}); // new List<Usuario> {}
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
            var qualquer = IdentificaDuplicados(null); // ERRO
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}