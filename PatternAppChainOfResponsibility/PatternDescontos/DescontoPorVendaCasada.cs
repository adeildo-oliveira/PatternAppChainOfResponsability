using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAppChainOfResponsibility.PatternDescontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.ExisteVendaCasada())
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconta(orcamento);
        }
    }
}
