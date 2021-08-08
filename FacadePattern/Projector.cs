using System;

namespace FacadePattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in wide screen mode");
        }
    }
}