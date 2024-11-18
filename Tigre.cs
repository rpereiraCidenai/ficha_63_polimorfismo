using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    internal class Tigre:Animal
    {
        public Tigre(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine(_nome + " (Tigre): Roncar!");
        }
    }
}
