using System;

namespace inheritance
{
    class VEHICLE
    {
        public string vbrand = "BMW";
    }
    class CAR : VEHICLE
    {
        public string vcolor = "BLUE";
        static void Main(string[] args)
        {
            CAR obj = new CAR();
            Console.WriteLine(obj.vbrand + " " + obj.vcolor);
        }
    }
}

