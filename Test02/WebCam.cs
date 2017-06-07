using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    public class WebCam : Cam
    {
        public WebCam() : base()
        {
        }
        public override void Connect()
        {
            Console.WriteLine("WebCam connect");
        }

        public override void Disconnect()
        {
            Console.WriteLine("WebCam disconnect");
        }

        public override void StartRecord()
        {
            Console.WriteLine("WebCam start record");
        }

        public override void StopRecord()
        {
            Console.WriteLine("WebCam stop record");
        }
    }
}
