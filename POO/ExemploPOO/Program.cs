using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System;
namespace ExemploPOO
{
    class Program
        {
                static void Main(string[] args)
                {   
                    ICalculadora calc = new Calculadora();
                    System.Console.WriteLine(calc.Somar(10,20));
                    
                    





                    // Corrente c = new Corrente();
                    // c.Creditar(100);

                    // c.ExibirSaldo();
                    
                    // Calculadora calc = new Calculadora();
                    // System.Console.WriteLine("Resultado da primeira soma é: " + calc.Somar(10, 10));
                    // System.Console.WriteLine("Resultado da primeira soma é: " + calc.Somar(15, 35, 10));

                    // Aluno p1 = new Aluno();
                    // p1.nome = "Rato Sapeca";
                    // p1.Idade = 24;
                    // p1.Documento = "123456";
                    // p1.Nota = 10;
                    // p1.Aprensetar();

                    // Professor p2 = new Professor();
                    // p2.nome = "Rato Sapeca";
                    // p2.Idade = 24;
                    // p2.Documento = "123456";
                    // p2.Salario = 1500;
                    // p2.Aprensetar();
 
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
