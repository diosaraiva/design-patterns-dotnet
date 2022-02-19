public class Finalizado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos FINALIZADOS não recebem desconto extra.");
    }
}