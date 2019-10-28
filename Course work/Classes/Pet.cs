using Adventure.Classes;
using System.Collections;
using System.Windows.Forms;

namespace Adventure
{
    public class Pet : Creature
    {
        protected override uint UpValue => (Level* 6 - 5) * Level / 2;
        public new uint HP => base.HP * 5;
        public Pet(string name, uint speed, uint power, uint defence) 
            : base(name, speed, power, defence)
        {
        }
        public Pet(Pet pet)
            : base(pet.Name, pet.Speed, pet.Attack, pet.Defence)
        {
            Expierence = pet.Expierence;
            Level = pet.Level;
            Expierence = pet.Expierence;
            LevelMark = pet.LevelMark;
            Name = pet.Name;
        }

        public override string ToString()
        {
            string[] hint = new string[]
            {
                "Питомец:\n",
                "Имя: "  + Name,
                $"Уровень: {Level} ({Expierence}/{LevelMark})",
                "скорость: " + Speed,
                "атака: " + Attack,
                "жизни: " + Defence,
                "прирост жизней: " + HP
            };
            return string.Join("\n", hint);
        }

    }
}
