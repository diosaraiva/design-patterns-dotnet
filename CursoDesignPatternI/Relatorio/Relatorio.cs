public abstract class Relatorio
{
    protected abstract void Cabecalho();
    protected abstract void Rodape();
    protected abstract void Corpo(IList<Conta> contas);

    public void Imprime(IList<Conta> contas)
    {
        Cabecalho();
        Corpo(contas);
        Rodape();
    }
}