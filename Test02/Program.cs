using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test02Lib;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cam c = new WebCam();
            c.Connect();
            c.StartRecord();
            c.StopRecord();
            c.Disconnect();

            Cam c2 = new KinectAdapter();
            c2.Connect();
            c2.StartRecord();
            c2.StopRecord();
            c2.Disconnect();

            Cam c3 = new InfraredRGBCamAdapter();
            c3.Connect();
            c3.StartRecord();
            c3.StopRecord();
            c3.Disconnect();

            Console.ReadKey();
        }
    }
}
