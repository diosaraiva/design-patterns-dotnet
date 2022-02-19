public class Conta
{
    public String Nome { get; private set; }
    public double Saldo { get; private set; }
    public int Numero { get; private set; }
    public String Agencia { get; private set; }
    public void Deposita(double valor)
    {
        this.Saldo += valor;
    }

    public Conta(String nome, double saldo, int numero, String agencia) 
    {
        this.Nome = nome;
        this.Saldo = saldo;
        this.Numero = numero;
        this.Agencia = agencia;
    }
}