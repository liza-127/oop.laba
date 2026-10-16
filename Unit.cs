using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop.laba
{
    public interface Moveable
    {
        void Move(int x, int y);
    }
    public interface Attacker
    {
        void Attack(Unit unit);
    }

    public class Unit: GameObject // класс, описывающий юниты - подразделения, люди, рабочие и т.д.
    {
      
        protected float _gethp;
        protected bool _alive;

        public Unit(int id, string name, int x, int y, float hp) : base(id , name, x, y)
        {
            _gethp = hp;
            _alive = true;
        }

        
        public bool isAlive()
        {
            return _alive;
        }
       public  float getHp()
        {
            return _gethp;
        }

       public void ReceiveDamage(float damage)
        {
            _gethp = _gethp- damage;
            if (_gethp < 0 )
            {
                _gethp = 0;
                _alive = false;
            }
        }
    }
    public class Archer : Unit, Attacker, Moveable // класс описывающий лучника
    {

        private float _damage;

        public Archer(int id, string name, int x, int y, float hp, float demage) : base(id, name, x, y, hp)
        {
            _damage = demage;
        }

       public void Attack(Unit unit)
        {
            unit.ReceiveDamage(_damage);
        }

        public void Move(int x, int y)
        {
            _x = x; 
            _y = y;
        }
    }

}
