using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            this.Nome = "Circulo";
            this.Raio = raio;
        }

        public override double Area()
        {
            double area = 3.1415 * (this.Raio * this.Raio);
            return area;
        }
        public void VerArea()
        {
            Console.WriteLine("Nome: " + this.Nome + "\n" + "Area: " + this.Area() + "m²");
        }
    }
}
