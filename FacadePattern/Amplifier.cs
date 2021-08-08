using System;

namespace FacadePattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetDVD()
        {
            Console.WriteLine("Amplifier setting DVD player");
        }

        public void SetSurrondSound()
        {
            Console.WriteLine("Amplifier surround sound on");
        }

        public void SetVolume()
        {
            Console.WriteLine("Amplifier setting volume to 5");
        }
    }
}