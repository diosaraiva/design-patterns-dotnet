public class RealizadorDeInvestimentos
{
    public void Realiza(Conta conta, IInvestimento investimento)
    {
        double resultado = investimento.Calcula(conta);
        conta.Deposita(resultado * 0.75);
        Console.WriteLine("Novo saldo: " + conta.Saldo);
    }
}