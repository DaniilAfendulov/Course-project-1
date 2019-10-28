using Adventure.Forms;
using System;
using System.Collections.Generic;

namespace Adventure.Classes
{
    public class Skill
    {
        public enum Effect : int
        {
            Buff,
            Debuff
        }
        public enum Attacker : int
        {
            Enemy,
            Player
        }

        public uint Energy;

        private Characteristic current, temp;
        private string name;
        public uint Cost { get; private set; }

        public static BattleForm battleForm;
        public static Player character;
        public static Enemy enemy;

        private readonly string nl = Environment.NewLine;

        public uint GetAttackProbability(Attacker person)
        {
            if (person == Attacker.Enemy)
            {
                if (enemy.Speed >= character.Speed) return 100;
                else return 100 - (character.Speed / enemy.Speed) % 101;
            }
            else
            {
                if (character.Speed >= enemy.Speed) return 100;
                else return 100 - (enemy.Speed / character.Speed) % 101;
            }
        }


        //параметры указывают проценты от бафа или дебафа
        //int attack, int defence, int speed
        //(int)enemy.Power * BuffAttack / 100;

        public Skill(uint Energy,
            uint BuffAttack, uint BuffDefence, uint BuffSpeed,
            uint DebuffAttack, uint DebuffDefence, uint DebuffSpeed)
        {
            this.Energy = Energy;
            current.DebuffAttack = DebuffAttack;
            current.DebuffDefence = DebuffDefence;
            current.DebuffSpeed = DebuffSpeed;
            current.BuffAttack = BuffAttack;
            current.BuffDefence = BuffDefence;
            current.BuffSpeed = BuffSpeed;
        }


        public Skill(Effect effect, uint Energy,
           uint Attack, uint Defence, uint Speed)
        {
            this.Energy = Energy;
            if (Effect.Buff == effect)
            {
                current.BuffAttack = Attack;
                current.BuffDefence = Defence;
                current.BuffSpeed = Speed;
                current.DebuffAttack = current.DebuffDefence = current.DebuffSpeed = 100;
            }
            else
            {
                current.DebuffAttack = Attack;
                current.DebuffDefence = Defence;
                current.DebuffSpeed = Speed;
                current.BuffDefence = current.BuffSpeed = 100;
                current.BuffAttack = 0;
                // здесь не атакуют
            }
        }

        public Skill()
        {
            current.DebuffAttack = current.DebuffDefence = current.DebuffSpeed = 100;
            current.BuffDefence = current.BuffSpeed = 100;
            current.BuffAttack = 0;
        }

        public override string ToString()
        {
            List<string> about = new List<string>();
            if(!string.IsNullOrEmpty(name)) about.Add(name);
            if(Cost != 0) about.Add("Стоимость: " + Cost);
            about.Add("Энергия " + Energy);
            if(current.BuffAttack != 0) about.Add("атака " + current.BuffAttack + "%");
            if (current.BuffDefence != 100) about.Add("защита " + current.BuffDefence + "%");
            if (current.BuffSpeed != 100) about.Add("скорость " + current.BuffSpeed + "%");
            if (current.DebuffAttack != 100 || current.DebuffDefence != 100 
                || current.DebuffSpeed != 100) about.Add("влияние на врага: ");
            if (current.DebuffAttack != 100) about.Add("атака -" + (100 - current.DebuffAttack) + "%");
            if (current.DebuffDefence != 100) about.Add("защита -" + (100 - current.DebuffDefence) + "%");
            if (current.DebuffSpeed != 100) about.Add("скорость -" + (100 - current.DebuffSpeed) + "%");

            return string.Join(nl, about.ToArray());
        }

        public string ShortInfo() => name + nl + "Стоимость: " + Cost;
        public string FullInfo() => ShortInfo() + nl + ToString();

        public void SetShortInfo(string name, uint cost)
        {
            this.name = name;
            Cost = cost;
        }

        public static void SetBattle(BattleForm battleForm, Player character, Enemy enemy)
        {
            Skill.battleForm = battleForm;
            Skill.character = character;
            Skill.enemy = enemy;
        }

        //Person - тот кто атакует
        //метод использует ссылки на структуры CurrentPoint
        //чтобы сохранить значения структур в методе
        //затем изменить их на время действия метода
        //и, после, вернуть им изначальные значения
        public bool Do(Attacker creature, ref CurrentPoint CharacterPoint, ref CurrentPoint EnemyPoint)
        {
            
            Random rand = new Random();           

            if (creature == Attacker.Enemy)
            {
                temp = new Characteristic(Attacker.Enemy, ref CharacterPoint, ref EnemyPoint);

                EnemyPoint.attack = EnemyPoint.attack * (uint)current.BuffAttack / 100;
                EnemyPoint.defence = EnemyPoint.defence * (uint)current.BuffDefence / 100;
                EnemyPoint.speed = EnemyPoint.speed * (uint)current.BuffSpeed / 100;

                CharacterPoint.attack = CharacterPoint.attack * (uint)current.DebuffAttack / 100;
                CharacterPoint.defence = CharacterPoint.defence * (uint)current.DebuffDefence / 100;
                CharacterPoint.speed = CharacterPoint.speed * (uint)current.DebuffSpeed / 100;

                if (GetAttackProbability(creature) == 100 || rand.Next(100) <= GetAttackProbability(creature))
                {
                    if (CharacterPoint.defence < EnemyPoint.attack)
                    {
                        if (CharacterPoint.HP <= -CharacterPoint.defence + EnemyPoint.attack) CharacterPoint.HP = 0;
                        else CharacterPoint.HP += CharacterPoint.defence - EnemyPoint.attack;                        
                    }
                    temp.Back(Attacker.Enemy, ref CharacterPoint, ref EnemyPoint);
                    return true;
                }
                temp.Back(Attacker.Enemy, ref CharacterPoint, ref EnemyPoint);
                return false;
            }
            else
            {
                temp = new Characteristic(Attacker.Player, ref CharacterPoint, ref EnemyPoint);

                CharacterPoint.attack = CharacterPoint.attack * current.BuffAttack / 100;
                CharacterPoint.defence = CharacterPoint.defence * current.BuffDefence / 100;
                CharacterPoint.speed = CharacterPoint.speed * current.BuffSpeed / 100;

                EnemyPoint.attack = EnemyPoint.attack * current.DebuffAttack / 100;
                EnemyPoint.defence = EnemyPoint.defence * current.DebuffDefence / 100;
                EnemyPoint.speed = EnemyPoint.speed * current.DebuffSpeed / 100;

                if (GetAttackProbability(creature) == 100 || rand.Next(100) <= GetAttackProbability(creature))
                {
                    if (EnemyPoint.defence < CharacterPoint.attack)
                    {
                        if (EnemyPoint.HP <= -EnemyPoint.defence + CharacterPoint.attack) EnemyPoint.HP = 0;
                        else EnemyPoint.HP += EnemyPoint.defence - CharacterPoint.attack;
                    }
                    temp.Back(Attacker.Player, ref CharacterPoint, ref EnemyPoint);
                    return true;
                }
                temp.Back(Attacker.Player, ref CharacterPoint, ref EnemyPoint);
                return false;
            }

        }

        private struct Characteristic
        {
            public uint BuffAttack, BuffDefence, BuffSpeed;
            public uint DebuffAttack, DebuffDefence, DebuffSpeed;
            public Characteristic(Attacker person, ref CurrentPoint CharacterPoint, ref CurrentPoint EnemyPoint)
            {
                if(person == Attacker.Enemy)
                {
                    BuffAttack = EnemyPoint.attack;
                    BuffDefence = EnemyPoint.defence;
                    BuffSpeed = EnemyPoint.speed;

                    DebuffAttack = CharacterPoint.attack;
                    DebuffDefence = CharacterPoint.defence;
                    DebuffSpeed = CharacterPoint.speed;
                }
                else
                {
                    BuffAttack = CharacterPoint.attack;
                    BuffDefence = CharacterPoint.defence;
                    BuffSpeed = CharacterPoint.speed;

                    DebuffAttack = EnemyPoint.attack;
                    DebuffDefence = EnemyPoint.defence;
                    DebuffSpeed = EnemyPoint.speed;
                }
            }

            public void Back(Attacker person, ref CurrentPoint CharacterPoint, ref CurrentPoint EnemyPoint)
            {
                if (person == Attacker.Enemy)
                {
                    EnemyPoint.attack = BuffAttack;
                    EnemyPoint.defence = BuffDefence;
                    EnemyPoint.speed = BuffSpeed;

                    CharacterPoint.attack = DebuffAttack;
                    CharacterPoint.defence = DebuffDefence;
                    CharacterPoint.speed = DebuffSpeed;
                }
                else
                {
                    CharacterPoint.attack = BuffAttack;
                    CharacterPoint.defence = BuffDefence;
                    CharacterPoint.speed = BuffSpeed;

                    EnemyPoint.attack = DebuffAttack;
                    EnemyPoint.defence = DebuffDefence;
                    EnemyPoint.speed = DebuffSpeed;
                }
            }

        }


    }
}
