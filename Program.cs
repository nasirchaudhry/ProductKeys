using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace ProductKeys
namespace ProductKeys
{
    /// <summary>
    /// This program will build a dictionary which will create a product catalog
    /// that uses Product Keys to find products.
    /// </summary>
    class Program
    {
        //private static string Description;

        static void Main(string[] args)
        {
            // Creating a product object
            Product Item = new Product() 
            {
                Description = "Guilty",
                Cost = 78.00,
                Manufacturer = "Gucci",
            };
            Product Item1 = new Product() 
            {
                Description = "Black",
                Cost = 55.00,
                Manufacturer = "Ferragamo",
            };
            Product Item2 = new Product() 
            {
                Description = "Voyage",
                Cost = 40.00,
                Manufacturer = "Nautica",
            };

            // Creating dictionary and adding items in dictionary
            Dictionary<string, Product> catalog = new Dictionary<string, Product>();
            catalog.Add(Item.Description, Item);
            catalog.Add(Item1.Description, Item1);
            catalog.Add(Item2.Description, Item2);

            // Using foreach loop to print all the items in the dictionary
            foreach (Product pro in catalog.Values)
            {                
                Console.WriteLine("Description = {0}, Cost = {1}, Munufacturer = {2}", pro.Description, pro.Cost, pro.Manufacturer);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }       
    }
}