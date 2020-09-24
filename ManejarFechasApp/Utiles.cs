using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ManejarFechasApp
{
    class Utiles
    {

        public static DateTime pedirFecha()
        {

            DateTime fecha = new DateTime();
            bool valido;
            do
            {

                Console.Write("\nEscribe una fecha: ");
                valido = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!valido)
                {
                    Console.WriteLine("Fecha no valida ");
                }

            } while (!valido);

            return fecha;

        }

        public static int pedirNum()
        {
            bool valido;
            int num;

            do
            {

                Console.Write("\nIntroduce un número ");
                valido = int.TryParse(Console.ReadLine(), out num);

                if (!valido)
                {

                    Console.WriteLine("Número no valido");

                }


            } while (!valido);


            return num;

        }

        public static void menu()
        {
            int op;
            bool salir = false;

            do
            {

                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("1.- Dia de la Semana");
                Console.WriteLine("2.- Incrementar Dias");
                Console.WriteLine("3.- Resta Fechas");
                Console.WriteLine("4.- Compara Fechas");
                Console.WriteLine("5.- Salir");

                op = pedirNum();

                switch (op)
                {

                    case 1:

                        Console.WriteLine("\n-----------VAMOS A COMPROBAR QUE DIA DE LA SEMANA ES TU FECHA-----------");
                        UsarFechas.comprobarDia();
                        break;

                    case 2:

                        Console.WriteLine("\n-----------VAMOS A INCREMENTAR UNA FECHA-----------");
                        UsarFechas.incrementarFecha();
                        break;

                    case 3:

                        Console.WriteLine("\n-----------DIFERENCIA ENTRE FECHAS-----------");
                        UsarFechas.diferenciaFechas();
                        break;

                    case 4:

                        Console.WriteLine("\n-----------COMPARAR FECHAS-----------");
                        UsarFechas.compararFechas();
                        break;

                    case 5:

                        Console.WriteLine("\n-----------SALIENDO DEL PROGRAMA-----------");
                        salir = true;
                        break;

                    default:

                        Console.WriteLine("\n-----------ELIJE UNA OPCIÓN CORRECTA-----------");
                        break;
                }

                Thread.Sleep(5000);
                Console.Clear();

            } while (!salir);
        }

    }
}
