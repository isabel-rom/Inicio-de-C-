using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lecc3
{
  static void Main( string [] args)
  {
    Console.WriteLine("Introduce tu nombre");
    string nombre = Console.ReadLine();
    
   string saludo = "Hola ";
   
   
   string saludocompleto = saludo + nombre; 
   Console.WriteLine(saludocompleto);
  }
}