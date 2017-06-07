using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test03Lib;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> formated = Lifeware.GetEmployeesFromSimulatedDB();
            //List<EmployedOLD> emps = new List<Test03.EmployedOLD>();

            //foreach (string emp in formated)
            //{
            //    EmployedOLD e = new Test03.EmployedOLD(emp);

            //    Console.WriteLine(e.Name + "\t" + e.Type + "\t" + e.GetJobTime() + "\t" + e.GetJobExplanation());
            //    emps.Add(e);
            //}
            //Console.ReadKey();

            List<string> formated = Lifeware.GetEmployeesFromSimulatedDB();
            List<Employed> emps = new List<Test03.Employed>();

            foreach (string emp in formated)
            {
                Employed e = new Test03.Employed(emp);

                Console.WriteLine(e.Name + "\t" + e.Type + "\t" + e.GetJobTime() + "\t" + e.GetJobExplanation());
                emps.Add(e);
            }
            Console.ReadKey();
        }
    }
}
