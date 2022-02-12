public class Orcamento
{
    public double Valor { get; private set; }

    public IList<Item> Itens { get; private set; }
    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Itens = new List<Item>();
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
}