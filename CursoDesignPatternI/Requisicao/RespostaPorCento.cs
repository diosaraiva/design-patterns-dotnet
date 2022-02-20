public class RespostaPorCento : IResposta 
{
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta) 
    {
        if(req.Formato == Formato.PORCENTO) 
        {
            Console.WriteLine(conta.Titular + '%' + conta.Saldo + '%');
        }
        else if(OutraResposta != null)
        {
            OutraResposta.Responde(req, conta);
        } 
        else 
        {
            // não existe próxima na corrente, e ninguém atendeu a requisição!
            // poderíamos não ter feito nada aqui, caso não fosse necessário!
            throw new Exception("Formato de resposta não encontrado");
        }
    }
}