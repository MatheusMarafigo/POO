using ExemploPOO.Models;
using System;
namespace ExemploPOO
{
    class Program
        {
                static void Main(string[] args)
                {
                    Professor p1 = new Professor();
                    p1.Salario = 2500;
                    p1.nome = "Macaco";
                    p1.Idade = 24;
                    p1.Documento = "123456";
                    p1.Aprensetar();




                    
                    // //valores validos 
                    // Retangulo r = new Retangulo();
                    // r.DefinirMedidas(30, 60);

                    // System.Console.WriteLine($"Área: {r.ObterArea()}");
 
                    // //Valores inválidos
                    // Retangulo r2 = new Retangulo();
                    // r2.DefinirMedidas(0,0);
                    // System.Console.WriteLine($"Área: {r2.ObterArea()}");
  
  
                    // Pessoa p1 = new Pessoa();
                    // p1.nome = "Macaco";
                    // p1.Idade = 24;

                    // p1.Aprensetar(); 

                }
        }
    }
