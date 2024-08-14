using GuitarAppOADD.Models;

namespace GuitarAppOADD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            GuitarSpecification spec1 =new GuitarSpecification(12,Builder.FENDER, "Model1", GuitarType.ELECTRIC, Wood.REDWOOD, Wood.ALDER);
            GuitarSpecification spec2 =new GuitarSpecification(10,Builder.FENDER, "Model2", GuitarType.ELECTRIC, Wood.REDWOOD, Wood.MAHOGANY);

            inventory.AddGuitar("101", 10000, spec1);
            inventory.AddGuitar("102", 15000, spec1);
            inventory.AddGuitar("103", 25000, spec2);


            Guitar guitar2 = inventory.GetGuitar("101");
            Console.WriteLine(guitar2);
            Console.WriteLine();
            
            
            GuitarSpecification guitarsearch1 = new GuitarSpecification(12,Builder.FENDER, "Model1", GuitarType.ELECTRIC, Wood.REDWOOD, Wood.ALDER);
            GuitarSpecification guitarsearch2 = new GuitarSpecification(12, Builder.FENDER, "Model1", GuitarType.ACOUSTIC, Wood.REDWOOD, Wood.ALDER);

            List<Guitar> foundGuitars = inventory.SearchGuitar(guitarsearch1);
            PrintAvailableGuitars(foundGuitars);
            Console.WriteLine();
            foundGuitars = inventory.SearchGuitar(guitarsearch2);
            PrintAvailableGuitars(foundGuitars);




        }

        static void PrintAvailableGuitars(List<Guitar> list)
        {
            if (list != null && list.Count > 0)
            {
                Console.WriteLine("Found the following guitars:");
                foreach (Guitar guitar in list)
                {
                    Console.WriteLine(guitar);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No guitars found matching the criteria.");
            }
        }

    }
}
