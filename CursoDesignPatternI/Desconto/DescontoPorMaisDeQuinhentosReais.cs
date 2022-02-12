public class DescontoPorMaisDeQuinhentosReais : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        if (orcamento.Valor > 500)
        {
            return orcamento.Valor * 0.07;
        }
        else
        {
            return Proximo.Desconta(orcamento);
        }
    }
}