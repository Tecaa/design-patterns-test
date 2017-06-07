using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test02Lib2;

namespace Test02
{
    class InfraredRGBCamAdapter : Cam
    {
        private infrared_rgb_cam rgbCam;

        public InfraredRGBCamAdapter() : base()
        {
            rgbCam = new Test02Lib2.infrared_rgb_cam();
        }

        public override void Connect()
        {
            rgbCam.connect_infrared_rgb_cam();
            rgbCam._mode = infrared_rgb_cam.mode.rgb;
        }

        public override void Disconnect()
        {
            rgbCam.disconnect_infrared_rgb_cam();
        }

        public override void StartRecord()
        {
            rgbCam.start_record();
        }

        public override void StopRecord()
        {
            rgbCam.stop_record();
        }
    }
}
