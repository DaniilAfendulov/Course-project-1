using System;
using System.Windows.Forms;
using System.Drawing;
using Adventure.Classes;
using System.Collections.Generic;

namespace Adventure
{
    public class Player : Creature
    {
        public new uint HP => base.HP * 10;
        public uint DangeonLvl;
        public uint lvlpoint;
        public int money = new int();
        public Skill[] skills = new Skill[4];
        public Bitmap Skin;
        public Pet pet;
        public Item[] Inventory { get; private set; }
        protected override uint UpValue => (Level * 6 - 5) * Level;

        //TODO: Quests
        public Player(string name, Bitmap skin) : base(name, 100, 100, 100)
        {
            money = 500;
            lvlpoint = Level = 1;
            Expierence = 0; LevelMark = 10;
            DangeonLvl = 0;
            skills[0] = new Skill(Skill.Effect.Buff, 1,100,100,100);
            skills[0].SetShortInfo("простой удар", 1);

            for(int i = 1; i < skills.Length; i++)
            {
                skills[i] = new Skill();
                skills[i].SetShortInfo("пропуск хода", 0);
            }

            Skin = skin;
        }

        public void GetReward(uint PlusExpierence, uint PlusMoney)
        {
            money += (int)PlusMoney;
            AddExpierence(PlusExpierence);
        }
        protected override void NewLevel()
        {
            lvlpoint++;
            base.NewLevel();
        }

        public void AddItems(params Item[] items)
        {
            if (items != null) foreach (Item i in items) AddItem(i);
        }
        private void AddItem(Item item)
        {
            if (item != null && !string.IsNullOrEmpty(item.Name))
            {
                if (Inventory == null) Inventory = new Item[] { item };
                else
                {
                    Item[] TempItem = new Item[Inventory.Length + 1];
                    TempItem[0] = item;
                    Inventory.CopyTo(TempItem, 1);
                    Inventory = TempItem;
                }
            }
        }

        public string[] GetInventoryNames()
        {
            if (Inventory != null)
            {
                string[] InventoryName = new string[Inventory.Length];
                for (int i = 0; i < Inventory.Length; i++) InventoryName[i] = Inventory[i].Name;
                return InventoryName;
            }
            else return null;
        }
        public bool ItemInInventory(string item, out int index)
        {
            index = -1;
            if (!string.IsNullOrEmpty(item) && Inventory != null)
            {
                int i = 0;
                do
                {
                    if (Inventory[i].Name == item)
                    {
                        index = i;
                        return true;
                    }
                    i++;
                } while (i < Inventory.Length);
            }
            return false;
        }

        public void ShowСharacteristics(Label ForCharacter, Label ForPet)
        {
            ForCharacter.Text = ToString() +
                //Использование перечесления Characteristic
                //чтобы сделать понятнее к каким характеристикам
                //относятся элементы массива BonusCharacteristic
                $"\nБонус скорость({BonusCharacteristic(Characteristic.speed)});" +
                $"\nБонус атака({BonusCharacteristic(Characteristic.attack)});" +
                $"\nБонус защита({BonusCharacteristic(Characteristic.defence)});";

            if (pet != null) ForPet.Text = pet.ToString();
            else ForPet.Text = "Нет питомца";
        }
        public int BonusCharacteristic(Characteristic characteristic)
        {
            int bonus = 0;
            switch (characteristic)
            {
                case Characteristic.speed:
                    bonus = pet != null ? (int)pet.Speed : 0;
                    if (Inventory != null) foreach (Item item in Inventory) bonus += (int)item.Speed;
                    break;
                case Characteristic.attack:
                    bonus = pet != null ? (int)pet.Attack : 0;
                    if (Inventory != null) foreach (Item item in Inventory) bonus += (int)item.Attack;
                    break;
                case Characteristic.defence:
                    bonus = pet != null ? (int)pet.Defence : 0;
                    if (Inventory != null) foreach (Item item in Inventory) bonus += (int)item.Defence;
                    break;
            }
            return bonus;
        }

        public override string ToString()
        {
            string[] Сharacteristics = new string[]
            {
                    "Персонаж:",
                    "Имя: "  + Name,
                    "Жизни: " + HP,
                    $"Уровень: {Level} ({Expierence}/{LevelMark})",
                    "Скорость: " + Speed ,
                    "Атака: " + Attack ,
                    "Защита : " + Defence ,
                    "Деньги: " + money,
                    "Очки навыков: " + lvlpoint
            };
            return string.Join("\n", Сharacteristics);
        }
    }
}