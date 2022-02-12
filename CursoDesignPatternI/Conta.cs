public class Conta
{
    public String Titular { get; private set; }
    public double Saldo { get; private set; }
    public void Deposita(double valor)
    {
        this.Saldo += valor;
    }

    public Conta(String titular, double saldo) 
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }
}