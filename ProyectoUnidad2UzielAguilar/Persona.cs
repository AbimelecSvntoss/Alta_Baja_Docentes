using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTecNM.Monclova.Gestion
{
    public class Persona
    {
        // Atributos
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; } // Docente o Alumno

        // Constructor
        public Persona(int id, string nombre, string apellidos, string tel, string espec, string mat, string tipo)
        {
            ID = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = tel;
            Especialidad = espec;
            Matricula = mat;
            Tipo = tipo;
        }

        // Lnea para el archivo de texto
        public string GenerarLineaArchivo()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Apellidos: {Apellidos}, Teléfono: {Telefono}, Especialidad: {Especialidad}, Matrícula: {Matricula}, Tipo: {Tipo}";
        }
    }
}
