using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class DoorKeeper : Employed
    {
        public DoorKeeper()
        {
            JobExplanation = "Encargado de abrir y cerrar la puerta.";
            JobTime = 5;
        }
    }
}
