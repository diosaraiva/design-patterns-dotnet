﻿public class EmAprovacao : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
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