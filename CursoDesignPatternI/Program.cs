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

        Impostos(orcamento);

        Descontos(orcamento);

        Estado(orcamento);

        NotaFiscal();
    }

    /* 
    IMPOSTO: Strategy
    O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, 
    e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo,
    temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.
    O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, 
    e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes 
    desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo 
    rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das 
    implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga 
    trabalhar com N diferentes algoritmos sem precisar alterar o seu código.
    ---
    IMPOSTO: Template Method
    Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é 
    uma boa solução. Com ele, conseguimos definir, em um nível mais macro, a estrutura do 
    algoritmo e deixar "buracos", que serão implementados de maneira diferente por cada uma 
    das implementações específicas.
    Dessa forma, reutilizamos ao invés de repetirmos código, e facilitamos possíveis evoluções, 
    tanto do algoritmo em sua estrutura macro, quanto dos detalhes do algoritmo, já que cada 
    classe tem sua responsabilidade bem separada.
    ---
    IMPOSTO: Decorator
    Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos 
    de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que 
    podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição 
    desses comportamentos, bastando escolher no momento da instanciação, quais instancias serão 
    utilizadas para realizar o trabalho.
    */
    public static void Impostos(Orcamento orcamento)
    {
        Imposto iss = new ISS(new ICMS(new ICCC()));
        Imposto icms = new ICMS();
        Imposto iccc = new ICCC();
        CalculadorDeImpostos calculadorImpostos = new CalculadorDeImpostos();
        calculadorImpostos.RealizaCalculo(orcamento, iss);
        calculadorImpostos.RealizaCalculo(orcamento, icms);
        calculadorImpostos.RealizaCalculo(orcamento, iccc);
    }

    /*
    DESCONTO/REQUISICAO: Chain of Responsibility
    O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem 
    executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário 
    que deve ser validado, caso o anterior não satisfaça a condição.
    Nesses casos, o Chain of Responsibility nos possibilita a separação de responsabilidades em 
    classes pequenas e enxutas, e ainda provê uma maneira flexível e desacoplada de juntar esses 
    comportamentos novamente.
    */
    public static void Descontos(Orcamento orcamento)
    {
        CalculadorDeDesconto calculadorDescontos = new CalculadorDeDesconto();
        double desconto = calculadorDescontos.Calcula(orcamento);
        Console.WriteLine(desconto);
    }

    public static void Requisicao(Orcamento orcamento)
    {
        Conta conta = new Conta("Diogo", 007, 500.00, new DateTime(), "MI-6");

        RespostaXml xml = new RespostaXml();
        xml.Responde(new Requisicao(Formato.XML), conta);

        RespostaCsv csv = new RespostaCsv();
        csv.Responde(new Requisicao(Formato.CSV), conta);

        RespostaPorCento porCento = new RespostaPorCento();
        porCento.Responde(new Requisicao(Formato.PORCENTO), conta);
    }

    /*
    ESTADO: State
    A principal situação que faz emergir o Design Pattern State é a necessidade de implementação 
    de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e 
    complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o 
    controle dos estados simples e organizados através da criação de classes que representem 
    cada estado e saiba controlar as transições.
    */
    public static void Estado(Orcamento orcamento)
    {
        orcamento = new Orcamento(500.0);
        orcamento.AplicaDescontoExtra();
        Console.WriteLine(orcamento.Valor); // imprime 475,00 pois descontou 5%
        orcamento.Aprova(); // aprova nota!

        orcamento.AplicaDescontoExtra();
        Console.WriteLine(orcamento.Valor); // imprime 465,50 pois descontou 2%

        //reforma.AplicaDescontoExtra(); //lança excecao, pois não pode dar desconto nesse estado
        //reforma.Aprova(); //lança exceção, pois não pode ir para aprovado
        orcamento.Finaliza();
    }

    /*
    NOTA FISCAL: Builder com Method Chaining
    Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que 
    possui uma lógica de criação complicada, podemos esconder tudo isso em um Builder.
    Além de centralizar o código de criação e facilitar a manutenção, ainda facilitamos a vida 
    das classes que precisam criar essa classe complexa, afinal a interface do Builder tende a 
    ser mais clara e fácil de ser usada.
    */
    public static void NotaFiscal()
    {
        NotaFiscalBuilder criador = new NotaFiscalBuilder();

        criador
            .ParaEmpresa("PermaSys")
            .ComCnpj("23.456.789/0001-10")
            .ComItem(new ItemDaNota("item 1", 100.00))
            .ComItem(new ItemDaNota("item 2", 200.00))
            .ComObservacoes("Observações.");

        ItemDaNotaBuilder criadorItem = new ItemDaNotaBuilder().ComNome("item 3").ComValor(300.00);

        criador.ComItem(criadorItem.Constroi());

        /* 
        ACOES APÓS NOTA EXECUTADA: Observer
        Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações 
        diferentes a serem executadas após um determinado processo, podemos implementar o Observer.
        Ele permite que diversas ações sejam executadas de forma transparente à classe principal, 
        reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.
        */
        criador.AdicionarAcao(new EnviadorDeEmail());
        criador.AdicionarAcao(new EnviadorDeSMS());
        criador.AdicionarAcao(new NotaFiscalDao());
        criador.AdicionarAcao(new Multiplicador(2));
        criador.AdicionarAcao(new Multiplicador(3));
        criador.AdicionarAcao(new Multiplicador(5.5));

        NotaFiscal nf = criador.Constroi();

        Console.WriteLine(nf.RazaoSocial);
        Console.WriteLine(nf.Cnpj);
        foreach (ItemDaNota item in nf.Itens)
        {
            Console.WriteLine(item.Nome);
            Console.WriteLine(item.Valor);
        }
    }
}