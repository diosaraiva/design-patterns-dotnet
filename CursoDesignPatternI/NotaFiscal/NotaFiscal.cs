public class NotaFiscal
{
    public String RazaoSocial { get; set; }
    public String Cnpj { get; set; }
    public DateTime DataDeEmissao { get; set; }
    public double ValorBruto { get; set; }
    public double Impostos { get; set; }
    public IList<ItemDaNota> Itens { get; set; }
    public String Observacoes { get; set; }

    public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, String observacoes)
    {
        this.RazaoSocial = razaoSocial;
        this.Cnpj = cnpj;
        this.DataDeEmissao = dataDeEmissao;
        this.ValorBruto = valorBruto;
        this.Impostos = impostos;
        this.Itens = itens;
        this.Observacoes = observacoes;
    }
}