using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerVariable = 0;


            string stringFormat = " My cake is of type {0} and the flavor is {1}";


            Cake cakeObject = new Cake("Wedding Cake", "Strawberry");
            Console.WriteLine(String.Format(stringFormat, cakeObject.Type, cakeObject.Flavor));


            CakeDTO newDTOCake = new CakeDTO();
                newDTOCake.CakeId = 1;
            newDTOCake.Flavor = "Chocolate";
            newDTOCake.Form = "Square";
            newDTOCake.Size = "Meidum";
            newDTOCake.Type = "Wedding";


        }
    }
}
 
    


    


