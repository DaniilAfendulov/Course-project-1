using Adventure.Classes;
using System;
using System.Windows.Forms;

namespace Adventure.Forms
{
    public partial class ChooseSkillForm : Form
    {
        private readonly Skill skill;
        private Skill lastSkill;
        private readonly Player character;
        private int number = -1;
        private delegate string TextMethod();
        private event Action<Skill> NewSettedSkill;
        public ChooseSkillForm(Player character, Skill skill)
        {
            InitializeComponent();
            ShowMethodText(button1, character.skills[0].FullInfo);
            ShowMethodText(button2, character.skills[1].FullInfo);
            ShowMethodText(button3, character.skills[2].FullInfo);
            ShowMethodText(button4, character.skills[3].FullInfo);

            ShowMethodText(label1, skill.FullInfo);

            NewSettedSkill = new Action<Skill>(NewSkillMessage);

            this.character = character;
            this.skill = skill;
        }

        private void NewSkillMessage(Skill obj)
        {
            string nl = Environment.NewLine;
            MessageBox.Show("навык" + nl 
                + obj.ShortInfo()
                + nl + "установлен");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(number != -1 && lastSkill != null)
            {
                character.skills[number] = lastSkill;

                switch (number)
                {
                    case 0:
                        ShowMethodText(button1, lastSkill.FullInfo);
                        //button1.Text = lastSkill.FullInfo();
                        break;
                    case 1:
                        ShowMethodText(button2, lastSkill.FullInfo);
                        //button2.Text = lastSkill.FullInfo();
                        break; 
                    case 2:
                        ShowMethodText(button3, lastSkill.FullInfo);
                        //button3.Text = lastSkill.FullInfo();
                        break;
                    case 3:
                        ShowMethodText(button4, lastSkill.FullInfo);
                        //button4.Text = lastSkill.FullInfo();
                        break;
                }

                lastSkill = null;
                number = -1;
            }
        }

        private void Button1_Click(object sender, EventArgs e) => SetSkill(button1, 0);
        private void Button2_Click(object sender, EventArgs e) => SetSkill(button2, 1);
        private void Button3_Click(object sender, EventArgs e) => SetSkill(button3, 2);
        private void Button4_Click(object sender, EventArgs e) => SetSkill(button4, 3);
        private void SetSkill(Button button, uint number)
        {
            lastSkill = character.skills[number];
            character.skills[number] = skill;
            ShowMethodText(button, character.skills[number].FullInfo);
            //button.Text = character.skills[number].FullInfo();
            this.number = (int)number;

            NewSettedSkill?.Invoke(skill);
        }

        //метод принимающий в качестве параметра делегат возвращающий строку
        //передает эту стрку в значение Text в объект класса Control
        private void ShowMethodText(Control control, TextMethod add) => control.Text = add();
    }
}
