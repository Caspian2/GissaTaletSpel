using System;

namespace GissaTaletSpel
{
    class Program
    {
            public static Random random = new Random();
            public static bool speletäröver = false;
            public static int hemligtTal = 0;
            public static int gissningar = 0;
            public static string start = "Gissa på ett tal mellan 1 - 100";

            public static bool körom;
        static void Main(string[] args)
        {
            hemligtTal = random.Next(1, 101);  
            int användarTal = 0;   
            
            
            Console.WriteLine(start);
            do
            {  
                användarTal = Convert.ToInt32(Console.ReadLine());
                gissningTal(användarTal);
            }
            while(speletäröver == false); 

                       
        } 

        public static void gissningTal(int användarTal)
        {
                                 
            if(användarTal < hemligtTal)
            {
                Console.WriteLine(användarTal + " är för lågt");
                gissningar+= 1;
            }
            else if(användarTal > hemligtTal)
            {
                Console.WriteLine(användarTal + " är för högt");
                gissningar+= 1;
            }
            else
            {
                Console.WriteLine(hemligtTal + " är rätt");
                Console.WriteLine("Du vann!!!!");
                Console.WriteLine("Du behövde " + gissningar + " försök");
                Console.WriteLine("Om du vill spela igen tryck 1 om du vill sluta tryck 2");

                int input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    körom = true;
                }else if (input == 2)
                {
                    körom = false;
                }

                if(körom == true)
                {
                    hemligtTal = random.Next(1, 101);
                    Console.WriteLine(start);
                    gissningar = 0;
                    speletäröver = false;
                }
                else 
                {
                    speletäröver = true;
                }
            }

        }  
    }
}
