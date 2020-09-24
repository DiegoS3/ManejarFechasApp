using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ManejarFechasApp
{
    class UsarFechas
    {

        public static void comprobarDia()
        {

            DateTime fecha = Utiles.pedirFecha(); ;                       

            Console.WriteLine( fecha.ToString("dddd",
                        new CultureInfo("es-ES")));

        }

        public static void incrementarFecha()
        {

            DateTime fecha = Utiles.pedirFecha();
            int dias;

            Console.WriteLine("Cuantos dias quieres incrementar la fecha que has indicado");
            dias = Utiles.pedirNum();

            Console.WriteLine(fecha.AddDays(dias).ToString("dd-MM-yy"));

        }

        public static void diferenciaFechas()
        {
            DateTime fecha = Utiles.pedirFecha();
            DateTime fecha1 = Utiles.pedirFecha();
            //DateTime dif = new DateTime();
            int dias, mes, year;

            if (fecha.Year < fecha1.Year || fecha.Month < fecha1.Month || fecha.Day < fecha1.Day)
            {
                var dif = fecha1 - fecha;
                year = (int)(dif.TotalDays / 365.25);
                mes = (int)(((dif.TotalDays / 365.25) - year) * 12);
                dias = (int)(fecha1.Day - fecha.Day);

                Console.WriteLine("\nAÑOS " + year + " MESES " + mes + " DIAS " + dias );

            }
            else 
            {
                var dif = fecha - fecha1;
                year = (int)(dif.TotalDays / 365.25);
                mes = (int)(((dif.TotalDays / 365.25) - year) * 12);
                dias = (int)(fecha.Day - fecha.Day);

                Console.WriteLine("\nAÑOS " + year + " MESES " + mes + " DIAS " + dias);
            }         

        }

        public static void compararFechas()
        {

            DateTime fecha = Utiles.pedirFecha();
            DateTime fecha1 = Utiles.pedirFecha();
            int dif;

            dif = DateTime.Compare(fecha, fecha1);

            if (dif < 0)
            {
                Console.WriteLine("\nLa fecha de " + fecha.ToString("yyyy/MM/dd") + " es anterior a " + fecha1.ToString("yyyy/MM/dd"));

            }else if (dif == 0)
            {

                Console.WriteLine("\nLas fechas son la misma ");

            }
            else
            {

                Console.WriteLine("\nLa fecha de " + fecha.ToString("yyyy/MM/dd") + " es posterior a " + fecha1.ToString("yyyy/MM/dd"));

            }

        }

    }
}
