public class SemDesconto : IDesconto
{
    public IDesconto Proximo { get; set; }

    public Double Desconta(Orcamento orcamento)
    {
        return 0;
    }
}