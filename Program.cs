using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Poo_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Profesor Secundaria = new Profesor();
            Secundaria.Nombre = "Mario";
            Secundaria.Apellido = "Jirafales";
            Secundaria.DNI = "289903094";
            Secundaria.Materia = "Historia";
            Secundaria.Curso = "Tercero B";
            Secundaria.Turno = "Mañana";
            Secundaria.DatosBasicosP();            
            Secundaria.Clases();

            Console.ReadLine();

            Alumno Secundario = new Alumno();
            Secundario.Nombre = "Mara";
            Secundario.Apellido = "Dona";
            Secundario.DNI = "10101010";
            Secundario.Curso = "Cuarto B";
            Secundario.Turno = "Mañana";
            Secundario.DatosBasicosA();
            Secundario.Horario();

            Console.ReadLine(); 

            VerificarProfesor(Secundaria, Secundario);

            Console.ReadKey();
        }
        static void VerificarProfesor(Profesor profesor, Alumno alumno)
        {
            if (profesor.Curso == alumno.Curso && profesor.Turno == alumno.Turno)
            {
                Console.WriteLine($"El profesor {profesor.Nombre} {profesor.Apellido} es profesor de la alumna {alumno.Nombre} {alumno.Apellido}.");
            }
            else
            {
                Console.WriteLine($"El profesor {profesor.Nombre} {profesor.Apellido} no es profesor de la alumna {alumno.Nombre} {alumno.Apellido}.");
            }
        }

    }

    public class Profesor
    {
        public string Nombre;
        public string Apellido;
        public string DNI;
        public string Materia;
        public string Curso;
        public string Turno;

        public void Clases()
        {
            Console.WriteLine($"El profesor {Nombre} {Apellido}, DNI {DNI}, da clases de {Materia} al curso {Curso},turno {Turno}.");
        }

        public void DatosBasicosP()
        {
            Console.WriteLine($"El profesor se llama {Nombre} {Apellido}");
        }
    }

    public class Alumno
    {
        public string Nombre;
        public string Apellido;
        public string DNI;
        public string Curso;
        public string Turno;

        public void Horario()
        {
            Console.WriteLine($"La alumna {Nombre} {Apellido},DNI {DNI}, pertenece al curso {Curso},turno {Turno}.");
        }

        public void DatosBasicosA()
        {
            Console.WriteLine($"La alumna se llama {Nombre} {Apellido}");
        }
    }

}

    

    




