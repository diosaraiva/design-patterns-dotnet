﻿public class IKCV : TemplateDeImpostoCondicional 
{      
    public IKCV(Imposto outroImposto) : base(outroImposto) { }
    public IKCV() : base() { }

    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) 
    {
        return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
    }
    public override double MaximaTaxacao(Orcamento orcamento) 
    { 
        return orcamento.Valor * 0.10;  
    }
    public override double MinimaTaxacao(Orcamento orcamento) 
    {
        return orcamento.Valor * 0.06;
    }

    private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento) 
    {
        foreach(Item item in orcamento.Itens) 
        {
            if(item.Valor > 100) return true;
        }
        return false;
    }
}