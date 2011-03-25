using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            if (appSettings.Count > 0)
            {
                for (int i = 0; i < appSettings.Count; i++)
                {
                    Console.WriteLine("Key: {0}", appSettings.GetKey(i));
                    Console.WriteLine("Value: {0}", appSettings.GetValues(i));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Read();
        }
    }

}
