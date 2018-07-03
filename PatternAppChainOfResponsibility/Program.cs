using PatternAppChainOfResponsibility.PatternDescontos;
using System;

namespace PatternAppChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            var desconto = new CalcularDescontos().CalculaDesconto(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
