using ConsoleApp1;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Quadrado quadrado = new Quadrado(5.5);
        quadrado.VerArea();
        Circulo circulo = new Circulo(45);
        circulo.VerArea();
        Triangulo triangulo = new Triangulo(4, 5, 6);
        triangulo.VerArea();
    }
}

