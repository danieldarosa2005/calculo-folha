class Program {
    public static void Main(string[] Args)
    {

        List<Ipagavel> ip = new List<Ipagavel> {

        new FuncionarioAssalariado("João", 3000),
        new FuncionarioHorista("Maria", 50, 160),
        new FuncionarioComissionado("Carlos", 2000, 10000, 0.05),
        new FuncionarioHorista("Ana", 60, 100)};

        foreach (var item in ip)
        {
            System.Console.WriteLine(item);
        }
        double total = ip.Sum(p => p.CalcularPagamento());
        System.Console.WriteLine($"Custo total da folha: R${total:F2}");
    }
 }