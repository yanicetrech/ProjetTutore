using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrous_1._0._2
{
    [Serializable]
    public class Product
    {
        static Product prod = new Product(1, "Americain", 6.5);
       
        string B = JsonConvert.SerializeObject(prod);

        

        private int _id;
        private String _name;
        private double _price;

        public Product(int id, String name, double prix)
        {
            _id = id;
            _name = name;
            _price = prix;
        }

        public int Id
        { get { return _id; } }

        public String Name
        { get { return _name; } }

        public double Prix
        { get { return _price; } }

        public override String ToString()
        {
            return "Id:" + Id +
                    "Name:" + Name +
                    "Prix:" + Prix;
        }

        public string getB()
        {
            return B;
        }


    }
}
