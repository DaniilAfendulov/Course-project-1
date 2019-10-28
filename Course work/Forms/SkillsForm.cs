using Adventure.Classes;
using System;
using System.Collections;
using System.Windows.Forms;
using Adventure.Interfaces;

namespace Adventure.Forms
{
    public partial class SkillsForm : Form, IOpenAForm 
    {
        private ChooseSkillForm chooseSkill;
        private readonly Player character;
        private static Skill[] Skills1;
        private Button[] buttons;
        private static bool[] IsOpen;
        private ArrayList IsOpenAndBarsRelations;
        private delegate void SetCommponents();
        public SkillsForm(Player character)
        {
            InitializeComponent();
            SetCommponents setCommponents = new SetCommponents(SetSkills1);
            setCommponents += SetSkills1Text;
            setCommponents += SetRelations;
            setCommponents += SetBars;
            if (Skills1 != null) setCommponents -= SetSkills1;
            if (IsOpen == null) setCommponents -= SetBars;

            setCommponents?.Invoke();
            //if (Skills1 == null) SetSkills1();
            //SetSkills1Text();
            //SetRelations();
            //if (IsOpen != null) SetBars();
            this.character = character;
        }


        private void SetSkills1()
        {
            Skills1 = new Skill[12];

            if (IsOpen == null)
            {
                IsOpen = new bool[12];
                for (int i = 0; i < IsOpen.Length; i++) IsOpen[i] = false;
            }

            Skills1[0] = new Skill(Skill.Effect.Buff, 1, 115, 100, 100);
            Skills1[0].SetShortInfo("Искуссный удар 1", 1);
            Skills1[1] = new Skill(Skill.Effect.Buff, 1, 130, 100, 100);
            Skills1[1].SetShortInfo("Искуссный удар 2", 2);
            Skills1[2] = new Skill(Skill.Effect.Buff, 1, 150, 100, 100);
            Skills1[2].SetShortInfo("Искуссный удар 3", 2);

            Skills1[3] = new Skill(Skill.Effect.Buff, 2, 225, 100, 100);
            Skills1[3].SetShortInfo("Двойной удар 1", 1);
            Skills1[4] = new Skill(Skill.Effect.Buff, 2, 275, 100, 100);
            Skills1[4].SetShortInfo("Двойной удар 2", 2);
            Skills1[5] = new Skill(Skill.Effect.Buff, 2, 310, 100, 100);
            Skills1[5].SetShortInfo("Двойной удар 3", 2);

            Skills1[6] = new Skill( 1, 105, 100, 100, 100, 65, 100);
            Skills1[6].SetShortInfo("Разрушитель брони 1", 1);
            Skills1[7] = new Skill(1, 115, 100, 100, 100, 40, 100);
            Skills1[7].SetShortInfo("Разрушитель брони 2", 2);
            Skills1[8] = new Skill(1, 130, 100, 100, 100, 20, 100);
            Skills1[8].SetShortInfo("Разрушитель брони 3", 2);

            Skills1[9] = new Skill(Skill.Effect.Buff, 5, 1000, 100, 100);
            Skills1[9].SetShortInfo("Уничтожитель ", 3);
            Skills1[10] = new Skill(4, 250, 100, 100, 90, 10, 90);
            Skills1[10].SetShortInfo("Сковывающий удар ", 3);
            Skills1[11] = new Skill(6, 1250, 100, 100, 80, 0, 80);
            Skills1[11].SetShortInfo("Аннигиляция", 4);      
        }
        private void SetSkills1Text()
        {
            buttons = new Button[]
            {
                 button1_1,
                 button1_2,
                 button1_3,
                 button2_1,
                 button2_2,
                 button2_3,
                 button3_1,
                 button3_2,
                 button3_3,
                 button4,
                 button5,
                 button6
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = Skills1[i].ShortInfo();
                toolTip1.SetToolTip(buttons[i], Skills1[i].ToString());
            }
        }

        private void SetRelations()
        {
            IsOpenAndBarsRelations = new ArrayList();
            var Arguments = new ArrayList()
            {
                IsOpen[0],
                new ProgressBar[] { progressBar1 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[1],
                new ProgressBar[] { progressBar2 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[2],
                new ProgressBar[] { progressBar3 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[3],
                new ProgressBar[] { progressBar8 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[4],
                new ProgressBar[] { progressBar7 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[5],
                new ProgressBar[] { progressBar9, progressBar10 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[6],
                new ProgressBar[] { progressBar4 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[7],
                new ProgressBar[] { progressBar5 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[8],
                new ProgressBar[] { progressBar6 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[9],
                new ProgressBar[] { progressBar12 }
            };
            IsOpenAndBarsRelations.Add(Arguments);

            Arguments = new ArrayList()
            {
                IsOpen[10],
                new ProgressBar[] { progressBar11 }
            };
            IsOpenAndBarsRelations.Add(Arguments);
        }
      
        private void Button1_1_Click(object sender, EventArgs e) => LearnSkill(0, new ProgressBar[] { progressBar1 });                     
        private void Button1_2_Click(object sender, EventArgs e) => LearnSkill(1, new ProgressBar[] { progressBar2 }, IsOpen[0]);
        private void Button1_3_Click(object sender, EventArgs e) => LearnSkill(2, new ProgressBar[] { progressBar3 }, IsOpen[1]);

        private void Button2_1_Click(object sender, EventArgs e) => LearnSkill(3, new ProgressBar[] { progressBar8 });
        private void Button2_2_Click(object sender, EventArgs e) => LearnSkill(4, new ProgressBar[] { progressBar7 }, IsOpen[3]);
        private void Button2_3_Click(object sender, EventArgs e) => LearnSkill(5, new ProgressBar[] { progressBar9, progressBar10 }, IsOpen[4]);

        private void Button3_1_Click(object sender, EventArgs e) => LearnSkill(6, new ProgressBar[] { progressBar4 });
        private void Button3_2_Click(object sender, EventArgs e) => LearnSkill(7, new ProgressBar[] { progressBar5 }, IsOpen[6]);
        private void Button3_3_Click(object sender, EventArgs e) => LearnSkill(8, new ProgressBar[] { progressBar6 }, IsOpen[7]);

        private void Button4_Click(object sender, EventArgs e) => LearnSkill(9, new ProgressBar[] { progressBar12 }, IsOpen[2], IsOpen[8]);
        private void Button5_Click(object sender, EventArgs e) => LearnSkill(10, new ProgressBar[] { progressBar11 }, IsOpen[5], IsOpen[8]);
        private void Button6_Click(object sender, EventArgs e) => LearnSkill(11, null, IsOpen[9], IsOpen[10]);

         
        private void LearnSkill(int number, ProgressBar[] progressBars, params bool[] relations)
        {
            if (!IsOpen[number])
            {
                bool relation = true;
                if (relations != null)
                {
                    foreach (bool i in relations)
                    {
                        relation &= i;
                        if (!relation) break;
                    }
                }

                if (relation)
                {
                    if (character.lvlpoint >= Skills1[number].Cost)
                    {
                        character.lvlpoint -= Skills1[number].Cost;
                        IsOpen[number] = true;
                        if (progressBars != null) foreach (ProgressBar bar in progressBars) bar.Value = 1;

                        if (chooseSkill == null || !chooseSkill.Visible)
                        {
                            chooseSkill = new ChooseSkillForm(character, Skills1[number]);
                        }
                        chooseSkill.Show();
                    }
                    else MessageBox.Show("Недостаточно очков");
                }
                else MessageBox.Show("Предыдущие способности не открыты");
            }
            else
            {
                if (chooseSkill == null || !chooseSkill.Visible)
                {
                    chooseSkill = new ChooseSkillForm(character, Skills1[number]);
                }
                chooseSkill.Show();
            }
        }

        private void SetBars()
        {
            for( int i = 0; i < IsOpen.Length; i++)
            {
                if (IsOpen[i])
                {
                    switch (i)
                    {
                        case 0:
                            progressBar1.Value = 1;
                            break;
                        case 1:
                            progressBar2.Value = 1;
                            break;
                        case 2:
                            progressBar3.Value = 1;
                            break;
                        case 3:
                            progressBar8.Value = 1;
                            break;
                        case 4:
                            progressBar7.Value = 1;
                            break;
                        case 5:
                            progressBar9.Value = 
                            progressBar10.Value = 1;
                            break;
                        case 6:
                            progressBar4.Value = 1;
                            break;
                        case 7:
                            progressBar5.Value = 1;
                            break;
                        case 8:
                            progressBar6.Value = 1;
                            break;
                        case 9:
                            progressBar12.Value = 1;
                            break;
                        case 10:
                            progressBar11.Value = 1;
                            break;
                    }                    

                }
            }
        }

        public IOpenAForm Create(IOpenAForm form) => form = this;
    }
}
