using System;
namespace csharp_inheritance_and_interfaces
{
    public class Tangee : Female
    {
        public string SkinColor { get; set; }
        public bool hasGlasses { get; set; }
        public Tangee()
        {
        }

        public void LaughDifferently()
        {
            Console.WriteLine("Tangee's robot is laughing hysterically");
        }
    }
}
