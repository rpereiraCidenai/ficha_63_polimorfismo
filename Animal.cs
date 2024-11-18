using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    internal class Animal
    {
        protected string _nome;
        protected string _sexo;
        protected string _raca;

        // Construtor da classe Animal
        public Animal(string nome, string sexo, string raca)
        {
            this._nome = nome;
            this._sexo = sexo;
            this._raca = raca;
        }
        public Animal()
        {
            this._nome = "";
            this._sexo = "";
            this._raca = "";
        }

        // Método virtual para emitir som com implementação padrão
        public virtual void EmitirSom()
        {
            Console.WriteLine("Animal a imitir som.");
        }

        public void Dormir()
        {
            Console.WriteLine(_nome + " está a dormir.");
        }

        public void Caminhar()
        {
            Console.WriteLine(_nome + " está a caminhar.");
        }

        // Método para exibir informações do animal
        public void ExibirInfo()
        {
            Console.WriteLine("Nome: " + _nome + ", Sexo: " + _sexo + ", Raça: " + _raca);
        }
    }
}
