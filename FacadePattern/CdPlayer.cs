using System;

namespace FacadePattern
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("CD Player on");
        }

        public void Off()
        {
            Console.WriteLine("CD Player off");
        }

        public void Play(string movie)
        {
            Console.WriteLine("CD Player playing " + movie);
        }

        public void Stop(string movie)
        {
            Console.WriteLine("CD Player stopped " + movie);
        }

        public void Eject()
        {
            Console.WriteLine("CD Player eject");
        }
    }
}