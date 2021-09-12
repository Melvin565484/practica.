using System;
using System.Collections.Generic;
using System.Text;

namespace practica1_09_09_21_
{
    class Estudiantes
    {
         
    

    public int idEstudiantes { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
    

    public static List<Estudiantes> GetEstudiantes()
        {
            List<Estudiantes> students = new List<Estudiantes>
            {
                new Estudiantes{ idEstudiantes= 1001, firstName= "Melvin", lastName="Fember", age=18 , nationality="Espa;a" },
                new Estudiantes{ idEstudiantes= 1002, firstName= "Santiago", lastName="Mendoza", age=18 , nationality="Japon" },
                new Estudiantes{ idEstudiantes= 1003, firstName= "Rem", lastName="", age=19 , nationality="Canada"},
                new Estudiantes{ idEstudiantes= 1004, firstName= "Betelgeuse", lastName="Hernandez", age=26 , nationality="Mexico" },
                new Estudiantes{ idEstudiantes= 1005, firstName= "Elmer",lastName="Sorto", age=19 , nationality="Australia" },
                new Estudiantes{ idEstudiantes= 1006, firstName= "Kelly", lastName="Mendoza", age=18 , nationality="EEUU" },
                new Estudiantes{ idEstudiantes= 1007, firstName= "Historia", lastName="Rodriguez", age=21 , nationality="Irlanda" },
            };
            return students;
        }


    }
}


    

