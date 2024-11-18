using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    internal class Leao : Animal
    {


            public Leao(string nome, string sexo, string raca) : base(nome, sexo, raca)
            {

            // aqui nao e necessario fazer linhas de codigo porque estou fazer base para  herança...
            }

            public override void EmitirSom()
            {
                Console.WriteLine(_nome+" rearrrrrrr");
            }
        
    }
}
