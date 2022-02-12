//Template Method
public abstract class TemplateDeImpostoCondicional : IImposto 
{
    public double Calcula(Orcamento orcamento) 
    {     
        if(DeveUsarMaximaTaxacao(orcamento)) 
        {
            return MaximaTaxacao(orcamento);
        }
        else
        {
            return MinimaTaxacao(orcamento);
        }  
    }     
    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
    public abstract double MinimaTaxacao(Orcamento orcamento); 
}