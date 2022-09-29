using System; 
namespace Upggift_3_17
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string x=Console.ReadLine();
           float ö=float.Parse(x);
            Console.WriteLine("Skriv in ett tal till");
            string y=Console.ReadLine();
           float ä=float.Parse(y);
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string a=Console.ReadLine();
            switch (a)
            {
                case "1":
                    float b=ö + ä;
                    Console.WriteLine(b);
                    break;
                    case "2":
                    float c = ö - ä;
                    Console.WriteLine(c);
                    break;
                case "3":
                    float d = ö * ä;
                    Console.WriteLine(d);
                    break;
                case "4":
                    float e = ö / ä;
                    Console.WriteLine(e);
                    break;
            }
        }
    }
}

