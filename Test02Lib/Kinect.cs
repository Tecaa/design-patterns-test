using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02Lib
{
    public class Kinect
    {
        public String Version;
        public String Mode;
        public bool Persistent;
        private bool connected, calibrated, configured, recording;

        public Kinect(string version, string mode, bool persistent)
        {
            connected = false;
            calibrated = false;
            configured = false;
            recording = false;


            Version = version;
            Mode = mode;
            Persistent = persistent;
        }

        public void Connect()
        {

            switch (Version)
            {
                case "1.5":
                    // correct
                    break;
                case "1.0":
                case "2.0":
                    throw new Exception("Unsupported version");
                default:
                    throw new Exception("Unknown version");
            }


            switch (Mode)
            {
                case "photo":
                    throw new Exception("Photo mode not available.");
                case "video":
                    // correct
                    break;
                default:
                    throw new Exception("Unknown mode");
            }


            if (!Persistent)
                throw new Exception("Connection mode must be persistent");

            connected = true;
            Console.WriteLine("Connected Kinect");
        }

        public void Configure()
        {
            if (connected)
            {
                configured = true;
                Console.WriteLine("Configured Kinect");
            }
            else
                throw new Exception("Error configuring: is connected?");
        }

        public void Calibrate()
        {
            if (configured)
            {
                calibrated = true;
                Console.WriteLine("Calibrated Kinect");
            }
            else
                throw new Exception("Error calibrating: is configured?");
        }

        public void StartRecord()
        {
            if (connected && configured && calibrated)
            {
                recording = true;
                Console.WriteLine("Kinect: starting record");
            }
            else
                throw new Exception("Error starting record: is calibrated?");
        }

        public void StopRecord()
        {
            if (recording)
            {
                recording = false;
                Console.WriteLine("Kinect: stopping record");
            }
            else
                throw new Exception("Error starting record: is recording?");
        }

        public void Disconnect()
        {

            if (!recording && connected)
            {
                connected = false;
                Console.WriteLine("Disconnecting Kinect");
            }
            else
                throw new Exception("Error disconecting: is connected and stopped?");
        }
    }
}
