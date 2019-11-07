using System;
namespace csharp_inheritance_and_interfaces
{
    public class Gordon : Person 
    {
        public bool hasFacialHair { get; set; }
        public int Weight { get; set; }
        public Gordon()
        {
        }

        public void MixMusic() {
            Console.WriteLine("Gordon's robot is mixing music");
        }

    }
}
