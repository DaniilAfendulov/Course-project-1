using System;
using System.Drawing;
using System.Windows.Forms;
using Adventure;
using Adventure.Classes;
using Adventure.Interfaces;
using ShopForm;

namespace Приключение.Forms
{
    public partial class InventoryForm : Form, IOpenAForm
    {
        Player Character;
        Label ForCharacter, ForPet;

        public InventoryForm(Player character, Label forCharacter, Label forPet)
        {
            InitializeComponent();
            
            Character = character;
            ForCharacter = forCharacter;
            ForPet = forPet;

            ShowAll();

        }



        public void ShowAll()
        {
            
            Character.ShowСharacteristics(ForCharacter, ForPet);
            Character.ShowСharacteristics(PersonLabel, PetsLabel);

            if (Character.Skin != null)
                PersonPicture.BackgroundImage = Character.Skin;
            else
                PersonPicture.BackColor = Color.AliceBlue;

            if (Character.pet != null)
            {
               try
               {
                    ShopPet pet = (ShopPet)Character.pet;
                    if (pet.Image != null)
                    {
                        PetsPicture.BackgroundImage = pet.Image;
                    }
                    else
                    {
                        PetsPicture.BackColor = Color.AliceBlue;
                    }
                }
                catch (InvalidCastException)
                {
                    PetsPicture.BackColor = Color.AliceBlue;
                }                
            }

        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsLabel.Text = ((ShopItem)Character.
                Inventory[InventoryListBox.SelectedIndex]).ToString();

            try
            {
                ItemsLabel.Text = ((ShopItem)Character.
                    Inventory[InventoryListBox.SelectedIndex]).ToString();
            }
            catch (InvalidCastException)
            {
                ItemsLabel.Text = Character.
                    Inventory[InventoryListBox.SelectedIndex].ToString();
            }
        }

        public IOpenAForm Create(IOpenAForm form) => form = this;
    }
}
