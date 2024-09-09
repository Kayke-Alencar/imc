using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Paciente 
    {
        public string Nome;
        public double Peso;
        public double Altura;
        public double Imc;


        public void Cadastrar(string nome, double peso, double altura){
            this.Nome = nome;
            this.Peso = peso;
            this.Altura = altura;
        }

        public void exibirDados() 
        {
            Console.WriteLine($"Paciente:{this.Nome}\nPeso:{this.Peso}\nAltura:{this.Altura}\n");
        }
    }
}
