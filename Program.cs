using System;

namespace POLYMORPHISM_08._11_
{
    internal class Program
    {
        class String_instruments
        {
            string instruments;
            public int size { get; set; }
            public int number_trings { get; set; }

            public virtual void Show()
            {
                Console.WriteLine("Instrument ::" + instruments);
                Console.WriteLine("Size" + size);
                Console.WriteLine("Number of trings" + number_trings);
            }
        }

        class Guitar : String_instruments
        {
            public string type_of_wood { get; set; }

            public override void Show()
            {
                Console.WriteLine("Type of wood ::" + type_of_wood);
            }
            public void Play()
            {
                Console.WriteLine("Playing...");
            }
        }

        class Electro_guitar : Guitar
        {
            public int pover { get; set; }

            public override void Show()
            {
                Console.WriteLine("Pover ::" + pover);
            }
        }

        class Banjo : String_instruments
        {
            public string material { get; set; }

            public override void Show()
            {
                Console.WriteLine("Material ::" + material);
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
