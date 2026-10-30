using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana11
{
    internal class Validador
    {
        // Lee un texto que no esté vacío
        public static string LeerTexto(string mensaje)
        {
            string texto;
            do
            {
                Console.Write(mensaje);
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    Console.WriteLine("El texto no puede estar vacío. Intente de nuevo.");
                }
            } while (string.IsNullOrWhiteSpace(texto));
            return texto.Trim();
        }
        // Lee un número decimal (nota) entre 0 y 20
        public static double LeerDecimal(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out valor))
                {
                    if (valor >= 0 && valor <= 20)
                    {
                        return valor;
                    }
                    Console.WriteLine("La nota debe estar entre 0 y 20.");
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.");
                }
            }
        }
        // Lee un número entero
        public static int LeerEnteros(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out valor))
                {
                    return valor;
                }
                Console.WriteLine("Ingrese un número entero válido.");
            }
        }
    }
}
