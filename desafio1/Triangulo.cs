using System;

class Triangulo : Forma
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        
        public Triangulo(double ladoa, double ladob, double ladoc)
        {
            this.Nome = "Triangulo";
            this.LadoA = ladoa;
            this.LadoB = ladob;
            this.LadoC = ladoc;
        }

        public override double Area()
        {
            double area = (this.LadoA + this.LadoB + this.LadoB)/2;
            return area;
        }
        public void VerArea()
        {
            Console.WriteLine("Nome: " + this.Nome + "\n" + "Area: " + this.Area() + "m²");
        }
    }
