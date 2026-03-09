using System;

namespace GadgetHub
{
    public class GadgetFactory
    {
        public static Gadget GetGadget(string type, string name)
        {
            if (string.Equals(type, "mobile", StringComparison.OrdinalIgnoreCase))
            {
                return new MobileGadget(name);
            }
            else if (string.Equals(type, "laptop", StringComparison.OrdinalIgnoreCase))
            {
                return new LaptopGadget(name);
            }
            else
            {
                Console.WriteLine("Invalid gadget type");
                return null;
            }
        }
    }
}
