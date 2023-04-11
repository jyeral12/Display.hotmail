using Display.hotmail.Clases;
using System.Text.Json;

bool continuar = true;
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Db.Cargar();    
while (continuar)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
  
              
                           _______________________________________________________________
                           |°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°|
                           |•._.••´¯``•.¸¸.•` `•.¸¸.•´´¯`••._.•`•.¸¸.•´´¯`••._.•`•.¸¸.•´´¯``•.¸¸.•´´¯`••._.•°°°      
                           |°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°|
                           |_____`•.¸¸.•´´¯`••._.• `•.¸¸.•´´¯`••._.• `•.¸¸.•´´¯`••._.•`•.¸¸.•´´¯`••._.•`•.¸¸._|
                                |__________________________________________________|
                                                  ||           ||
                                        ______--~~~~~~~~~~~~~~~~~~-----______            
                              __________// _-~~~~~~~~~---------------~~~-_ \\___________ 
                              `\_____)\/~        °°Yeral Martinez°°         ~\/(_____/'          
                                ----_--`-__________________________________-'--_---#     
                                /~     `\ ~~~~~~~~---------------~~~~~~~~ /'  ~\   #     
                                /|       \          ____________         /'     |\ #    
                                | `\   ______`\_      \------/      _/'______   /' |          
                                |   `\_~-_____\ ~-________________-~ /_____-~_/'   |  
                                `.     ~-__________________________________-~     .'     
                                `.      [_______/------|~~|------\_______]      .'
                                `\--___((____)(________\/________)(____))___--/'           
         ||<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>||                        ||>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<||


                    1-Registrar Vehiculo.
                    2-Editar Vehiculos.
                    3-Mostrar Vehiculos.
                    4-Dar salida a un Vehiculo.
                    5-Salir.

                 ");




    Console.ForegroundColor = ConsoleColor.White;

    var opcion = Utils.Input("Ingrese una opcion: ");

    switch (opcion)
    {

        case "1":
            car.Registrar();
            break;

        case "2":
            car.Modificar();
            break;

        case "3":
            car.Listado();
            break;

        case "4":
            car.Dar();
            break;

        case "x":
            continuar = false;
            Console.WriteLine("Espero disfrute tus compras...");
            break;
    }

}
