using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenkenarigirileneskenarucgenincevresi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Klavyeden kenarı girilen eşkenar üçgenin çevresini bulan C# programını yazınız.

            Console.WriteLine("Lütfen üçgenin bir kenarını giriniz");
            int kenar = Int32.Parse(Console.ReadLine());

            int cevre = kenar * 3;

            Console.WriteLine("Üçgenin çevresi=" + cevre);
            Console.ReadLine();


        }
    }
}


