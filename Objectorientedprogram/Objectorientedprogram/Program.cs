using System;

namespace Objectorientedprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nWelcome to Object Oriented Programs"); 
                Console.WriteLine("Enter Progran number to get excuted \n1. Inventory management \n2. Extend Inventory data management \n3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain Data = new InventoryMain();
                        Data.DisplayData(@"E:\RFP\ObjectOrientedPrograms\Objectorientedprogram\Objectorientedprogram\NewFolder\Inventory.json");
                        break;
                    case 2:
                        InventoryMain manage = new InventoryMain();
                        manage.ReadData(@"E:\RFP\ObjectOrientedPrograms\Objectorientedprogram\Objectorientedprogram\NewFolder\Inventory.json");
                        manage.DisplayData("Rice");
                        manage.DisplayData("Wheat");
                        manage.DisplayData("Pulses");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
