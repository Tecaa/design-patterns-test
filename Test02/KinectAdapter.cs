using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test02Lib;

namespace Test02
{
    class KinectAdapter : Cam
    {
        private Kinect kinect;

        public KinectAdapter()  : base()
        {
            kinect = new Kinect("1.5", "video", true);
        }
        public override void Connect()
        {
            kinect.Connect();
            kinect.Configure();
            kinect.Calibrate();
        }

        public override void Disconnect()
        {
            kinect.Disconnect();
        }

        public override void StartRecord()
        {
            kinect.StartRecord();
        }

        public override void StopRecord()
        {
            kinect.StopRecord();
        }
    }
}
