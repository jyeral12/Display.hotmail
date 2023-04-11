using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Display.hotmail.Clases
{
    internal class Db
    {
        //Vehiculo obj = new Vehiculo();

        public static List<Vehiculo> vehiculos = new List<Vehiculo>();

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public static object Newtonsoft { get; private set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public static object Json { get; private set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public static void Guardar()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("datos.json", JsonSerializer.Serialize(vehiculos, opciones));

            Console.WriteLine("Datos guardados en el archivo datos.json");
        }

        public static void Cargar()
        {
            if (File.Exists("vehiculos.Yeral"))
            {

                try
                {


                }
                catch (Exception ex)
                {
                    Utils.MensajeError("Ocurrio un error al cargar los datos");
                    Utils.Pausa();
                }

            }
            else
            {
                Console.WriteLine("No existe archivo.... Apenas estamos abirendo");
                Utils.Pausa();
            }
        }
    }


   public class Vehiculo
    {




        public string Modelo { get; set; }
        public string Precio { get; set; }
        public string Color { get; set; }
        public string Año { get; set; }
        public string Puertas { get; set; }
        public string Motor { get; set; }
        public string Comentario { get; set; }
        public object Marca { get; internal set; }
    }
}

