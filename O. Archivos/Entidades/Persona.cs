﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Alumno)), XmlInclude(typeof(Profesor))]
    public class Persona :Humano
    {
        private string _apellido;
        private string _nombre;

        /*
         * Si yo quiero guardar en un archivo XML atributos que sean privados, debere previamente crear propiedades de lectura y escritura.
         */
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Persona() { }

        public Persona(string apellido , string nombre)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public Persona(string apellido, string nombre, int dni): this(apellido, nombre)
        {
            this.DNI = dni;
        }
    }
}
