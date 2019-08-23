using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();
            Grupo matematicas = 
                new Grupo("Matematicas", "MAT16237");

            Grupo historia = 
                new Grupo("Historia", "HST2168");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "78921");
            Alumno luis = new Alumno("luis", "78922");
            Alumno pepe = new Alumno("pepe", "78923");
            Alumno sol = new Alumno("sol", "78924");
            Alumno ana = new Alumno("ana", "78925");
            Alumno jose = new Alumno("jose", "78926");
            Alumno dani = new Alumno("dani", "78927");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(luis);
            historia.Alumnos.Add(pepe);


            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(luis);
            matematicas.Alumnos.Add(pepe);
            matematicas.Alumnos.Add(sol);
            matematicas.Alumnos.Add(ana);

            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Materia);
                Console.WriteLine("Lista de alumnos: ");
                foreach (Alumno alumno in grupo.Alumnos)
                    {
                    Console.WriteLine("*" + alumno.Nombre);
                }
                
            }
            Console.Read();
        }
    }
}
