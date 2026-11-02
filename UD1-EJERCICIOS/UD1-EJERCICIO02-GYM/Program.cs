using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO02_GYM
{
    internal class Program
    {
        static List<Cliente> clienteList = new List<Cliente>();
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine("\nMenú del gimnasio");
                Console.WriteLine("1. Dar de alta al cliente");
                Console.WriteLine("2. Mostrar clientes");
                Console.WriteLine("3. Modificar cliente");
                Console.WriteLine("4. Eliminar clientes");
                Console.WriteLine("5. Borrar todos los clientes (Administrador)");
                Console.WriteLine("6. Guardar clientes en un archivo JSON");
                Console.WriteLine("7. Cargar clientes de un archivo JSON");
                Console.WriteLine("8. Salir\n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AltaCliente();
                        break;
                    case 2:
                        MostrarCliente();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:
                        Console.WriteLine("Cerrando aplicacion");
                        break;
                }

            }while (op != 8);
        }

        static public void AltaCliente()
        {
            Console.WriteLine("Escribe el nombre del cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe el apellido del cliente");
            string apellido = Console.ReadLine();
            clienteList.Add(new Cliente(clienteList.Count+1,nombre,apellido));

        }
        static public void MostrarCliente()
        {
            Console.WriteLine("\nLista de Clientes");
            int i = 0;
            foreach (Cliente c in clienteList)
            {
                Console.WriteLine($"id: {c.CodigoCliente}\tNombre: {c.NombreCliente}\tApeliidos: {c.ApellidoCliente}");
                Console.WriteLine("-----------------------");
            }
        }
        static public void ModificarCliente()
        {
            Console.WriteLine("Escribe el id del cliente");
            int id = int.Parse(Console.ReadLine());
            Cliente c = clienteList.Find(cl => cl.CodigoCliente == id);
            Console.WriteLine($"id: {c.CodigoCliente}\tNombre: {c.NombreCliente}\tApeliidos: {c.ApellidoCliente}");
            Console.WriteLine("Escribe el nuevo nombre del cliente");
            c.NombreCliente = Console.ReadLine();
            Console.WriteLine("Escribe el nuevo apellido del cliente");
            c.ApellidoCliente = Console.ReadLine();
            
        }
        static public void EliminarCliente()
        {

        }
        static public void GuardarClientesJSON()
        {

        }
        static public void CargarClientesJSON()
        {

        }


    }
}
