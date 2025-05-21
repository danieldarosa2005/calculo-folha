class FuncionarioComissionado : Ipagavel
{
    public string Nome { get; set; }
    public double SalarioBase { get; set; }
    public double Vendas { get; set; }
    public double Comissao { get; set; }
    public FuncionarioComissionado(string nome, double salarioBase, double vendas, double comissao)
    {
        Nome = nome;
        SalarioBase = salarioBase;
        Vendas = vendas;
        Comissao = comissao;
    }
    public double CalcularPagamento()
    {
        return SalarioBase + (Comissao * Vendas);
    }
    public override string ToString()
    {
        return $"Nome: {Nome}, Salario: {CalcularPagamento():F2}";
    }
}