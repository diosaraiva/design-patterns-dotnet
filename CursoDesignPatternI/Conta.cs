public class Conta
{
    public String Titular { get; private set; }
    public double Saldo { get; private set; }
    public int Numero { get; private set; }
    public String Agencia { get; private set; }
    public DateTime DataAbertura { get; private set; }

    public void Deposita(double valor)
    {
        this.Saldo += valor;
    }

    public Conta(String titular, int numero, double saldo, DateTime dataAbertura, String agencia) 
    {
        this.Titular = titular;
        this.Numero = numero;
        this.Saldo = saldo;
        this.Agencia = agencia;
        this.DataAbertura = dataAbertura;
    }
}