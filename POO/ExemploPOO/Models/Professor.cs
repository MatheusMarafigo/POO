using System;

namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public double Salario { get; set; }

        public  override void Aprensetar()
        {
                Console.WriteLine($"falaaaa, meu nome é {nome} e sou professor, e ganho {Salario}.");
        }    
    }

}