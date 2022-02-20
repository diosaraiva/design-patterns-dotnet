public class CriadorDeNotaFiscal
{
    public String RazaoSocial { get; private set; }
    public String Cnpj { get; private set; }
    public String Observacoes { get; private set; }
    public DateTime Data { get; private set; }
    private double valorTotal;
    private double impostos;
    private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

    public void ParaEmpresa(String razaoSocial)
    {
        this.RazaoSocial = razaoSocial;
    }

    public void ComObservacoes(String observacoes)
    {
        this.Observacoes = observacoes;
    }
    public void NaDataAtual()
    {
        this.Data = DateTime.Now;
    }
    public void ComCnpj(String cnpj)
    {
        this.Cnpj = cnpj;
    }

    public void ComItem(ItemDaNota item)
    {
        todosItens.Add(item);
        valorTotal += item.Valor;
        impostos += item.Valor * 0.05;
    }
    public void ComObservacao(String observacao)
    {
        this.Observacoes = observacao;
    }
}