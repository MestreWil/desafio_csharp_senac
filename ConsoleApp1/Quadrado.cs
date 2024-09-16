using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            this.Nome = "Quadrado";
            this.Lado = lado;
        }

        public override double Area()
        {
            double area = this.Lado * this.Lado;
            return area;
        }
        public void VerArea()
        {
            Console.WriteLine("Nome: " + this.Nome + "\n" + "Area: " + this.Area());
        }
    }
}
