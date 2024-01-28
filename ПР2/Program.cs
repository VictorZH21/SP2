using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ПР2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                //Console.WriteLine(obj.Properties["Caption"].Value.ToString());
                foreach (PropertyData data in obj.Properties)
                {
                    Console.WriteLine(data.Name + " : " + data.Value);
                }
            }
            Console.ReadKey();
        }
    }
}
