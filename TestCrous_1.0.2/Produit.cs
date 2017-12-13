using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrous_1._0._2
{
    public class Produit
    {
        private int _id;
        private String _name;
        private double _prix;

        public Produit(int id, String name, double prix)
        {
            _id = id;
            _name = name;
            _prix = prix;
        }

        public int Id
        { get { return _id; } }

        public String Name
        { get { return _name; } }

        public double Prix
        { get { return _prix; } }

        public override String ToString()
        {
            return "Id:" + Id +
                    "Name:" + Name +
                    "Prix:" + Prix;
        }



    }
}
