using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoMoedas;

    public class Moeda
    {
            public string Nome { get; set; }
            public string Origem { get; set; }
            public decimal ValorEmReais { get; set; }
            public string Descricao { get; set; }
            public CultureInfo Cultura { get; set; }

            public Moeda(string nome, string origem, decimal valorEmReais, string descricao, string cultura)
            {
                Nome = nome;
                Origem = origem;
                ValorEmReais = valorEmReais;
                Descricao = descricao;
                Cultura = new CultureInfo(cultura);
            }

            public decimal ConverterDeReais(decimal valorEmReais)
            {
                return valorEmReais / ValorEmReais;
            }

            public override string ToString()
            {
                return $"{Nome} ({Descricao}) - {Origem}";
            }
     }
  

