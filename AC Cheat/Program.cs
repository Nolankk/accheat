using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ReadWriteMemory;


class Program
{
    public static int localBase = 0x509B74;
    public static int health = 0xF8;
    public static int enemyBase = 0x50F4F8;

    static void Main(string[] args)
    {
        ProcessMemory vam = new ProcessMemory("ac_client");

        if (vam.CheckProcess())
        {
            vam.StartProcess();
        }

        int LocalPlayer = vam.ReadInt(localBase);

        while (true)
        {
            int addressHealth = LocalPlayer + health;

            vam.WriteInt(addressHealth, 9999999);

            Thread.Sleep(100);
        }
    }
}
