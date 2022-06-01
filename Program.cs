using System;

namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------WELCOME TO INVENTORY MANAGEMENT SYSTEM----------------------\n\n");

            Seeds seeds = new Seeds();
            Inventory inventory = new Inventory();
            InventoryManagement management = new InventoryManagement();
            management.AddItems();
            management.InventoryManagements();
            management.Display();
            seeds.toString();


        }
    }
}
