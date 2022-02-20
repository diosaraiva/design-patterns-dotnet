public class ItemDaNota
{
    public String Nome { get; private set; }
    public double Valor { get; private set; }

    public ItemDaNota(String nome, double valor)
    {
        this.Nome = nome;
        this.Valor = valor;
    }
}