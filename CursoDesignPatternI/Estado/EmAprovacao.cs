public class EmAprovacao : IEstadoOrcamento 
{ 
    private bool descontoAplicado = false;
    public void AplicaDescontoExtra(Orcamento orcamento) 
    {
        if(!descontoAplicado) 
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
            descontoAplicado = true;
        }
        else 
        {
            throw new Exception("Desconto já aplicado!");
        }
    }

    public void Aprova(Orcamento orcamento)
    {
        // desse estado posso ir para o estado de aprovado
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Reprova(Orcamento orcamento)
    {
        // desse estado posso ir para o estado de reprovado tambem
        orcamento.EstadoAtual = new Reprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        // daqui não posso ir direto para finalizado
        throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
    }
}