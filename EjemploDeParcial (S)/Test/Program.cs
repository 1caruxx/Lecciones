﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {

        //Para mañana se debe lograr aniadir dos objetos (moto y auto) con la misma patente, para ello debo identificar el tipo de objeto, si son distintos puedo agregar a la lista
        static void Main(string[] args)
        {
            Estacionamiento uno;

            uno = "nuevo";

            uno = uno + new Auto("A3");

            uno = uno - new Auto("A3");
        }
    }
}
