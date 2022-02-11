public class Program
{
    static void Main(String[] args)
    {
        Orcamento orcamento = new Orcamento(500.0);

        // IMPOSTOS
        IImposto iss = new ISS();
        IImposto icms = new ICMS();
        IImposto iccc = new ICCC();

        CalculadorDeImpostos calculadorImpostos = new CalculadorDeImpostos();

        // Calculando o ISS
        calculadorImpostos.RealizaCalculo(orcamento, iss);

        // Calculando o ICMS        
        calculadorImpostos.RealizaCalculo(orcamento, icms);

        // Calculando o ICCC        
        calculadorImpostos.RealizaCalculo(orcamento, iccc);

        // DESCONTOS
        CalculadorDeDesconto calculadorDescontos = new CalculadorDeDesconto();

        orcamento.AdicionaItem(new Item("CANETA", 250.0));
        orcamento.AdicionaItem(new Item("LAPIS", 250.0));

        double desconto = calculadorDescontos.Calcula(orcamento);

        Console.WriteLine(desconto);
    }
}