using System;

namespace BakeryShoppingCart.Models
{
    public class Cake
    {
        public int CakeId { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Form { get; set; }

        public string Flavor { get; set; }

        public Cake() { }

        public Cake(string type, string flavor)
        {
            this.Type = type;
            this.Flavor = flavor;
        }

        // public Role Role { get; set; }

        public virtual void AddFlavor()
        {
            //this.Flavor = "Chocolate";

            Console.WriteLine("You are adding a flavor");
        }
        //public void AddFlavor(string NewFlavor);
        //   {
        //this.Flavor = NewFlavor;
        //}

    }
}

