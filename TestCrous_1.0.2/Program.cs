using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.WebSockets;
using System.Net.Sockets;
using System.Net.WebSockets;

namespace TestCrous_1._0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> produit = new List<Product>();
            Publisher pub = new Publisher();
            Server serv = new Server();

            serv.Test();
            // Http http = new Http();
            //Send env = new Send();
            //env.maMethodePost();
           // Subscriber sub1 = new Subscriber("Le programme", pub);
           // Call the method that raises the event.
           // pub.DoSomething();

      
            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();



           
            




        }
    }
}
