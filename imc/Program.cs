using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc{
    internal class Program{
        public string Capturar(string texto)
        {
            Console.WriteLine(texto);
            return Console.ReadLine();
        }
        static void Main(string[] args){


            Program program = new Program();
            string Nome = program.Capturar("Nome: ");
            double Peso = double.Parse(program.Capturar("Peso: "));
            Double Altura = double.Parse(program.Capturar("Altura: "));


            Paciente paciente = new Paciente();
            paciente.Cadastrar(Nome, Peso, Altura);


            Imc imc = new Imc();
            paciente.Imc = imc.Calcular(paciente.Peso, paciente.Altura );
            paciente.exibirDados(); //exibir dados como nome, peso e altura
            imc.verificarImc(); //verica as categorias de imc e mostra no console



            Console.ReadKey();
        }
    }
}
