using System;
using System.Windows.Forms;
using Adventure.Classes;
using Adventure.Interfaces;

namespace Adventure.Forms
{
    public partial class BattleForm : Form, IOpenAForm
    {
        private int step = -1;
        private readonly Player player;
        private readonly Enemy enemy;
        private readonly Label AboutPlayer, AboutPet;
        private CurrentPoint CurrentPlayerPoint, CurrentEnemyPoint;        

        public BattleForm(Player player, Enemy enemy, Label aboutPlayer, Label aboutPet)
        {
            InitializeComponent();
            timer1.Start();

            this.player = player;
            this.enemy = enemy;
            AboutPlayer = aboutPlayer;
            AboutPet = aboutPet;

            CurrentPlayerPoint = new CurrentPoint(
                player.Attack + (uint)player.BonusCharacteristic(Characteristics.Characteristic.attack),
                player.Defence + (uint)player.BonusCharacteristic(Characteristics.Characteristic.defence),
                player.Speed + (uint)player.BonusCharacteristic(Characteristics.Characteristic.speed),
                player.HP);
            CurrentEnemyPoint = new CurrentPoint(
                enemy.Attack, enemy.Defence,
                enemy.Speed, enemy.HP);

            Skill.SetBattle(this, this.player, this.enemy);

            EnemyPictureBox.Image = this.enemy.Skin;

            EnemyHPProgressBar.Value = EnemyHPProgressBar.Maximum = (int)this.enemy.HP; ;
            YourHPProgressBar.Value = YourHPProgressBar.Maximum = (int)this.player.HP;

            Skill1Button.Text = player.skills[0].ToString();
            Skill2Button.Text = player.skills[1].ToString();
            Skill3Button.Text = player.skills[2].ToString();
            Skill4Button.Text = player.skills[3].ToString();

            RefreshPoints();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (EnergyVerticalProgressBar.Value < EnergyVerticalProgressBar.Maximum) EnergyVerticalProgressBar.Value++;
            if(enemy.Actions != null)
            {
                if (++step == enemy.Actions.Count) step = 0;
                enemy.Actions[step].Do(Skill.Attacker.Enemy, ref CurrentPlayerPoint, ref CurrentEnemyPoint);                
            }
            RefreshPoints();
        }

        private void Skill1Button_Click(object sender, EventArgs e) => UseSkill(0);
        private void Skill2Button_Click(object sender, EventArgs e) => UseSkill(1);
        private void Skill3Button_Click(object sender, EventArgs e) => UseSkill(2);
        private void Skill4Button_Click(object sender, EventArgs e) => UseSkill(4);
        private void LeaveButton_Click_1(object sender, EventArgs e) => Close();

        private void UseSkill(uint skillNumber)
        {
            if (skillNumber < player.skills.Length
                && player.skills[skillNumber] != null
                && player.skills[skillNumber].Energy <= EnergyVerticalProgressBar.Value)
            {
                EnergyVerticalProgressBar.Value -= (int)player.skills[skillNumber].Energy;
                player.skills[skillNumber].Do(Skill.Attacker.Player, ref CurrentPlayerPoint, ref CurrentEnemyPoint);
                RefreshPoints();
            }
        }

        private void RefreshPoints()
        {
            EnemyHPLabel.Text = $"{enemy.Name} lvl {enemy.lvl}  {CurrentEnemyPoint.HP}/{enemy.HP}";
            YourHPLabel.Text = $"{CurrentPlayerPoint.HP}/{player.HP}";

            EnemyHPProgressBar.Value = (int)CurrentEnemyPoint.HP;
            YourHPProgressBar.Value = (int)CurrentPlayerPoint.HP;

            EnergyLabel.Text = $"{EnergyVerticalProgressBar.Value}/{EnergyVerticalProgressBar.Maximum}";

            if (CurrentEnemyPoint.HP <= 0)
            {
                timer1.Stop();
                EnemyHPProgressBar.Value = 1; // Если установить значение 0, то бар не изменится

                player.DangeonLvl++;
                player.GetReward(enemy.ExpirienceReward, enemy.MoneyReward);
                AboutPlayer.Text = player.ToString();
                if (player.pet != null)
                {
                    player.pet.AddExpierence(enemy.ExpirienceReward);
                    AboutPet.Text = player.pet.ToString();
                }

                MessageBox.Show("Вы победили");
                Close();
            }
            else if (CurrentPlayerPoint.HP <= 0)
            {
                timer1.Stop();
                YourHPProgressBar.Value = 1; // Если установить значение 0, то бар не изменится

                MessageBox.Show("Вы проиграли");
                Close();
            }
            else
            {              
                if (CurrentEnemyPoint.HP <= enemy.HP * 30 / 100) ModifyProgressBarColor.SetState(EnemyHPProgressBar, 2); //красный progress bar
                else if (CurrentEnemyPoint.HP <= enemy.HP * 60 / 100) ModifyProgressBarColor.SetState(EnemyHPProgressBar, 3); //желтый progress bar
                else ModifyProgressBarColor.SetState(EnemyHPProgressBar, 1); //зеленый progress bar

                if (CurrentPlayerPoint.HP <= player.HP * 30 / 100) ModifyProgressBarColor.SetState(YourHPProgressBar, 2); //красный progress bar
                else if (CurrentPlayerPoint.HP <= player.HP * 60 / 100) ModifyProgressBarColor.SetState(YourHPProgressBar, 3); //желтый progress bar
                else ModifyProgressBarColor.SetState(YourHPProgressBar, 1); //зеленый progress bar
            }                     
        }

        public IOpenAForm Create(IOpenAForm form) => form = this;
    }

    

}
