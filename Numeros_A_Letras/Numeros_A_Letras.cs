using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
namespace Numeros_A_Letras
{
    public class Numeros_A_Letras
    {
       
        //    static string NumerosLetras(int numero)
        //    {
        //        if (numero == 0)
        //            return "Zero";
        //        if (numero < 0)
        //            return "Minus " + NumerosLetras(-numero);

        //        string palabras = "";

        //        // Manejo de los miles
        //        if ((numero / 1000) > 0)
        //        {
        //            palabras += NumerosLetras(numero / 1000) + "Thousand ";
        //            numero %= 1000;
        //        }

        //        // Manejo de las centenas
        //        if ((numero / 100) > 0)
        //        {
        //            palabras += NumerosLetras(numero / 100) + "Hundred ";
        //            numero %= 100;
        //        }

        //        // Manejo de los números restantes
        //        if (numero > 0)
        //        {
        //            if (palabras != "")
        //                palabras += "and ";

        //            if (numero < 20)
        //            {
        //                string[] unidades =
        //                {
        //            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
        //            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        //        };
        //                palabras += unidades[numero];
        //            }
        //            else
        //            {
        //                string[] decenas = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        //                palabras += decenas[numero / 10];

        //                if ((numero % 10) > 0)
        //                    palabras += "_" + NumerosLetras(numero % 10);
        //            }
        //        }

        //        return palabras;
        //    }

        //public static void Main(string[] args)
        //{
        //    int numero;
        //    do
        //    {
        //        Console.Write("Ingrese un número entre -9999 y 9999: ");
        //    } while (!int.TryParse(Console.ReadLine(), out numero) || numero < -9999 || numero > 9999);

        //    string resultado = NumerosLetras(numero);
        //    Console.WriteLine($"El número {numero} en letras es: {resultado}");
        //}

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número dentro del rango de -9999 a 9999:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= -9999 && number <= 9999)
            {
                string words = number.ToWords();//(new CultureInfo("en-"));
                Console.WriteLine($": {words}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido dentro del rango especificado.");
            }
        }

    }

}