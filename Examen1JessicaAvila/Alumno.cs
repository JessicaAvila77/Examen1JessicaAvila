using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1JessicaAvila
{
    public class Alumno
    {
        public string NombreAlumno { get; set; }
        public string NumeroCuenta { get; set;}
        public string Email { get; set;}

        public Alumno() { }

        public Alumno (string NombreAlumno, string NumeroCuenta, string Email)
        {
            this.NombreAlumno=NombreAlumno;
            this.NumeroCuenta=NumeroCuenta;
            this.Email=Email;
        }

    }
}
