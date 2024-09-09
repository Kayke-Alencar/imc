using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Imc: Paciente
    {
        public double Calcular(double peso, double altura)
        {
            this.Peso = peso;
            this.Altura = altura;

            this.Imc = this.Peso / (Math.Pow(this.Altura,2)); //Math.Pow para elevar a 2 

            return this.Imc;
        }


        public void mostraImc() 
        {
            Console.WriteLine($"Indice de massa corporal:{this.Imc}");
        
        }

        public void verificarImc() 
        {

            //magresa
            if (this.Imc < 16)
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Magreza Grave");
            }
            if (this.Imc >= 16 && this.Imc < 16.9)
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Magreza moderada");
            }

            if (this.Imc <= 17 && this.Imc <= 18.5)
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Magreza leve");
            }




            //ideal

            if (this.Imc >= 18.6 && this.Imc <= 24.9)
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Peso Ideal");
            
            }




            //obesidade
            if (this.Imc >= 25 && this.Imc <= 29.9) 
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Sobrepeso");
            }

            if (this.Imc >= 30 && this.Imc <= 34.9)
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Obesidade Grau 1");
            }
            if (this.Imc >= 35 && this.Imc <= 39.9) 
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Obesidade Grau 2");
            
            }
            if (this.Imc > 40) 
            {
                this.mostraImc();
                Console.WriteLine("Categoria: Obesidade morbida");
            
            }
            
        
        
        }
    }
}
