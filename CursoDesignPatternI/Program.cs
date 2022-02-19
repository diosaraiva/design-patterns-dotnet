public class Program
{
    static void Main(String[] args)
    {
        Orcamento orcamento = new Orcamento(500.0);
        orcamento.AdicionaItem(new Item("CANETA", 250.0));
        orcamento.AdicionaItem(new Item("LAPIS", 250.0));

        // IMPOSTOS
        Imposto iss = new ISS(new ICMS(new ICCC()));
        Imposto icms = new ICMS();
        Imposto iccc = new ICCC();
        CalculadorDeImpostos calculadorImpostos = new CalculadorDeImpostos();
        calculadorImpostos.RealizaCalculo(orcamento, iss);
        calculadorImpostos.RealizaCalculo(orcamento, icms);
        calculadorImpostos.RealizaCalculo(orcamento, iccc);

        // DESCONTOS
        CalculadorDeDesconto calculadorDescontos = new CalculadorDeDesconto();
        double desconto = calculadorDescontos.Calcula(orcamento);

        Console.WriteLine(desconto);
    }
}