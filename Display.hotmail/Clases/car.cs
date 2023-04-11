using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.hotmail.Clases
{
    public class car
    {
        public static void Registrar()
        {
            Console.Clear();
            Console.WriteLine("Agregar vehiculo");
            Console.WriteLine("------------------");
            var v = new Vehiculo();
            v.Marca = Utils.Input("Ingrese la Marca: ");
            v.Modelo = Utils.Input("Ingrese el Modelo: ");
            v.Precio = Utils.Input("Ingrese el precio: ");
            v.Color = Utils.Input("Ingrese el Color: ");
            v.Año = Utils.Input("Ingrese el año: ");
            v.Puertas = Utils.Input("Ingrese las puertas: ");
            v.Motor = Utils.Input("Ingrese el motor: ");
            v.Comentario = Utils.Input("Ingrese el comentario: ");
            Db.vehiculos.Add(v);
            Db.Guardar();
            Utils.Pausa();
        }

        public static void Modificar()
        {

            Console.Clear();
            Console.WriteLine("Modificar el vehiculo");
            Console.WriteLine("--------------------------");

            int index = 0;
            foreach (var vx in Db.vehiculos)
            {
                Console.WriteLine($" {index}) {vx.Marca} {vx.Modelo}");
                index++;

            }

            while (!int.TryParse(Utils.Input(" Ingrese el numero del vehiculo que quiere hacerle modificaciones: "), out index))
            {
                Utils.MensajeError("Ingrese un numero valido que este EN el Sistema");
            }

            if (index >= Db.vehiculos.Count)
            {
                Utils.MensajeError("El numero ingresado es mayor al numero del vehiculo");
                Utils.Pausa();
                return;
            }
            // si todo esta bien

            var v = Db.vehiculos[index];
            var continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Modificar vehiculo");
                Console.WriteLine("------------------------------");
                Console.WriteLine(@$"
        1-Marca: {v.Marca}
        2-Modelo: {v.Modelo}
        3-Precio: {v.Precio}
        4-Color: {v.Color}
        5-Año: {v.Año}
        6-Puertas: {v.Puertas}
        7-Motor: {v.Motor}
        8-Comentario: {v.Comentario}
        9- Guardar
        ");

                int opcion = 0;
                while (!int.TryParse(Utils.Input("Ingrese una opcion: "), out opcion))
                {
                    Utils.MensajeError("Ingrese un numero valido");
                }

                switch (opcion)
                {
                    case 1:
                        v.Marca = Utils.Input("Ingrese la marca: ");
                        break;

                    case 2:
                        v.Modelo = Utils.Input("Ingrese el modelo: ");
                        break;

                    case 3:
                        v.Precio = Utils.Input("Ingrese el precio: ");
                        break;

                    case 4:
                        v.Color = Utils.Input("Ingrese el color: ");
                        break;

                    case 5:
                        v.Año = Utils.Input("Ingrese el Año: ");
                        break;

                    case 6:
                        v.Puertas = Utils.Input("Ingrese las puertas: ");
                        break;

                    case 7:
                        v.Motor = Utils.Input("Ingrese el motor: ");
                        break;

                    case 8:
                        v.Comentario = Utils.Input("Ingrese un comentario: ");
                        break;

                    case 9:
                        continuar = false;
                        Db.vehiculos[index] = v;
                        Db.Guardar();
                        Console.WriteLine("Vhiculo modificado");
                        Utils.Pausa();
                        break;
                }

            }

        }

        public static void Listado()
        {

            Console.Clear();
            Console.WriteLine("Listado de vehiculos");
            Console.WriteLine("--------------------------");

            if (Db.vehiculos.Count == 0)
            {
                Utils.MensajeError("NO HAY VEHICULOS");
            }

            foreach (var v in Db.vehiculos)
            {
                Console.WriteLine(@$"
        Marca: {v.Marca}
        Modelo: {v.Modelo}
        Precio: {v.Precio}
        Color: {v.Color}
        Año: {v.Año}
        Puertas: {v.Puertas}
        Motor: {v.Motor}
        Comentario: {v.Comentario}
        ");

                Console.WriteLine("---------------------------");
            }

            Utils.Pausa();

        }

        public static void Dar()
        {
            Console.Clear();
            Console.WriteLine("Salida");
            Console.WriteLine("------------");
            Console.WriteLine("Ingresa el numero del vehiculo que deseas retirar: ");
            int index = 0;
            foreach (var v in Db.vehiculos)
            {
                Console.WriteLine($"{index}) {v.Marca} {v.Modelo}");
                index++;
            }
            while (!int.TryParse(Utils.Input("Ingrese el numero del vehiculo que desea salir: "), out index))
            {

            }
            if (index >= Db.vehiculos.Count)
            {
                Utils.MensajeError("El numero ingresado no es valido");
                Utils.Pausa();
                return;
            }

            Db.vehiculos.RemoveAt(index);
            Db.Guardar();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Vehiculo retirado");
            Utils.Pausa();
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}

