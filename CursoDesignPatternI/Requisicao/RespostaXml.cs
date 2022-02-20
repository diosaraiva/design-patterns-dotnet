public class RespostaXml : IResposta
{
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta)
    {
        if (req.Formato == Formato.XML)
        {
            Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
        }
        else
        {
            OutraResposta.Responde(req, conta);
        }
    }
}