class FuncionarioHorista : Ipagavel
{
    public string Nome { get; set; }
    public int Horas { get; set; }
    public int ValorHora { get; set; }
    public FuncionarioHorista(string nome, int horas, int valorHora)
    {
        Nome = nome;
        Horas = horas;
        ValorHora = valorHora;
    }
    public double CalcularPagamento()
    {
        return Horas * ValorHora;
    }
    public override string ToString()
    {
        return $"Nome: {Nome}, Salario: {CalcularPagamento():F2}";
    }
}