using System;

namespace FacadePattern
{
    public class DvdPlayer
    {
        public string Movie { get; set; }

        public void On()
        {
            Console.WriteLine("DVD Player on");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player off");
        }

        public void Play(string movie)
        {
            Movie = movie;
            Console.WriteLine("DVD Player playing " + movie);
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player stopped " + Movie);
        }

        public void Eject()
        {
            Console.WriteLine("DVD Player eject");
        }
    }
}