using System;
namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? nome {get; set; }
        
        public int Idade {get; set; }

        public string? Documento {get; set;}

        public virtual void Aprensetar()
        {
            Console.WriteLine($"Olá meu é {nome} e tenho {Idade} anos e o N° é {Documento} ");
            
        }
    }
}