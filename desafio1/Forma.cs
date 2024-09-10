using System;

public abstract class Forma
    {
        public string Nome { get; set; }

        public Forma(string nome)
        {
            this.Nome = nome;
        }
        public Forma() { }

        public virtual double Area()
        {
            return 0;
        }


    }