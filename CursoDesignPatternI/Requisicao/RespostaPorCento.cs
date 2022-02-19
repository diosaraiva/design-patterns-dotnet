public class RespostaEmPorcento : IResposta
{
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta)
    {
        if (req.Formato == Formato.PORCENTO)
        {
            Console.WriteLine(conta.Titular + "%" + conta.Saldo);
        }
        else
        {
            OutraResposta.Responde(req, conta);
        }
    }
}