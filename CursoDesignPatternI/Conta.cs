public class Conta
{
    public String Titular { get; private set; }
    public double Saldo { get; set; }
    public int Numero { get; private set; }
    public String Agencia { get; private set; }
    public DateTime DataAbertura { get; private set; }

    public IEstadoConta Estado;

    public void Saca(double valor) 
    {
        Estado.Saca(this, valor);
    }

    public void Deposita(double valor) 
    {
        Estado.Deposita(this, valor);
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