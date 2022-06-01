using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class InventoryManagement
    {
        Inventory inn;
        string FilePath = @"C:\Users\HP\Bridgelabz-145\Assignments_\Day 11 & 12\InventoryManagement\InventoryManagement\Inventory.json";

        public InventoryManagement()
        {
            InventoryManagements();
        }
        public void InventoryManagements()
        {
            Console.WriteLine("\n\nSelect Any One Number From Given In Below List :: \n\n");
            Console.WriteLine("1. Add Items :\n");
            Console.WriteLine("2. Display Items :\n");
            Console.WriteLine("3. Exit :\n");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    AddItems();
                    break;
                case 2:
                    Display();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nYou Entered Wrong Number...\n Please Enter Correct Number : \n");
                    InventoryManagements();
                    break;
            }
        }
        public void AddItems()
        {
            Console.WriteLine("---------------- Add Items Which You Want From Given List --------------");
            Console.WriteLine("1. Add Rice Items\n");
            Console.WriteLine("2. Add Pulses Items\n");
            Console.WriteLine("3. Add Wheat Items\n");
            int Selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Brand Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Weight : ");
            long Weight = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Price per kg : ");
            long Price = long.Parse(Console.ReadLine());
            Seeds seed = new Seeds()
            {
                Name = Name,
                Weight = Weight,
                Price = Price,
                TotalPrice = Price * Weight
            };
            string FilePath = @"C:\Users\HP\Bridgelabz-145\Assignments_\Day 11 & 12\InventoryManagement\InventoryManagement\Inventory.json";
            string Read = File.ReadAllText(FilePath);
            if (inn == null)
            {
                inn = new Inventory();
            }
            if (Read.Length != 0)
            {
                inn = JsonConvert.DeserializeObject<Inventory>(Read);
            }
            switch (Selection)
            {
                case 1:
                    if (inn.Rice == null)
                    {
                        inn.Rice = new List<Seeds>();
                    }
                    inn.Rice.Add(seed);
                    break;
                case 2:
                    if (inn.Pulses == null)
                    {
                        inn.Pulses = new List<Seeds>();
                    }
                    inn.Pulses.Add(seed);
                    break;
                case 3:
                    if (inn.Wheat == null)
                    {
                        inn.Wheat = new List<Seeds>();
                    }
                    inn.Wheat.Add(seed);
                    break;
                default:
                    Console.WriteLine("\nYou Entered Wrong Number...\n Please Enter Correct Number : \n");
                    InventoryManagements();
                    break;
            }
            string data = JsonConvert.SerializeObject(inn);
            File.WriteAllText(FilePath, data);
            InventoryManagements();
        }
        public void Display()
        {
            string Read = File.ReadAllText(FilePath);
            inn = JsonConvert.DeserializeObject<Inventory>(Read);
            Console.WriteLine("Enter Any Number from given List :: ");
            Console.WriteLine("1. Rice Details : ");
            Console.WriteLine("2. Pulses Details : ");
            Console.WriteLine("3. Wheat Details : ");
            Console.WriteLine("4. All Items Details : ");
            Console.WriteLine("5. Add Items Again : ");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(select)
            {
                case 1:
                    Console.WriteLine("--------------------------RICE DETAILS---------------------------------\n\n");
                    foreach(var rice in inn.Rice)
                    {
                        Console.WriteLine(rice.toString()+"\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("--------------------------PULSES DETAILS---------------------------------\n\n");
                    foreach (var pulses in inn.Pulses)
                    {
                        Console.WriteLine(pulses.toString() + "\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("--------------------------WHEAT DETAILS---------------------------------\n\n");
                    foreach (var wheat in inn.Wheat)
                    {
                        Console.WriteLine(wheat.toString() + "\n");
                    }
                    break;
                case 4:
                    Console.WriteLine("--------------------------RICE DETAILS---------------------------------\n\n");
                    foreach (var rice in inn.Rice)
                    {
                        Console.WriteLine(rice.toString() + "\n");
                    }
                    Console.WriteLine("--------------------------PULSES DETAILS---------------------------------\n\n");
                    foreach (var pulses in inn.Pulses)
                    {
                        Console.WriteLine(pulses.toString() + "\n");
                    }
                    Console.WriteLine("--------------------------WHEAT DETAILS---------------------------------\n\n");
                    foreach (var wheat in inn.Wheat)
                    {
                        Console.WriteLine(wheat.toString() + "\n");
                    }
                    break;
                case 5:
                    AddItems();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Display();
        }
    }
}
