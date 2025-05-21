class FuncionarioAssalariado : Ipagavel
{
    public string Nome { get; set; }
    public int SalarioMensal { get; set; }

    public FuncionarioAssalariado(string nome, int salariomensal) {
        Nome = nome;
        SalarioMensal = salariomensal;
    }
    public double CalcularPagamento() => SalarioMensal;
    public override string ToString()
    {
        return $"Nome: {Nome}, Salario: {CalcularPagamento():F2}";
    }
}