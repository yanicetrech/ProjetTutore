using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrous_1._0._2
{
    public class Category
    {
        private int _id { get; set; }
        private String _name { get; set; }
        private bool _isMenu { get; set; }

        public Category(int id, String name, bool isMenu)
        {
            _id = id;
            _name = name;
            _isMenu = isMenu;
        }

        public int Id
        { get { return _id; } }

        public String Name
        { get { return _name; } }

        public bool isMenu
        { get { return _isMenu; } }

        public override String ToString()
        {
            return "Id:" + Id +
                    "Name:" + Name +
                    "True:" + isMenu;
        }
    }
}
