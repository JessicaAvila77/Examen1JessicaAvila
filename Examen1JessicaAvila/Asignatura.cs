using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1JessicaAvila
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;
        public int N2;
        public int N3;
        //public int Notafinal;
        public string NombreAsignatura {  get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public Asignatura() { } 

        

        public double CalcularNotaFinal()
        {
            //return N1+N2+N3;
            return CalcularNotaFinal(N1,N2,N3);
        }

        //double notafinal =0;
        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            double notafinal = n1 + n2 + n3;


            MensajeNotaFinal(notafinal);

            return notafinal;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                Console.WriteLine("Reprobado");
            }
            if (notaFinal >= 60 && notaFinal <= 70)
            {
                Console.WriteLine("Reprobado");
            }

            return string.Empty;
        }

        public void Imprimir()
        {

        }

    }
}
