using System;

namespace Question_1
{
    class Car
    {
        private string colour;
        private string make;
        private string gearbox;

        public string GetColour()
        {
            return colour;
        }

        public void SetColour(string col)
        {
            colour = col;
        }

        public string GetMake()
        {
            return make;
        }

        public void SetMake(string mk)
        {
            make = mk;

        }
        public string GetGearbox()
        {
            return gearbox;
        }

        public void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }

        public string DescribeCar()
        {

            return string.Format("This car is a {0} {1} with a {2} transmission.", GetColour(), GetMake(), GetGearbox());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine("Enter new car details below");
            Console.WriteLine("*****************************************");
            Console.Write("Colour: ");
            string col = Console.ReadLine();
            obj.SetColour(col);
            Console.WriteLine("");

            Console.Write("Make: ");
            string mk = Console.ReadLine();
            obj.SetMake(mk);
            Console.WriteLine("");

            Console.Write("Gearbox type: " );
            string gbox = Console.ReadLine();
            obj.SetGearbox(gbox);
            Console.WriteLine("");
            Console.WriteLine(obj.DescribeCar());
        }
    }
}
