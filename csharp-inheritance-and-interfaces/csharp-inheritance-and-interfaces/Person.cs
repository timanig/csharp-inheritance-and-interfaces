using System;
namespace csharp_inheritance_and_interfaces
{
    public class Person
    {
        public float Height { get; set; }
        public string HairCut { get; set; }
        public Person()
        {
        }


        public void Walk()
        {
            if (this is Female) 
                Console.WriteLine("A female robot is walking");
            else
                Console.WriteLine("A robot is walking");
        }
    }
}
