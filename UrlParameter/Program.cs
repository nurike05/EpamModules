using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UrlParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var timespan = new TimeSpan(0, 5, 0);
            //var timespan2 = TimeSpan.FromMinutes(5);
            ////var dateTime = new DateTime(2018, 12, 1, 0, 5, 0);
            //var dateTime2 = new DateTime(2018, 12, 1, 0, 0, 0);
            //var timespan3 = dateTime - dateTime2;
            //Console.WriteLine(timespan3);
            //var dateTimeOffset = new DateTimeOffset(2018, 12, 1, 0, 5, 0,
            //new TimeSpan(4, 0, 0));
            //var dateTime2Offset = new DateTimeOffset(2018, 12, 1, 0, 0, 0,
            //new TimeSpan(5, 0, 0));
            //var timespan4 = dateTimeOffset - dateTime2Offset;
            //Console.WriteLine(timespan4);


            //var myNumberFormatInfo = new NumberFormatInfo();
            //myNumberFormatInfo.CurrencySymbol = "$$";
            //myNumberFormatInfo.CurrencyDecimalDigits = 3;
            //double d = 125.5;
            //Console.WriteLine(d.ToString("C", myNumberFormatInfo));
            ////”$$125.500”
            //var str = "$$123.500";
            // d = double.Parse(str, NumberStyles.Currency, myNumberFormatInfo);
            //Console.WriteLine(d);//”123,5” в культуре ru-Ru
            //myNumberFormatInfo.NumberDecimalSeparator = "$";
            //str = "234$500";
            //d = double.Parse(str, myNumberFormatInfo);
            //Console.WriteLine(d);
            ////другой способ:
            //var cultureInfo = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            //cultureInfo.NumberFormat.NumberDecimalSeparator = "$";
            //str = "234$500";
            //d = double.Parse(str, cultureInfo);


            //var myNumberFormatInfo = new NumberFormatInfo();
            //var myDateTimeFormatInfo = new DateTimeFormatInfo();
            //myDateTimeFormatInfo.ShortDatePattern = "dd.MM.yyyy";
            //myDateTimeFormatInfo.AbbreviatedMonthNames = "Январь,Февраль,Март,Апрель,Май,Июнь,Июль,Август,Сентябрь,Октябрь,Ноябрь,Декабрь,".Split(',');
            //Console.WriteLine(DateTime.Today.ToString(myDateTimeFormatInfo));//15.Июль.2018 00:00:00
            //DateTime dateTime = DateTime.Parse("15.Январь.2018", myNumberFormatInfo);
            //Console.WriteLine(dateTime);//15.01.2018 0:00:00

            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("t"));
            Console.WriteLine(dateTime.ToString("o"));
            Console.ReadLine();
        }
        
    }
}
