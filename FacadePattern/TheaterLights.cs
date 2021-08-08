using System;

namespace FacadePattern
{
    public class TheaterLights
    {
        public void Dim(int intensity)
        {
            Console.WriteLine("Theater Ceiling lights dimming to " + intensity + "%");
        }

        public void On()
        {
            Console.WriteLine("Theater Ceiling on");
        }
    }
}