using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02Lib2
{
    public class infrared_rgb_cam
    {
        public enum mode { infrared, rgb };
        public mode? _mode;
        private bool recording, connected;
        
        public infrared_rgb_cam()
        {
            _mode = null;
            recording = false;
            connected = false;
        }

        public void connect_infrared_rgb_cam()
        {
            Console.WriteLine("connect_infrared_rgb_cam");
            connected = true;
        }

        

        public void start_record()
        {
            if (connected && _mode != null)
            {
                switch (_mode)
                {
                    case mode.infrared:
                        throw new Exception("Error: damaged infrared");
                    case mode.rgb:
                        recording = true;
                        Console.WriteLine("rgb start record");
                        break;
                }
            }
            else
                throw new Exception("Error: mode not set?");
        }

        public void stop_record()
        {
            if (connected && recording)
            {
                recording = false;
                Console.WriteLine("infrared_rgb_cam: stopping record");
            }
            else
                throw new Exception("Error starting record: is recording?");
        }

        public void disconnect_infrared_rgb_cam()
        {

            if (!recording && connected)
            {
                connected = false;
                Console.WriteLine("disconnected infrared rgb cam");
            }
            else
                throw new Exception("Error disconecting: is connected and stopped?");
        }
    }
}
