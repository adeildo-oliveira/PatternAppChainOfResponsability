namespace PatternAppChainOfResponsibility.PatternDescontos
{
    public class CalcularDescontos
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            var desconto1 = new DescontoPorCintoItens();
            var desconto2 = new DescontoPorMaisDeQuinhentosReais();
            var desconto3 = new DescontoPorVendaCasada();
            var desconto4 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;
            desconto3.Proximo = desconto4;

            return desconto1.Desconta(orcamento);
        }
    }
}
