using System;
using System.Globalization;
using static System.Console;

namespace ExemplosCsharp.DataTime
{
    public class IniciandoComDatas
    {
        public static void IniciandoData()
        {
            //Data Padrao
            var data = new DateTime(2020, 10, 12, 8, 23, 14);
            // var data = DateTime.Now;
            WriteLine(data);
            WriteLine(data.Year);
            WriteLine(data.Month);
            WriteLine(data.Day);
            WriteLine(data.Hour);
            WriteLine(data.Minute);
            WriteLine(data.Second);

            WriteLine(data.DayOfWeek);
            WriteLine(data.DayOfYear);
        }

        public static void FormatandoData()
        {
            var data = DateTime.Now;

            // Formatando
            /*
                {0:D} -
                {0:M} -
                {0:Y} - 
                @{0:dd/MM/yyyy hh:mm:ss}
            */

            var formatada = String.Format("{0:D}", data);
            WriteLine(formatada);
        }

        public static void PadraoDeFormatacao()
        {
            var data = DateTime.Now;
            var formatada = String.Format("{0:g}", data);
            WriteLine(formatada);
        }
            // g , f , y , r(melhor) , s(NoSql), u

        public static void AdicionandoValores()
        {
            var data = DateTime.Now;
            WriteLine(data);

            //Melhores praticas
            WriteLine(data.AddDays(12));
            WriteLine(data.AddMonths(1));
            WriteLine(data.AddYears(1));
        }

        public static void ComparacaoDeDatas()
        {
            var data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
                WriteLine("E igual");

            WriteLine(data);
        }

        public static void GlobalizacaoDatas()
        {
            //Data Globalizada
            var dateTime = DateTime.UtcNow;

            WriteLine(dateTime);

            WriteLine(dateTime.ToLocalTime());

            //Aqui voce expecifica o timezone
            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // WriteLine(timezoneAustralia);

            // Listar todos timezone
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                WriteLine(timezone.Id);
                WriteLine(timezone);
                WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
                WriteLine();
            }
        }

        public static void TimeSpans()
        {
            /// <summary>
            /// Utlizados para operação aritmeticas para datas
            /// </summary>
            /// <returns></returns>

            var timeSpan = new TimeSpan();
            WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);
            WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 1000);
            WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }

        public static void RevisaoDatas()
        {
            WriteLine(DateTime.DaysInMonth(2022, 2));
            // WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        }

        // static bool IsWeekend(DayOfWeek today)
        // {
        // return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        // }

    }
}