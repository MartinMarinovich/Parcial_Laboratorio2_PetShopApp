using System.Collections.Generic;

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
                new Empleado("Lucas", "Arizona", 26544678, 25000,"Locoart123","Jojo"),
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
                new Producto(3001,30,6,Enumerados.Eproducto.Cepillo,"Fino"),
                new Producto(3006,500,100,Enumerados.Eproducto.Alimento,"Perro"),
                new Producto(3007,700,100,Enumerados.Eproducto.Alimento,"Gato"),
                new Producto(4008,1000,10,Enumerados.Eproducto.Vacuna,"Antirrabica"),
                new Producto(2002,65,34,Enumerados.Eproducto.Golosina,"Dentasticks"),
                new Producto(2003,62,34,Enumerados.Eproducto.Golosina,"Carne"),
                new Producto(3008,20,15,Enumerados.Eproducto.Antiparasitario,"Generico")
            };


            foreach (Producto item in productosHarcode)
            {
                Stock.Add(item);
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


    }
}
