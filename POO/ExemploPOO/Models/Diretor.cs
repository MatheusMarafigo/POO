using System;
namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Aprensetar()
        {
                Console.WriteLine($"Diretor");
        }    
    }
}