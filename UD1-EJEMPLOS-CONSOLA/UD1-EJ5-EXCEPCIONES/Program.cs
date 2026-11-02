using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ5_EXCEPCIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CREACION DE UN FICHERO DE TEXTO
                string pathfile = @"C:\Users\migue\Documents\ficheros\fichero1.txt";
                StreamWriter myfile = File.CreateText(pathfile);
                myfile.WriteLine("Ejemplo de excepciones del tema1");
                myfile.WriteLine("Ejemplo miercoles 23 de septiembre");
                myfile.Close();

                StreamReader fileReader = new StreamReader(pathfile);
                string text = fileReader.ReadToEnd();
                Console.WriteLine(text);
                fileReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error al no encontrar el fichero: " + ex.Message);
            }
            catch (UnauthorizedAccessException  ex)
            {
                Console.WriteLine("Error de permisos");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al trabajar con el fichero. " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ejecutamos es codigo siempre");
            }
        }
    }
}
