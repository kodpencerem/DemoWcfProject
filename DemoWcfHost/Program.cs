﻿using System;
using System.ServiceModel;

namespace DemoWcfHost
{
    public class Program
    {
        static void Main()
        {

            using (ServiceHost host = new ServiceHost(typeof(DemoWcfProject.MessageService)))
            {
                host.Open();
                Console.WriteLine("Host is started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
