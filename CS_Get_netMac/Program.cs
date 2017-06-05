using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace CS_Get_netMac
{
    class Program
    {
		//http://jashliao.pixnet.net/blog/post/222634551-c%23-%E5%8F%96%E5%BE%97%E7%B6%B2%E5%8D%A1%E7%9A%84-mac-address-%5Bgoogle:-%E6%8A%93-%E7%B6%B2%E5%8D%A1-c%23%5D
        static void pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            //List<string> macList = new List<string>();
            foreach (var nic in nics)
            {
                // 因為電腦中可能有很多的網卡(包含虛擬的網卡)，
                // 我只需要 Ethernet 網卡的 MAC
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    //macList.Add(nic.GetPhysicalAddress().ToString());
                    Console.WriteLine(nic.GetPhysicalAddress().ToString());
                }
            }
            pause();
        }
    }
}
