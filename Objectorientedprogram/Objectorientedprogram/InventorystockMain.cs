using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogram
{
    class InventorystockMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Inventorystockmodel>>(json);
                    Console.WriteLine("Stockname\tNumberofshare\tShareprice\tTotal");
                    Console.WriteLine("--------------------------------------------------------");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Stockname, item.Numberofshare, item.Shareprice , item.Numberofshare*item.Shareprice);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
