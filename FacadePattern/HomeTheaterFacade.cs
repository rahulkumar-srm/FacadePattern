using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        Amplifier amplifier;
        DvdPlayer dvdPlayer;
        CdPlayer cdPlayer;
        Projector projector;
        TheaterLights theaterLights;
        Screen screen;
        PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper)
        {
            this.amplifier = amplifier;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popcornPopper.On();
            popcornPopper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.On();
            amplifier.SetDVD();
            amplifier.SetSurrondSound();
            amplifier.SetVolume();
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }
    }
}
