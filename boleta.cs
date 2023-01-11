using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class calificaciones
{
  static void Main(string []args) 
 {
    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    Console.WriteLine("Boleta");
    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    double cal1,cal2,cal3,cal4,cal5,promedio;
    Console.WriteLine("Ingresa la primera calificación");
    cal1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la segunda calificación");
    cal2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la tercera calificación");
    cal3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la cuarta calificación");
    cal4 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la quinta calificación");
    cal5 = double.Parse(Console.ReadLine());
    Console.WriteLine("Resultado de las calificaciones");
    Console.WriteLine(cal1+ cal2+ cal3+ cal4+ cal5);
    Console.WriteLine("Promedio de calificaion");
        promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;
         Console.WriteLine(promedio);
        if (promedio > 6)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
   
    }
}