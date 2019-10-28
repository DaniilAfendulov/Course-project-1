using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Classes
{
    public class Enemy : Characteristics
    {
        public readonly uint lvl, ExpirienceReward, MoneyReward;
        private uint hp;
        public List<Skill> Actions;
        public Bitmap Skin;

        public uint HP
        {
            get => hp;
            set => hp = value > 0 ? value : 0;
        }

        public Enemy(string name, uint speed, uint power, uint defence, uint hp,
            uint lvl, uint ExpirienceReward, uint MoneyReward)
            : base(name, speed, power, defence)
        {
            this.lvl = lvl;
            this.ExpirienceReward = ExpirienceReward;
            this.MoneyReward = MoneyReward;
            HP = hp;
        }
    }
}
