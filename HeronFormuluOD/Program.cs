using System;

namespace HeronFormuluOD
{
    class Program
    {

        static void HeronBulmak()
        {

            Console.Write("1.Kenar ölçüsünü giriniz : ");
            double kenar1 = Convert.ToDouble(Console.ReadLine() );

            Console.Write("2.kenar ölçüsünü giriniz : ");
            double kenar2 = Convert.ToDouble(Console.ReadLine()  );

            Console.Write("3.kenar ölcüsünü giriniz : ");
            double kenar3 = Convert.ToDouble(Console.ReadLine() );

            double u = (kenar1 + kenar2 + kenar3) / 2;

            double Alan = Math.Sqrt(u * (u - kenar1) * (u - kenar2) * (u - kenar3)); 
            
            Console.WriteLine($"Alan :" + Alan);

            Console.Read();
        }

        static void DaireDiliminiBulmak()
        {

            const double pi = 3.14;

            Console.Write("Yarıçap ölçüsünü giriniz :");
            double yaricap = Convert.ToDouble(Console.ReadLine() );

            Console.Write("Açıyı giriniz :");
            double aci = Convert.ToDouble(Console.ReadLine() );

            double alan = (aci * pi * yaricap * yaricap) /360 ;
            Console.WriteLine($"Alan : " + alan);

            Console.Read();

        }

        static void Main(string[] args)
        {
          
            // ******* Pisagoru Bulmak *******
            Console.Write("1.Kenar ölçüsünü giriniz : ");
            double kenar1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.Kenar ölçüsünü giriniz : ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());

            double kenar3 = Math.Sqrt(kenar1 * kenar1 + kenar2 * kenar2);

            Console.WriteLine($"Hipotenüs : " + kenar3);

            Console.Read(); 
            
            HeronBulmak();
            DaireDiliminiBulmak();
        }
    }
}
