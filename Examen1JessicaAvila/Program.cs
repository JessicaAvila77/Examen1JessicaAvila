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
            asignatura.N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese nota segundo parcial:");
            asignatura.N2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese nota tercer parcial:");
            asignatura.N3 = Convert.ToInt32(Console.ReadLine());

            //asignatura.CalcularNotaFinal();
            asignatura.Imprimir();

        }
    }
}
