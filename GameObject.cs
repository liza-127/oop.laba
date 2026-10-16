using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.laba
{
   

    public abstract class GameObject
    {
        protected int _id;
        protected string _name;
        protected int _x;
        protected int _y;

     

        public GameObject(int id, string name, int x, int y)
        {
            _id = id;
            _name = name;
            _x = x;
            _y = y;
        }
        
        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

    }
}
