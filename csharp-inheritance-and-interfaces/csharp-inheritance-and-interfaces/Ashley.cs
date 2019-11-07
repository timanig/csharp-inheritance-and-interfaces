using System;
namespace csharp_inheritance_and_interfaces
{
    public class Ashley : Female
    {
        public int Weight { get; set; }
        public string Interests { get; set; }
        public Ashley()
        {
        }

        public void PlayVideoGames()
        {
            Console.WriteLine("Ashley's robot is playing video games");
        }

        
    }
}
