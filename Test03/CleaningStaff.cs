using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class CleaningStaff : Employed
    {
        public CleaningStaff()
        {
            JobExplanation = "Realiza tareas de aseo y limpieza.";
            JobTime = 6;
        }
    }
}