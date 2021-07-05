using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigSetupProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = System.Configuration.ConfigurationManager.AppSettings["TestApp:Settings:Message"];

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
