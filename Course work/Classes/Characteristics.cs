using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public abstract class Characteristics
    {
        public enum Characteristic : int
        {
            speed,
            attack,
            defence
        }
        public string Name { get; protected set; }
        public uint Speed { get; protected set; }
        public uint Attack { get; protected set; }
        public uint Defence { get; protected set; }
        protected Characteristics(string name, uint speed, uint attack, uint defence)
        {
            Name = name;
            Speed = speed;
            Attack = attack;
            Defence = defence;
        }
    }
}
