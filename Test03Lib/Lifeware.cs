using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03Lib
{
    public static class Lifeware
    {
        private static List<string> employees;

        static Lifeware()
        {
            employees = new List<string>();
            employees.Add("Juan;aseo;cocinar,comprar");
            employees.Add("Marcela;aseo;");
            employees.Add("Ernesto;portero;");
            employees.Add("Sergio;programador;cocinar,formatear,testing,dj");
            employees.Add("Marcela;programador;formatear");
            employees.Add("Pedro;portero;testing");
            employees.Add("Jorgita;programador;");
        }

        public static List<string> GetEmployeesFromSimulatedDB()
        {
            return employees;
        }
    }
}
