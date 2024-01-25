namespace ExerciciosPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario1.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario2.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O salário médio é: { Funcionario.MediaSalario(funcionario1.Salario, funcionario2.Salario)}");

            Console.ReadKey();
        }
    }
}
