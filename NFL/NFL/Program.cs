using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.ReadKey();
        }
    }


        class Jatekos
        {
            public string Nev { get; set; }
            public int Yardok { get; set; }
            public int Kiserletek { get; set; }
            public int Passzok { get; set; }
            public int TD { get; set; }
            public int Eladott { get; set; }
            public double Iranymutato { get; set; }
            public string Egyetem { get; set; }

            public Jatekos(string sor)
            {
                string[] s = sor.Split(';');
                Nev = s[0];
                Yardok = Convert.ToInt16(s[1]);
                Kiserletek = Convert.ToInt16(s[2]);
                Passzok = Convert.ToInt16(s[3]);
                TD = Convert.ToInt16(s[4]);
                Eladott = Convert.ToInt16(s[5]);
                Iranymutato = Convert.ToDouble(s[6]);
                Egyetem = s[7];
            }

            private double Konvertal(string iranyitoMutato)
            {
                var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                iranyitoMutato = iranyitoMutato.Replace(",", decimalSeparator).Replace(".", decimalSeparator);
                if (double.TryParse(iranyitoMutato, out var ertek))
                    return ertek;
                throw new FormatException("Hibás érték (irányítómutató)");
            }

            public string FormazottNev(string nev)
            {
                var n = nev.Split(' ');
                n[n.Length - 1] = n[n.Length - 1].ToUpper();
                return string.Join(" ", n);
            }

        }
}
