using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class lecc3
{
  static void Main(string []args) 
  {
    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
    Console.WriteLine("Bienvenido, por favor de escribir lo que se te pide");
    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
    
    double  num1,num2,num3,num4,num5, resul;
    Console.WriteLine("Introduce el primer numero:   ");
   num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Introduce un segundo numero:   ");
    num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduce un tercer numero:   ");
    num3 = double.Parse(Console.ReadLine ());
   Console.WriteLine("Introduce un cuarto numero:   ");
    num4 = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduce un quinto numero:   ");
   num5 =  double.Parse(Console.ReadLine ());
   resul = (num1+num2+num3+num4+num5)/5;
   Console.WriteLine("La media es "+ resul);
    
  }
}