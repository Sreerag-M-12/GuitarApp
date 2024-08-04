using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOADD.Models
{
    internal class Guitar
    {
        public string SerialNumber {  get; set; }
        public double Price {  get; set; }

        public GuitarSpecification Specs { get; set; }
     
        public Guitar(string id, double price, GuitarSpecification specs) 
        {
            SerialNumber = id;
            Price = price;
            Specs = specs;
        }

        public override string ToString()
        {
            return $"Serial Number: {SerialNumber} \n" +
                $"Price: {Price} \n" +
                $"Number Strings: {Specs.NumStrings}\n" +
                $"Builder: {Specs.Builder} \n" +
                $"Model: {Specs.Model} \n" +
                $"Type: {Specs.Type} \n" +
                $"Backwood: {Specs.BackWood} \n" +
                $"Topwood: {Specs.TopWood}";
        }
        
    }
}
