using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Display.hotmail.Clases
{
    internal class Utils
    {
        public static string Input(string msg)
        {

            Console.Write(msg);
            var rs = Console.ReadLine();
            return rs;


        }

        public static void Pausa()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Presione enter para continuar...");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void MensajeError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();

        }

    }
}

