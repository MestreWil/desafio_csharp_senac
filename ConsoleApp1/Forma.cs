using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
}
