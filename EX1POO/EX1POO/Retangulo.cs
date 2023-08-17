using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1POO
{
    internal class Retangulo
    {
        
    private double baseRetangulo;
        private double alturaRetangulo;

        public void LerDados()
        {
            Console.Write("Digite a base do retângulo: ");
            baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            alturaRetangulo = Convert.ToDouble(Console.ReadLine());
        }

        public double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"A área do retângulo é: {CalcularArea()}");
        }
    }
}

