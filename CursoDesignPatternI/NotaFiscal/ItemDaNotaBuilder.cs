public class ItemDaNotaBuilder
{
    public String Nome { get; private set; }
    public double Valor { get; private set; }

    public ItemDaNota Constroi()
    {
        return new ItemDaNota(Nome,Valor);
    }
    public ItemDaNotaBuilder ComNome(String nome)
    {
        this.Nome = nome;
        return this;
    }

    public ItemDaNotaBuilder ComValor(double valor)
    {
        this.Valor = valor;
        return this;
    }
}