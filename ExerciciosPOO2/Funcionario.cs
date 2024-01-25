using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO2
{
    internal class Funcionario
    {
        public String Nome;
        public double Salario;

        public static double MediaSalario(double Salario1, double Salario2)
        {
            return ((Salario1 + Salario2) / 2);
        }
    }
}
