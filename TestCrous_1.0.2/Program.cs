using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestCrous_1._0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produit> produit = new List<Produit>();
            Category cat = new Category(1,"Sandwich",true);
            Produit prod = new Produit(2, "Americain", 6.5);
            Envoie env = new Envoie();
            env.maMethodePost();

            string A = JsonConvert.SerializeObject(cat);
            string B = JsonConvert.SerializeObject(prod);
           // string C = JsonConvert.SerializeObject;

            Console.WriteLine(A);
            Console.WriteLine(B);

           

            Console.ReadLine();
            




        }
    }
}
