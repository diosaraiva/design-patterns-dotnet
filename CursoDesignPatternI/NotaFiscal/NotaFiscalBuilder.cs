public class NotaFiscalBuilder
{
    public String RazaoSocial { get; private set; }
    public String Cnpj { get; private set; }
    public String Observacoes { get; private set; }
    public DateTime Data { get; private set; }
    private double valorTotal;
    private double impostos;
    private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
    private IList<IAcaoAposGerarNota> acoesAposExecutarNota = new List<IAcaoAposGerarNota>();
    public NotaFiscalBuilder()
    {
        this.Data = DateTime.Now;
    }
    public NotaFiscal Constroi()
    {
        NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

        foreach(IAcaoAposGerarNota acaoAposGerarNota in acoesAposExecutarNota)
        {
            acaoAposGerarNota.Executa(nf);
        }

        return nf;
    }
    public void AdicionarAcao(IAcaoAposGerarNota novaAcao)
    {
        this.acoesAposExecutarNota.Add(novaAcao);
    }
    public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
    {
        this.RazaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComObservacoes(String observacoes)
    {
        this.Observacoes = observacoes;
        return this;
    }
    public NotaFiscalBuilder NaData(DateTime data)
    {
        this.Data = data;
        return this;
    }
    public NotaFiscalBuilder ComCnpj(String cnpj)
    {
        this.Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item)
    {
        todosItens.Add(item);
        valorTotal += item.Valor;
        impostos += item.Valor * 0.05;
        return this;
    }
    public NotaFiscalBuilder ComObservacao(String observacao)
    {
        this.Observacoes = observacao;
        return this;
    }
}