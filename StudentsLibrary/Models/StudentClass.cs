using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class StudentClass
    {
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Dui { get; set; }
        public double NotaFinal { get; set; }

        public double GetNotas(double nota1, double nota2, double nota3)
        {
            double notaFinal = (nota1 + nota2 + nota3) / 3;
            return notaFinal;
        }
        //Genera una lista de estudiantes que pasan al ComboBox
        public List<StudentClass> GetStudents()
        {
            return new List<StudentClass>
            {
                new StudentClass{
                    Nombres = "Juan Alexander Rios",
                    Correo = "juanrios7681@gmail.com",
                    Telefono = 863931713,
                    Dui = "8713813-3"},
                new StudentClass{
                    Nombres = "Maria Fernanda Lopez",
                    Correo = "maria.lopez@example.com",
                    Telefono = 785412369,
                    Dui = "1234567-8"},
                new StudentClass{
                    Nombres = "Carlos Alberto Torres",
                    Correo = "carlostorres@example.com",
                    Telefono = 912345678,
                    Dui = "9876543-2"},
            };
        }
    }
    public class StudentManager
    {
        private List<StudentClass> studentList;
        public StudentManager()
        {
            studentList = new List<StudentClass>
            {
                new StudentClass
                {
                Nombres = "Juan Alexander Rios",
                Correo = "juanrios7681@gmail.com",
                Telefono = 863931713,
                Dui = "8713813-3"
                },
            new StudentClass
                {
                Nombres = "Maria Fernanda Lopez",
                Correo = "maria.lopez@example.com",
                Telefono = 785412369,
                Dui = "1234567-8"
                },
            new StudentClass
                {
                Nombres = "Carlos Alberto Torres",
                Correo = "carlostorres@example.com",
                Telefono = 912345678,
                Dui = "9876543-2"
                }
            
            };

        }
        // Método para buscar por correo
        public StudentClass FindByEmail(string email)
        {
            return studentList.Find(est => est.Correo == email);
        }

        // Método para buscar por DUI
        public StudentClass FindByDui(string dui)
        {
            return studentList.Find(est => est.Dui == dui);
        }
    }

}
