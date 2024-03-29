﻿using System.Collections.Generic;
using static Entidades.Enumerados;

namespace Entidades
{
    public static class Local
    {

        static List<Producto> Inventario;
        static List<Cliente> Clientes;
        static List<Usuario> Personal;
        static List<Compra> ListaDeVentas;
        static List<Administrador> ListaDeAdministradores;

        /// <summary>
        /// Constructor estatico de la clase local que instancia todas las listas de objetos que utiliza la aplicacion
        /// posee dentro tres metodos propios de la clase para pre cargar listas al iniciar el programa
        /// </summary>
        static Local()
        {
            Personal = new List<Usuario>();
            ListaDeAdministradores = new List<Administrador>();
            Inventario = new List<Producto>();
            ListaDeVentas = new List<Compra>();
            Clientes = new List<Cliente>();

            HardcodearDatosInciales();
            HardcodearProductos();
            HardocdearClientes();
            HardcodearVentas();
        }


        /// <summary>
        /// Propiedad estatica de la Lista de usuarios, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Usuario> Nomina
        {
            set
            {
                if (Personal != null)
                {
                    Personal = value;
                }

            }

            get
            {
                return Personal;
            }

        }

        /// <summary>
        /// Propiedad estatica de la Lista de Stock, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Producto> Stock
        {
            set
            {
                if (value != null)
                {
                    Inventario = value;
                }
            }

            get
            {
                return Inventario;
            }

        }
        /// <summary>
        /// Propiedad estatica de la Lista de Compras, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Compra> Ventas
        {
            set
            {
                if (value != null)
                {
                    ListaDeVentas = value;
                }
            }

            get
            {
                return ListaDeVentas;
            }

        }
        /// <summary>
        /// Propiedad estatica de la Lista de Clientes, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Cliente> Clientela
        {
            set
            {
                if (value != null)
                {
                    Clientes = value;
                }
            }

            get
            {
                return Clientes;
            }

        }

        /// <summary>
        /// Metodo publico de validacion de string de la clase Local devuelve true si es string valido, false si no
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidarString(string texto)
        {
            bool result = true;

            if (!string.IsNullOrEmpty(texto) && texto.Length > 2 && texto.Length < 20)
            {
                foreach (char item in texto)
                {
                    result = char.IsLetter(item);
                }


                return result;
            }


            return false;
        }

        /// <summary>
        /// Metodo publico de validacion de string numerico de la clase Local devuelve true si es string valido, false si no
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>True or false</returns>
        public static bool ValidarStringNumerico(string texto)
        {
            bool result = true;

            if (!string.IsNullOrEmpty(texto) && texto.Length < 9999999)
            {
                foreach (char item in texto)
                {
                    result = char.IsDigit(item);
                }


                return result;
            }


            return false;
        }

        /// <summary>
        /// Metodo publico de validacion de double DNI de la clase Local devuelve true si es un double valido, false si no
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public static bool ValidarDNI(double DNI)
        {

            if (!double.IsNaN(DNI) && DNI > 0)
            {

                return true;

            }
            return false;
        }

        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de usuarios al inciar l programa, la lista contiene empleados y administradores
        /// </summary>
        private static void HardcodearDatosInciales()
        {
            List<Usuario> hardcodeList = new List<Usuario> {
                new Empleado("Carlos","Catson",242442,33875,"Saruman","Killhobits"),
                new Empleado("Martin", "Perez", 2434242, 24500,"Obiwan","Kenobi"),
                new Empleado("Fabricio", "Rodriguez", 22423.00,60000,"Casimiro","Miranda"),
                new Administrador("Lucas", "Bogdan", 22494000, 40000,"Admin","Root"),
                new Administrador("Maria", "Pardem", 44295202, 90000,"Sudo","Suuu"),
                new Administrador("Rodrigo", "Parsein", 23991590, 200000,"Notienesentido","Keapaso"),
                new Empleado("Patricio", "Arizona", 26544678, 25000,"Locoart123","Jojo"),
                new Empleado("Federico", "Bredels", 26544678, 25000,"Abcd","1234"),
                new Empleado("Alma", "Fernandez", 26544678, 25000,"Usuario","Contraseña"),
                new Empleado("Mariana", "Lopez", 26544678, 25000,"Lord","Voldemort"),
                new Empleado("Mario", "Stein", 26544678, 25000,"Finolli","Finolli"),
            };


            foreach (Usuario item in hardcodeList)
            {
                Personal.Add(item);
            }

        }

        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de Productos al inciar al programa, la lista contiene objetos de tipo producto
        /// </summary>
        private static void HardcodearProductos()
        {
            List<Producto> productosHarcode = new List<Producto> {
                new Producto(3001,30,6,Eproducto.Cepillo,"Fino"),
                new Producto(3006,500,100,Eproducto.Alimento,"Perro"),
                new Producto(3007,700,100,Eproducto.Alimento,"Gato"),
                new Producto(4008,1000,10,Eproducto.Vacuna,"Antirrabica"),
                new Producto(2002,65,34,Eproducto.Golosina,"Dentasticks"),
                new Producto(2003,62,34,Eproducto.Golosina,"Carne"),
                new Producto(3008,20,15,Eproducto.Antiparasitario,"Generico")
            };


            foreach (Producto item in productosHarcode)
            {
                Stock.Add(item);
            }

        }


        private static void HardcodearVentas()
        {
                /*Producto
                new Producto prod1(4008, 1000, 10, Eproducto.Vacuna, "Antirrabica"),
                new Producto(2002, 65, 34, Eproducto.Golosina, "Dentasticks"),
                new Producto(2003, 62, 34, Eproducto.Golosina, "Carne"),
                new Producto(3008, 20, 15, Eproducto.Antiparasitario, "Generico")
            */

            List<Compra> ventasHardcode = new List<Compra> {
                new Compra(new Cliente("Fabricio","Rodriguez",42333560),3000,Local.Stock.GetRange(0,4),new Envio(4000,Evehiculo.Miniflete,30)),
                new Compra(new Cliente("Martin", "Martinez",40033560),600,Local.Stock.GetRange(0,2),new Envio(4000,Evehiculo.Miniflete,30)),
                new Compra(new Cliente("Juan", "Rodriguez",21033560),1500,Local.Stock.GetRange(0,3),new Envio(4000,Evehiculo.Motocicleta,12)),
                new Compra(new Cliente("Pedro","Parcere",31333560),2500,Local.Stock.GetRange(0,5),new Envio(4000,Evehiculo.Motocicleta,11)),                        
            };


            foreach (Compra item in ventasHardcode)
            {
                Ventas.Add(item);
            }

        }
        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de Clientes al inciar al programa, la lista contiene objetos de tipo cliente
        /// </summary>
        private static void HardocdearClientes()
        {
            List<Cliente> clientesHardcode = new List<Cliente>
           {
                new Cliente("Fabricio","Rodriguez",42333560),
                new Cliente("Martin", "Martinez",40033560),
                new Cliente("Juan", "Rodriguez",21033560),
                new Cliente("Pedro","Parcere",31333560)
           };

            foreach (Cliente item in clientesHardcode)
            {
                Clientela.Add(item);
            }
        }


        /// <summary>
        /// Metodo publico y estatico de la clase que se utiliza unicamente para loguear el usuario al sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public static Usuario LoguearUsuario(string usuario, string contraseña)
        {
            if (ValidarString(usuario) && ValidarString(contraseña))
            {
                foreach (Usuario item in Local.Nomina)
                {
                    if (item.Contraseña == contraseña && item.User == usuario)
                    {
                        return item;
                    }

                }
            }

            return null;
        }


        public static Envio AsignarEnvio(Cliente cliente, List<Producto> listaDeProductos)
        {
            Envio auxEnvio;
            Evehiculo auxVehiculo;
            int cantProductos = 0;
            float montoDelEnvio = 0;
            cantProductos = listaDeProductos.Count;
            auxVehiculo = Evehiculo.Motocicleta;

            if (cantProductos < 4)
            {
                montoDelEnvio = 75 * cliente.Distancia;
            }
            else
            {
                montoDelEnvio = 100 * cliente.Distancia;
                auxVehiculo = Evehiculo.Miniflete;
            }


            auxEnvio = new Envio(montoDelEnvio, auxVehiculo, cliente.Distancia);

            if (auxEnvio != null)
            {
                return auxEnvio;
            }


            return null;
        }


    }
}
