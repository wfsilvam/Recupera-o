namespace ConversaoMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir taxas de câmbio (cotação fictícia ou atualizada)
            decimal taxaDolar = 5.00m;
            decimal taxaEuro = 5.50m;
            decimal taxaIene = 0.04m;
            decimal taxaLibra = 6.50m;

            // Criar dicionário de moedas
            var moedas = new Dictionary<Moedas, Moeda>
            {
                { Moedas.Real, new Moeda("Real", "Brasil", 1.00m, "Moeda Brasileira", "pt-BR") },
                { Moedas.Dolar, new Moeda("Dólar", "Estados Unidos", taxaDolar, "Moeda Norte Americana", "en-US") },
                { Moedas.Euro, new Moeda("Euro", "Europa", taxaEuro, "Moeda Europeia", "fr-FR") },
                { Moedas.Iene, new Moeda("Iene", "Japão", taxaIene, "Moeda Japonesa", "ja-JP") },
                { Moedas.LibraEsterlina, new Moeda("Libra Esterlina", "Reino Unido", taxaLibra, "Moeda do Reino Unido", "en-GB") },
            };

            // Solicitar valor em Reais ao usuário
            Console.Write("Digite o valor em Reais (R$): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorEmReais))
            {
                // Exibir menu de seleção de moeda
                Console.WriteLine("Selecione a moeda para conversão:");
                foreach (Moedas moeda in Enum.GetValues(typeof(Moedas)))
                {
                    Console.WriteLine($"{(int)moeda} - {moedas[moeda].Nome}");
                }

                if (int.TryParse(Console.ReadLine(), out int opcao) && Enum.IsDefined(typeof(Moedas), opcao))
                {
                    Moedas moedaSelecionada = (Moedas)opcao;
                    Moeda moeda = moedas[moedaSelecionada];

                    decimal valorConvertido = moeda.ConverterDeReais(valorEmReais);

                    Console.WriteLine($"\nValor em {moeda.Nome}: {valorConvertido.ToString("C", moeda.Cultura)}");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico.");
            }
        }
    }
}

