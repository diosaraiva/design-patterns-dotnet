public class Negativo : IEstadoConta 
{
    public void Saca(Conta conta, double valor) 
    {
        throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
    }

    public void Deposita(Conta conta, double valor) 
    {
        conta.Saldo += valor * 0.95;
        if(conta.Saldo > 0) conta.Estado = new Positivo();
    }  
}