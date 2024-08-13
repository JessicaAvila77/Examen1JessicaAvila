using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1JessicaAvila
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.Write("Ingrese nombre del alumno:");
            asignatura.NombreAlumno = Console.ReadLine();
            Console.Write("Ingrese numero de cuenta:");
            asignatura.NumeroCuenta = Console.ReadLine();
            Console.Write("Ingrese correo electrónico:");
            asignatura.Email = Console.ReadLine();
            Console.Write("Ingrese nombre de la clase:");
            asignatura.NombreAsignatura = Console.ReadLine();
            Console.Write("Ingrese horario de clase:");
            asignatura.Horario = Console.ReadLine();
            Console.Write("Ingrese nombre del docente:");
            asignatura.NombreDocente = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese nota primer parcial:");
            bool validN1 = int.TryParse(Console.ReadLine(), out asignatura.N1);
            Console.Write("Ingrese nota segundo parcial:");
            bool validN2 = int.TryParse(Console.ReadLine(), out asignatura.N2);
            Console.Write("Ingrese nota tercer parcial:");
            bool validN3 = int.TryParse(Console.ReadLine(), out asignatura.N3);

            //validando tipo de datos y validando numeros enteros
            if (validN1 && validN2 && validN3)
            {
                if ((asignatura.N1 >= 0 && asignatura.N1<=30) && (asignatura.N2 >= 0 && asignatura.N2 <= 30) && (asignatura.N3 >= 0 && asignatura.N3 <= 40))
                {
                    asignatura.Imprimir();
                }
                else if (asignatura.N1 > 30 || asignatura.N2 > 30)
                {
                    Console.WriteLine("");
                    Console.WriteLine("La nota del primer o el segundo parcial sobrepasan del 30%");

                }else if (asignatura.N3 > 40)
                {
                    Console.WriteLine("");
                    Console.WriteLine("La nota del tercer parcial sobrepasa del 40%");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Una nota es menor que cero");

                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Uno de las notas no tiene el formato correcto...");
            }

           

        }
    }
}
