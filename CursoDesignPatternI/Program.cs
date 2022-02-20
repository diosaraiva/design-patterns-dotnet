public class Program
{
    static void Main(String[] args)
    {
        Orcamento orcamento = new Orcamento(500.0);
        orcamento.AdicionaItem(new Item("CANETA", 250.0));
        orcamento.AdicionaItem(new Item("LAPIS", 250.0));
        orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
        orcamento.AdicionaItem(new Item("REGUA", 250.0));
        orcamento.AdicionaItem(new Item("CADERNO", 250.0));
        orcamento.AdicionaItem(new Item("LIVRO", 250.0));

        // IMPOSTOS: Strategy, Template Method, Decorator
        Imposto iss = new ISS(new ICMS(new ICCC()));
        Imposto icms = new ICMS();
        Imposto iccc = new ICCC();
        CalculadorDeImpostos calculadorImpostos = new CalculadorDeImpostos();
        calculadorImpostos.RealizaCalculo(orcamento, iss);
        calculadorImpostos.RealizaCalculo(orcamento, icms);
        calculadorImpostos.RealizaCalculo(orcamento, iccc);

        // DESCONTOS: Chain of Responsibility
        CalculadorDeDesconto calculadorDescontos = new CalculadorDeDesconto();
        double desconto = calculadorDescontos.Calcula(orcamento);
        Console.WriteLine(desconto);

        // REQUISICAO: Chain of Responsibility
        Conta conta = new Conta("Diogo", 007, 500.00, new DateTime(), "MI-6");

        RespostaXml xml = new RespostaXml();
        xml.Responde(new Requisicao(Formato.XML), conta);

        RespostaCsv csv = new RespostaCsv();
        csv.Responde(new Requisicao(Formato.CSV), conta);

        RespostaPorCento porCento = new RespostaPorCento();
        porCento.Responde(new Requisicao(Formato.PORCENTO), conta);

        // ESTADO: State
        orcamento = new Orcamento(500.0);
        orcamento.AplicaDescontoExtra();
        Console.WriteLine(orcamento.Valor); // imprime 475,00 pois descontou 5%
        orcamento.Aprova(); // aprova nota!

        orcamento.AplicaDescontoExtra();
        Console.WriteLine(orcamento.Valor); // imprime 465,50 pois descontou 2%

        //reforma.AplicaDescontoExtra(); //lança excecao, pois não pode dar desconto nesse estado
        //reforma.Aprova(); //lança exceção, pois não pode ir para aprovado
        orcamento.Finaliza();

        // NOTA FISCAL: Builder
        CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
        criador.ParaEmpresa("Para Empresa");
        criador.ComCnpj("23.456.789/0001-10");

        /* IList<ItemDaNota> itens = new List<ItemDaNota>();
           double valorTotal = 0;
           foreach(ItemDaNota item in itens)
           {
               valorTotal += item.Valor;
           }
           double impostos = valorTotal * 0.05;
           NotaFiscal nf = new NotaFiscal("razao","cnpj",DateTime.Now,valorTotal, impostos, itens, ""); */

    }
}