using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa 
    {
        public int Nota { get; set; }

            public override void Aprensetar()
        {
                Console.WriteLine($"falaaaa, meu nome é {nome} e sou aluno de {Nota} OTÁRIO! ");
        }      
    }       

}