using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        string apellido;
        double dni;
        double saldo;
        static Random rand;

        /// <summary>
        /// Constructor de la clase cliente, para el monto genera un numero entre 300 y 5000
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido,double dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dinero = rand.Next(300, 5000);
            DNI = dni;
        }

        /// <summary>
        /// Constructor estatico de la clase randoom, el cual se utiliza luego para asignar el numero randoom al monto de dinero
        /// </summary>
        static Cliente()
        {
            rand = new Random();       
        }
        
        /// <summary>
        /// Propiedad nombre de la clase cliente
        /// </summary>
        public string Nombre
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.nombre = value;
                }
            }

            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Propiedad apellido de la clase cliente
        /// </summary>
        public string Apellido
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.apellido = value;
                }
            }

            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad dinero de la clase cliente
        /// </summary>
        public double Dinero
        {
            set
            {
                if (value > 0)
                {
                    this.saldo = value;
                }
            }

            get
            {
                return this.saldo;
            }
        }

        /// <summary>
        /// Propiedad DNI de la clase cliente
        /// </summary>
        public double DNI
        {
            set
            {
                if (Local.ValidarDNI(value))
                {
                    this.dni = value;
                }
            }

            get
            {
                return this.dni;
            }
        }
        /// <summary>
        /// Meotodo unico que retorna en forma de string los datos del cliente
        /// </summary>
        /// <returns></returns>
        public string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" {Nombre}        {Apellido}     {DNI.ToString()}             {Dinero.ToString()}");
            return sb.ToString();

        }

    }
}
