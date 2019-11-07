using System;

namespace csharp_inheritance_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var robotA = new Ashley()
            {
                Height = 5.6f,
                Weight = 100,
                HairCut = "Short",
                HairColor = "White",
                Interests = "Video Games"
            };
            robotA.Walk();
            robotA.PlayVideoGames();

            var robotB = new Gordon()
            {
                hasFacialHair = false,
                Height = 6.2f,
                Weight = 150,
                HairCut = "Ceaser"
               
            };
            robotB.Walk();
            robotB.MixMusic();



            var robotC = new Tangee()
            {
                HairColor = "Red",
                SkinColor = "Brown",
                HairCut = "Curly",
                Height = 5.7f,
                hasGlasses = true
            };
            robotC.Walk();
            robotC.LaughDifferently();




        }
    }
}
