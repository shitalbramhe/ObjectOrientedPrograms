using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogram
{
    public class InventoryMain
    {
        List<InventoryModel> riceList;
        List<InventoryModel> wheatList;
        List<InventoryModel> pulsesList;
        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    InventoryFactory item = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    riceList = item.Rice;
                    wheatList = item.Wheat;
                    pulsesList = item.Pulses;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayData(string state)
        {
            if (state == "Rice")
            {
                Console.WriteLine("Name\tWeight\tPrice\tTotal\n");
                foreach (var item in riceList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.Price, item.Price * item.Weight);
                }
            }

            if (state == "Wheat")
            {
                Console.WriteLine("Name\tWeight\tPrice\tTotal\n");
                foreach (var item in wheatList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.Price, item.Price * item.Weight);
                }
            }

            if (state == "Pulses")
            {
                Console.WriteLine("Name\tWeight\tPrice\tTotal\n");
                foreach (var item in pulsesList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.Price, item.Price * item.Weight);
                }
            }
        }
    }
}