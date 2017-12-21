using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestCrous_1._0._2
{
    //Class that subscribes to an event
    class Subscriber
    {
        private string id;
        Category cat = new Category(1, "Sandwich", true);
        Product prod = new Product(2, "Americain", 6.5);


        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            // Subscribe to the event using C# 2.0 syntax
            pub.RaiseCustomEvent += HandleCustomEvent;
           
            
        }

        

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
             
            Console.WriteLine(id + " a enregistré l'achat qui a été effectué {0}", e.Message);
        }
    }
}
