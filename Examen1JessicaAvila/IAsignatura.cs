using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1JessicaAvila
{
    public interface IAsignatura
    {
        //este metodo sumara las 3 notas parciales y retorna la nota final
        double CalcularNotaFinal();


        //este metodo sumara las 3 notas parciales a partir de los parametros
        double CalcularNotaFinal(double N1, double N2, double N3);

        //retorna el msj de acuerdo a la nota final
        string MensajeNotaFinal(double notaFinal);

        //Mostrar en pantalla los datos del alumno, la asignatura y la nota final
        void Imprimir();

    }
}
