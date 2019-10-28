using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Classes
{
    public abstract class Creature : Characteristics
    {
        public uint HP => Level * 100;
        public uint Level { get; protected set; }
        public uint Expierence { get; protected set; }
        public uint LevelMark { get; protected set; }
        protected abstract uint UpValue { get; }

        public Creature(string name, uint speed, uint power, uint defence)
            : base(name, speed, power, defence)
        {
            Level = 1;
            Expierence = 0;
            LevelMark = 10;
        }

        public void AddExpierence(uint PlusExpierence)
        {
            if (PlusExpierence > 0)
            {
                Expierence += PlusExpierence;
                while (Expierence >= LevelMark) NewLevel();
            }
        }
        protected virtual void NewLevel()
        {
            Level++;
            Expierence -= LevelMark;
            LevelMark *= 2;
            UpCharacteristic();
        }
        protected void UpCharacteristic()
        {
            Speed += UpValue;
            Attack += UpValue;
            Defence += UpValue;
        }
    }
}
