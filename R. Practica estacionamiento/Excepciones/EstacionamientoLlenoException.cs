﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EstacionamientoLlenoException : Exception
    {
        public EstacionamientoLlenoException() : base("El estacionamiento esta lleno.") { }
    }
}
