public class Orcamento
{
    public IEstadoOrcamento EstadoAtual { get; set; }

    public double Valor { get; set; }

    public IList<Item> Itens { get; private set; }
    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Itens = new List<Item>();
        this.EstadoAtual = new EmAprovacao();
    }

    public void AdicionaItem(Item item)
    {
        Itens.Add(item);
    }

    private bool Existe(String nomeDoItem, Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
        {
            if (item.Nome.Equals(nomeDoItem))
                return true;
        }
        return false;
    }

    public void AplicaDescontoExtra()
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova(Orcamento orcamento)
    {
        EstadoAtual.Aprova(this);
    }

    public void Reprova(Orcamento orcamento)
    {
        EstadoAtual.Reprova(this);
    }

    public void Finaliza(Orcamento orcamento)
    {
        EstadoAtual.Finaliza(this);
    }
}