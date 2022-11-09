using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc02properties_knights
{
    internal class Knight
    {
        private string _name;

        public Knight(string name)
        {
            _name = name;
            HP = 10;
        }
        public Knight(string name, int hp)
        {
            _name = name;
            HP = hp;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            if (value != "") _name = value;
        }

        public string Name
        {
            get { return _name; }
            set { if (value != "") _name = value; }
        }

        public string Fullname
        {
            get { return "Sir " + _name; }
        }
        public int HP { get; private set; }

        public void ReceiveDamage(int dmg)
        {
            if (dmg > 0)
            {
                HP -= dmg;
                if (HP < 0) HP = 0;
            }
        }
        public void Attack(Knight target, int damage)
        {
            if (damage > 0)
            {
                target.ReceiveDamage(damage);
            }
        }

        public bool IsAlive { get { return HP > 0; } }
        public bool IsDead { get { return HP <= 0; } }
        public void Heal(Knight target, int amount)
        {
            if (target.IsAlive && amount > 0)
            {
                target.HP += amount;
            }           
        }
        public void Heal(int amount)
        {
            if (this.IsAlive && amount > 0)
            {
                this.HP += amount;
            }
        }
    }
}
