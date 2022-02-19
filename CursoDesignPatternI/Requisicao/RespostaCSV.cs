public class RespostaCSV : IResposta 
{
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta) 
    {
        if(req.Formato == Formato.CSV) 
        {
            Console.WriteLine(conta.Nome + ";" + conta.Saldo);
        }
        else 
        {
            OutraResposta.Responde(req, conta);
        }
    }
}