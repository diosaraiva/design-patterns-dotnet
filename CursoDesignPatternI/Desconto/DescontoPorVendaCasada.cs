﻿public class DescontoPorVendaCasada : IDesconto
{
    public IDesconto Proximo { get; set; }
    public double Desconta(Orcamento orcamento)
    {
        if (AconteceuVendaCasadaEm(orcamento))
        {
            return orcamento.Valor * 0.05;
        }
        else return Proximo.Desconta(orcamento);
    }

    private bool AconteceuVendaCasadaEm(Orcamento orcamento)
    {
        return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
    }

    private bool Existe(String nomeDoItem, Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
        {
            if (item.Nome.Equals(nomeDoItem)) return true;
        }
        return false;
    }
}