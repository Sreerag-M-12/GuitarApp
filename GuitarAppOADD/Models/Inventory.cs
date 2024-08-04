using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOADD.Models
{
    internal class Inventory
    {
        public List<Guitar> Guitars { get; set; }=new List<Guitar>();

        public void AddGuitar(string id, double price, GuitarSpecification specs)
        {
            Guitars.Add(new Guitar(id,price,specs));
        }
        public Guitar GetGuitar(string id) {
            Guitar guitar1 = null;
            foreach (var guitar in Guitars) { 
                if(id == guitar.SerialNumber)
                {
                    guitar1 = guitar;
                }
            }
            return guitar1;
        }
        public List<Guitar> SearchGuitar(GuitarSpecification searchGuitar) {
            List<Guitar> searchGuitars = new List<Guitar>();  
            foreach (Guitar guitar in Guitars) {
                if ((guitar != null) && guitar.Specs.IsMatching(searchGuitar)) 
                { 
                    searchGuitars.Add(guitar);               
                }    
            }
            if (searchGuitars.Count > 0)
                return searchGuitars;
            return null;
        }
    }
}
