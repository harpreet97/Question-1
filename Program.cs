using System;

namespace Question_1
{
    class Car
    {
        private string _Colour;
        private string _Make;
        private string _Gearbox;

        public string GetColour()
        {
            return this._Colour;
        }

        public void SetColour(string value)
        {
            this._Colour = value;
        }

        public string GetMake()
        {
            return this._Make;
        }

        public void SetMake(string value)
        {
            this._Make = value;

        }
        public string GetGearbox()
        {
            return this._Gearbox;
        }

        public void SetGearbox(string value)
        {
            this._Gearbox = value;
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
            Console.WriteLine("Please enter the colour of the your car?");
            string colour = Console.ReadLine();
            Console.WriteLine("Colour:" + colour);
            obj.SetColour(colour);
            Console.WriteLine("");
            Console.WriteLine("Please enter the make of the your car?");
            string make = Console.ReadLine();
            Console.WriteLine("Make:" + make);
            obj.SetMake(make);
            Console.WriteLine("");
            Console.WriteLine("Please enter the gearbox type of the your car?");
            string gearbox = Console.ReadLine();
            Console.WriteLine("Gearbox type:" +gearbox);
            obj.SetGearbox(gearbox);
            Console.WriteLine("");
            Console.WriteLine(obj.DescribeCar());
        }
    }
}

