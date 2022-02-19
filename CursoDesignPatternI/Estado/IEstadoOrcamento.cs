public interface IEstadoOrcamento
{
    void AplicaDescontoExtra(Orcamento orcamento);

    public void Aprova(Orcamento orcamento);
    public void Reprova(Orcamento orcamento);
    public void Finaliza(Orcamento orcamento);
}
