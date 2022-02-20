public class NotaFiscalDao : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine("Salvo no BD.");
    }
}