﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listass
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public Alumno(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }
    }
}
