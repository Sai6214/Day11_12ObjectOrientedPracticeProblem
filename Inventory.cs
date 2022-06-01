using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory
    {
        public List<Seeds> Rice;
        public List<Seeds> Pulses;
        public List<Seeds> Wheat;
    }
    public class Seeds
    {
        public string Name;
        public long Weight;
        public long Price;
        public long TotalPrice;
        public string toString()
        {
            string s = $"Name : {Name}\nWeight : {Weight} \nPrice : {Price}\nTotal Price : {TotalPrice}";
            return s;
            Console.WriteLine(s);
        }

    }
}
