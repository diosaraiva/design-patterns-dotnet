public class Reprovado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos REPROVADOS não recebem desconto extra.");
    }
    public void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("Orçamento EM APROVAÇÃO não pode ser FINALIZADO diretamente.");
    }
}