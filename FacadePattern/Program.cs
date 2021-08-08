using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(
                new Amplifier(),
                new DvdPlayer(),
                new CdPlayer(),
                new Projector(),
                new TheaterLights(),
                new Screen(),
                new PopcornPopper()
            );

            homeTheaterFacade.WatchMovie("Avengers");
            Console.WriteLine();
            homeTheaterFacade.EndMovie();

            Console.ReadKey();
        }
    }
}
