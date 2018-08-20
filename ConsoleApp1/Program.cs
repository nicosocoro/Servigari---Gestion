using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.ManejadorArchivo manejadorArchivo;

            manejadorArchivo = new Database.ManejadorArchivoXML();

            manejadorArchivo.Listar();
            Menu(manejadorArchivo);
        }

        static void Menu(Database.ManejadorArchivo manejador)
        {
            string rta = "";

            do
            {
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Agregar");
                Console.WriteLine("3 - Modificar");
                Console.WriteLine("4 - Eliminar");
                Console.WriteLine("5 - Guardar cambios");
                Console.WriteLine("6 - Salir");

                rta = Console.ReadLine();

                switch(rta)
                {
                    case "1":
                        manejador.Listar();
                        break;

                    case "2":
                        manejador.NuevaFila();
                        break;

                    case "3":
                        manejador.EditarFila();
                        break;

                    case "4":
                        manejador.EliminarFila();
                        break;

                    case "6":
                        manejador.AplicarCambios();
                        break;

                    default:
                        break;
                }
            } while (rta != "6");
        }
    }
}
