
using System.Text.Json;

namespace exercicio8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var frota1 = new Frota
            {
                Veiculos = new List<Veiculo>
                {
                    new Veiculo
                    {
                        Id = 1,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Ford Transit",
                        Ano = 2008,
                        KmRodados = 97080,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 2,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Citroën Jumper",
                        Ano = 2008,
                        KmRodados = 95000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 3,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Citroën Jumper",
                        Ano = 2012,
                        KmRodados = 17000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 4,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Citroën Jumper",
                        Ano = 2023,
                        KmRodados = 0000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 5,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Fiat Ducato",
                        Ano = 2006,
                        KmRodados = 15000,
                        QtdPortasSimples = 4,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 6,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Fiat Palio",
                        Ano = 2009,
                        KmRodados = 15000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 7,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Fiat Palio",
                        Ano = 2009,
                        KmRodados = 25000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 8,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Ford Ká",
                        Ano = 2015,
                        KmRodados = 76560,
                        QtdPortasSimples = 4,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 9,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Chevrolet Onix",
                        Ano = 2010,
                        KmRodados = 15000,
                        QtdPortasSimples = 4,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 10,
                        Tipo = TipoVeiculo.Moto,
                        Nome = "Yamaha Flup",
                        Ano = 2023,
                        KmRodados = 0000,
                        QtdPortasSimples = 0,
                        QtdPortasCorrer = 0,
                    },
                }
            };
            var frota2 = new Frota
            {
                Veiculos = new List<Veiculo>
                {
                    new Veiculo
                    {
                        Id = 11,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Ford Transit",
                        Ano = 2018,
                        KmRodados = 65000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 12,
                        Tipo = TipoVeiculo.Van,
                        Nome = "Fiat Ducato",
                        Ano = 2007,
                        KmRodados = 15400,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 1,
                    },
                    new Veiculo
                    {
                        Id = 13,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Fiat Palio",
                        Ano = 2019,
                        KmRodados = 35000,
                        QtdPortasSimples = 2,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 14,
                        Tipo = TipoVeiculo.Carro,
                        Nome = "Chevrolet Onix",
                        Ano = 2012,
                        KmRodados = 65000,
                        QtdPortasSimples = 4,
                        QtdPortasCorrer = 0,
                    },

                    new Veiculo
                    {
                        Id = 15,
                        Tipo = TipoVeiculo.Moto,
                        Nome = "Yamaha Flup",
                        Ano = 2023,
                        KmRodados = 0000,
                        QtdPortasSimples = 0,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 16,
                        Tipo = TipoVeiculo.Moto,
                        Nome = "Yamaha Flup",
                        Ano = 2023,
                        KmRodados = 10000,
                        QtdPortasSimples = 0,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 17,
                        Tipo = TipoVeiculo.Moto,
                        Nome = "Yamaha Flup",
                        Ano = 2022,
                        KmRodados = 5500,
                        QtdPortasSimples = 0,
                        QtdPortasCorrer = 0,
                    },
                    new Veiculo
                    {
                        Id = 18,
                        Tipo = TipoVeiculo.Moto,
                        Nome = "Honda CB300",
                        Ano = 2023,
                        KmRodados = 0000,
                        QtdPortasSimples = 0,
                        QtdPortasCorrer = 0,
                    },
                }
            };
            var veiculos = new List<Veiculo>();
            veiculos.AddRange(frota1.Veiculos);
            veiculos.AddRange(frota2.Veiculos);
            var frotas = new List<Frota>();
            frotas.Add(frota1);
            frotas.Add(frota2);

            // - **a) A quantidade de veículos da frota 1.** Resposta: 10

            Console.WriteLine(frota1.Veiculos.Count);

            // - **b) A quantidade de carros com 4 portas na empresa.** Resposta: 3

            Console.WriteLine(RetornarQtdQuatroPortas(veiculos));

            // - **c) O total de lugares (capacidade) disponíveis da frota 1.** Resposta: 82    

            Console.WriteLine(RetornarCapacidadeDisponivelFrota(frota1));

            // - **d) A média de quilômetros rodados de todos os veículos da frota 2.** Resposta: 24.487,5

            Console.WriteLine(frota2.Veiculos.Average(x => x.KmRodados));

            // - **e) O(s) veículo(s) mais novo(s) da frota 1 (retornar em forma de lista, pois pode haver mais de um).** Resposta: Veiculo 4 e Veiculo 10

            Console.WriteLine(JsonSerializer.Serialize(RetornarVeiculosMaisNovosFrota(frota1)));

            // - **f) O(s) veículo(s) mais rodado(s) da frota 2 (retornar em forma de lista, pois pode haver mais de um).** Resposta: Veiculo 11 e Veiculo 14

            Console.WriteLine(JsonSerializer.Serialize(RetornarVeiculosMaisRodadosFrota(frota2)));

            // - **g) O(s) veículo(s) mais antigo(s) da empresa (retornar em forma de lista, pois pode haver mais de um).** Resposta: Veiculo 5

            Console.WriteLine(JsonSerializer.Serialize(RetornarVeiculosMaisAntigos(veiculos)));


            // - **h) A(s) frota(s) com a maior quantidade de vans (retornar em forma de lista, pois pode haver mais de um)** Resposta: Frota 1

            IEnumerable<Frota> frotasMaiorQtdVans = RetornarFrotasMaiorQtdVans(frotas);
            Console.WriteLine(JsonSerializer.Serialize(frotasMaiorQtdVans));

        }

        //QUESTÃO H
        private static IEnumerable<Frota> RetornarFrotasMaiorQtdVans(List<Frota> frotas)
        {
            var maiorQtdVans = 0;
            foreach (var frota in frotas)
            {
                var qtdVans = frota.Veiculos.Where(x => x.Tipo == TipoVeiculo.Van).Count();
                if (qtdVans > maiorQtdVans)
                {
                    maiorQtdVans = qtdVans;
                }
            }
            var frotasMaiorQtdVans = frotas.Where(x => x.Veiculos.Where(x => x.Tipo == TipoVeiculo.Van).Count() == maiorQtdVans);
            return frotasMaiorQtdVans;
        }

        //QUESTÃO G
        private static IEnumerable<Veiculo> RetornarVeiculosMaisAntigos(List<Veiculo> veiculos)
        {
            var anoMaisAntigo = veiculos.OrderBy(x => x.Ano).First().Ano;
            var veiculosMaisAntigos = veiculos.Where(x => x.Ano == anoMaisAntigo);
            return veiculosMaisAntigos;
        }

        //QUESTÃO F
        private static IEnumerable<Veiculo> RetornarVeiculosMaisRodadosFrota(Frota frota2)
        {
            var maiorKilometragemFrota2 = frota2.Veiculos.OrderByDescending(x => x.KmRodados).First().KmRodados;
            var veiculosMaisRodadosFrota2 = frota2.Veiculos.Where(x => x.KmRodados == maiorKilometragemFrota2);
            return veiculosMaisRodadosFrota2;
        }

        //QUESTÃO E
        private static IEnumerable<Veiculo> RetornarVeiculosMaisNovosFrota(Frota frota1)
        {
            var anoMaisNovoFrota1 = frota1.Veiculos.OrderByDescending(x => x.Ano).First().Ano;
            var veiculosMaisNovosFrota1 = frota1.Veiculos.Where(x => x.Ano == anoMaisNovoFrota1);
            return veiculosMaisNovosFrota1;
        }

        //QUESTÃO C
        private static int RetornarCapacidadeDisponivelFrota(Frota frota1)
        {
            var capacidadeFrota1 = 0;
            foreach (var veiculo in frota1.Veiculos)
            {
                switch (veiculo.Tipo)
                {
                    case TipoVeiculo.Van: capacidadeFrota1 += 12; break;
                    case TipoVeiculo.Carro: capacidadeFrota1 += 5; break;
                    case TipoVeiculo.Moto: capacidadeFrota1 += 2; break;
                    default: break;
                }
            }

            return capacidadeFrota1;
        }

        //QUESTÃO B 
        private static int RetornarQtdQuatroPortas(List<Veiculo> veiculos)
        {
            return veiculos.Where(x => x.QtdPortasSimples == 4 && x.Tipo == TipoVeiculo.Carro).Count();
        }
    }
}

