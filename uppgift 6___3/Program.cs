using System;


namespace uppgift6_3
{
    class program
    {
       static void Main(string[] args)
        {

            Console.WriteLine("välj vad du vill göra");
            Console.WriteLine("1.addera tre tal");
            Console.WriteLine("2.största talet av två tal");
            Console.WriteLine("3.Avsluta programmet");

            string val = Console.ReadLine();

            switch (val)
            {

                case "1":

                    Console.WriteLine("skriv in vad tal1 ska bli");
                    int första = int.Parse(Console.ReadLine());

                    Console.WriteLine("skriv in vad tal2 ska bli");
                    int andra = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in vad tal3 ska bli");
                    int trejde = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"summan av talet blir {addera(första,andra,trejde)}");





                    break;




                case "2":
                    Console.WriteLine("skriv in vad tal1 ska bli");

                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in vad tal2 ska bli");

                    int tal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"det störta talet blir: {störst(tal1, tal2)}");
                    break;



                case "3":
                    Console.WriteLine("programmet avslutats");
                    avsluta();
                    break;



            }
       }

        static int addera(int första, int andra, int trejde)
        {
           
 
            return första + andra + trejde;
            


        }

        static int störst(int tal1, int tal2)
        {

            if (tal1 == tal2)
            {
                return tal1;
            }
            else if (tal2 > tal1)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
          
        }
        static void avsluta()
        {
            return;
        }
    }
}