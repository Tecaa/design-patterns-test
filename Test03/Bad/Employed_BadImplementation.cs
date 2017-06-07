using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    public class Employed_BadImplementation
    {
        public string Name;
        public EmployedType Type;
        public List<Extras> Extras;
        public string JobExplanation;

        public Employed_BadImplementation(string formatedText)
        {
            Extras = new List<Extras>();
            string[] ss = formatedText.Split(';');
            Name = ss[0];
            
            switch (ss[1])
            {
                case "aseo":
                    Type = EmployedType.Aseo;
                    break;
                case "programador":
                    Type = EmployedType.Programador;
                    break;
                case "portero":
                    Type = EmployedType.Portero;
                    break;
                default:
                    throw new Exception("Unknown employ type");
            }

            string[] extras = ss[2].Split(',');
            foreach(string extra in extras)
            {
                switch(extra)
                {
                    case "cocinar":
                        Extras.Add(Test03.Extras.Cocinar);
                        break;
                    case "comprar":
                        Extras.Add(Test03.Extras.Comprar);
                        break;
                    case "formatear":
                        Extras.Add(Test03.Extras.Formatear);
                        break;
                    case "testing":
                        Extras.Add(Test03.Extras.Testing);
                        break;
                    case "dj":
                        Extras.Add(Test03.Extras.DJ);
                        break;
                }
            }
            
        }

        public Employed_BadImplementation(string name, EmployedType type, List<Extras> extras)
        {
            Name = name;
            Type = type;
            Extras = extras;
        }

        public int GetJobTime()
        {
            int total = 0;
            switch (this.Type)
            {
                case EmployedType.Aseo:
                    total = 6;
                    break;
                case EmployedType.Portero:
                    total = 5;
                    break;
                case EmployedType.Programador:
                    total = 8;
                    break;
            }

            foreach (Extras ex in Extras)
            {
                switch (ex)
                {
                    case Test03.Extras.Cocinar:
                        total += 3;
                        break;
                    case Test03.Extras.Comprar:
                        total += 2;
                        break;
                    case Test03.Extras.Formatear:
                        total += 3;
                        break;
                    case Test03.Extras.Testing:
                        total += 4;
                        break;
                    case Test03.Extras.DJ:
                        total += 1;
                        break;
                }
            }
            return total;
        }


        public string GetJobExplanation()
        {
            string explanation = String.Empty;
            switch(this.Type)
            {
                case EmployedType.Aseo:
                    explanation = "Realiza tareas de aseo y limpieza.";
                    break;
                case EmployedType.Portero:
                    explanation = "Encargado de abrir y cerrar la puerta.";
                    break;
                case EmployedType.Programador:
                    explanation = "Encargado de desarrollar software.";
                    break;
            }
            
            foreach (Extras ex in Extras)
            {
                switch (ex)
                {
                    case Test03.Extras.Cocinar:
                        explanation += " Cocina todos los días.";
                        break;
                    case Test03.Extras.Comprar:
                        explanation += " Realiza las compras.";
                        break;
                    case Test03.Extras.Formatear:
                        explanation += " Formatea los computadores.";
                        break;
                    case Test03.Extras.Testing:
                        explanation += " Realiza pruebas de calidad del software.";
                        break;
                    case Test03.Extras.DJ:
                        explanation += " Encargado de la música del lugar de trabajo.";
                        break;
                }
            }
            return explanation;
        }
    }
}
