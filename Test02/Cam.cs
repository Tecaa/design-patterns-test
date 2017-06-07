using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    public abstract class Cam
    {
        abstract public void Connect();
        abstract public void StartRecord();
        abstract public void StopRecord();
        abstract public void Disconnect();
    }
}
