public class Reprovado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos REPROVADOS não recebem desconto extra.");
    }
}