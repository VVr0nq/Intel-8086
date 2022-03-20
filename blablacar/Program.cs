using System;


namespace Architektura_Systemów
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zawartosc rejestru AL");
            String AL = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru AH");
            String AH = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru BL");
            String BL = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru BH");
            String BH = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru CL");
            String CL = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru CH");
            String CH = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru DL");
            String DL = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj zawartosc rejestru DH");
            String DH = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Podaj rozkaz do symulacjii 'mov' lub 'xchg'");
            String rozkaz = Console.ReadLine();

            if (rozkaz == "mov")
            {
                Console.WriteLine("Podaj pierwszy rejestr rozkazu");
                Console.ReadLine();
                Console.WriteLine("Podaj drugi rejestr rozkazu");
                Console.ReadLine();
            }

            else if (rozkaz == "xchg")
            {
                Console.WriteLine("Podaj pierwszy rejestr rozkazu");
                Console.ReadLine();
                Console.WriteLine("Podaj drugi rejestr rozkazu");
                Console.ReadLine();
            }




























        }
    }
}