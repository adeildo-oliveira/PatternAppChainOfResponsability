using System.Collections.Generic;

namespace PatternAppChainOfResponsibility.PatternDescontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item) => Itens.Add(item);

        public bool ExisteVendaCasada()
        {
            var resultado = false;

            Itens.ForEach(x => 
            {
                if ("Lapis".ToUpper().Equals(x.Nome))
                    resultado = true;

                if ("Caneta".ToUpper().Equals(x.Nome))
                    resultado = true;
            });

            return resultado;
        }
    }
}
