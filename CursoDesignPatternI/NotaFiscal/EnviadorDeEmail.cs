public class EnviadorDeEmail : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine("Envio por e-mail.");
    }
}