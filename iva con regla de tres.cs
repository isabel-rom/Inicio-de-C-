using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class iva
{
  static void Main(string []args) 
 {
    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
    Console.WriteLine("Verificador de precios");
    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
    double precio, iva,resul,resultadototal;
    Console.WriteLine("Favor de colocar el precio");
    precio = double.Parse(Console.ReadLine());
   Console.WriteLine("Introduce el iva de tu pais");
    iva = double.Parse(Console.ReadLine());
    resul = precio / 100 * iva;
   Console.WriteLine("El costo extra con iva es:  "+ resul);
    resultadototal = resul+precio; 
    Console.WriteLine("El precio tal con iva es: "+ resultadototal);
 }
}