using System;
using System.Windows.Forms;
using Приключение.Forms;
using Adventure.Forms;
using Adventure.Classes;
using Adventure.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace Adventure
{
    public partial class MainForm : Form
    {
        private delegate Skill EnemySkill ();
        private readonly Player character;
        private InventoryForm inventoryForm;
        private ShopForm shopForm;
        private BattleForm battleForm;
        private SkillsForm skillsForm;
        private List<Enemy> enemies;
        public MainForm()
        {
            InitializeComponent();
            character = new Player("main", null);
            character.ShowСharacteristics(СharacteristicsLabel, PetLabel);
            enemies = new List<Enemy>();
            EnemiesCreate();
        }

        private void EnemiesCreate()
        {
            enemies.Add(new Enemy("Zero", 10, 300, 10, 1000, 1, 10, 1000));

            enemies[0].Actions = new List<Skill>
            {
                new Skill(Skill.Effect.Buff, 1,100,100,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,100,110,100),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(Skill.Effect.Buff, 4,500,100,100),
            };
            enemies[0].Skin = (Bitmap)Image.FromFile("../../Data/Bitmap1.bmp");

            enemies.Add(new Enemy("Единонос", 280, 180, 190, 1500, 2, 30, 1800));
            enemies[1].Actions = new List<Skill>
            {
                new Skill(),
                new Skill(Skill.Effect.Debuff, 2, 100, 100, 90),
                new Skill(),
                new Skill(),
                new Skill(Skill.Effect.Buff, 3, 300, 100, 150),
                new Skill(),
                new Skill(Skill.Effect.Buff, 1, 100, 100, 100),
                new Skill(),
                new Skill(),
                new Skill(Skill.Effect.Buff, 4, 600,100,110),
            };
            enemies[1].Skin = (Bitmap)Image.FromFile("../../Data/Uninose.png");

            enemies.Add(new Enemy("Knight", 150, 200, 320, 2000, 3, 100, 3000));
            enemies[2].Actions = new List<Skill>
            {
                new Skill(Skill.Effect.Buff, 1,100,100,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,100,110,100),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(Skill.Effect.Buff, 4,500,100,100),
            };
            enemies[2].Skin = (Bitmap)Image.FromFile("../../Data/Knight.bmp");

            enemies.Add(new Enemy("Fox", 880, 700, 100, 3000, 3, 200, 2800));
            enemies[3].Actions = new List<Skill>
            {
                new Skill(Skill.Effect.Buff, 1,120,100,150),
                new Skill(Skill.Effect.Buff, 1,120,100,150),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,170,110,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,170,110,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,170,110,100),
            };
            enemies[3].Skin = (Bitmap)Image.FromFile("../../Data/Fox.bmp");


            enemies.Add(new Enemy("Ogr", 200, 400, 400, 5000, 5, 500, 5800));
            enemies[4].Actions = new List<Skill>
            {
                new Skill(Skill.Effect.Buff, 1,100,200,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,100,210,100),
                new Skill(),
                new Skill(Skill.Effect.Buff, 2,300,110,100),
            };
            enemies[4].Skin = (Bitmap)Image.FromFile("../../Data/Ogr.Png");
        }

        private void ShowShop_Button_Click(object sender, EventArgs e)
        {
            shopForm = (ShopForm)OpenNewForm(shopForm,new ShopForm(character, СharacteristicsLabel, PetLabel, inventoryForm));
        }

        private void ShowInventory_Button_Click(object sender, EventArgs e)
        {
            inventoryForm = (InventoryForm)OpenNewForm(inventoryForm, new InventoryForm(character, СharacteristicsLabel, PetLabel));
            if (shopForm != null) shopForm.inventory = inventoryForm;
            inventoryForm.ShowAll();
        }
        private void StartBattle_Button_Click(object sender, EventArgs e)
        {
            if (character.DangeonLvl < enemies.Count)
                battleForm = (BattleForm)OpenNewForm(battleForm,
                new BattleForm(character, enemies[(int)character.DangeonLvl], СharacteristicsLabel, PetLabel));
            else MessageBox.Show("Все монстры повержены");
        }
        private void ShowSkills_Button_Click(object sender, EventArgs e)
        {
            skillsForm = (SkillsForm)OpenNewForm(skillsForm, new SkillsForm(character));
        }

        private void MainForm_MouseEnter(object sender, EventArgs e) => character.ShowСharacteristics(СharacteristicsLabel, PetLabel);
        private IOpenAForm OpenNewForm(IOpenAForm MainFormObject, IOpenAForm NewObject)
        {
            if (MainFormObject == null || !MainFormObject.Visible)
            {
                MainFormObject = NewObject;                
            }
            MainFormObject.Show();
            return  MainFormObject; 
        }
    }
}
