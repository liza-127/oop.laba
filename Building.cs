using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop.laba
{
    public class Building : GameObject
    {
        protected bool _built;

        public Building(int id, string name, int x, int y)
            : base(id, name, x, y)
        {
            _built = false;
        }

        public bool IsBuilt()
        {
            return _built;

        }
    }
    public class Fort : Building, Attacker
    {
        private float _damage;

        public Fort(int id, string name, int x, int y, float damage)
            : base(id, name, x, y)
        {
            _damage = damage;
        }

        public void Attack(Unit unit)
        {
            unit.ReceiveDamage(_damage);
        }
    }
    public class MobileHouse: Building, Moveable
    {
        public MobileHouse(int id, string name, int x, int y)
           : base(id, name, x, y)
        {
        }

        public void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

}
