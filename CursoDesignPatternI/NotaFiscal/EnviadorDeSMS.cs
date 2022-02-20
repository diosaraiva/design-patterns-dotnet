public class EnviadorDeSMS : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine("Envio por SMS.");
    }
}