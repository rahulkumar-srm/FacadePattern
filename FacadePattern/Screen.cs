using System;

namespace FacadePattern
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen going up");
        }

        public void Down()
        {
            Console.WriteLine("Screen going down");
        }
    }
}