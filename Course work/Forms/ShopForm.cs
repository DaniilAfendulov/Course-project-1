using System;
using System.Windows.Forms;
using Приключение.Forms;
using ShopForm;
using Adventure.Classes;
using Adventure.Interfaces;
using System.Collections;

namespace Adventure
{
    public partial class ShopForm : Form, IOpenAForm
    {

        private Shop shop;
        public InventoryForm inventory;
        private readonly Player Character;
        private readonly Label ForCharacter;
        private Label ForPet;

        public ShopForm(Player character, Label forCharacter, Label forPet, InventoryForm inventory) 
        {
            InitializeComponent();

            Character = character;
            ForCharacter = forCharacter;
            ForPet = forPet;

            CreateShop();

            СategoriesComboBox.DataSource = categories;
            ItemComboBox.DataSource = shop.GetItemsName();
            this.inventory = inventory;
            MoneyLabel.Text = "Баланс: " + character.money;
            
        }


        private string[] categories = new string[]
        {
            "Предметы",
            "Питомцы"
        };

       private void CreateShop()
        {
            ShopItem[] items = new ShopItem[]
            {
                new ShopItem( new Item(" Броня земли", 300, 300, 600), null, 3000),
                new ShopItem( new Item(" Рыцарская броня ", 800, 800, 800), null, 5000),
                new ShopItem( new Item(" Броня мастера", 1500, 1500, 1500), null, 7000),
                new ShopItem( new Item(" Броня разбойника", 55, 55, 55), null, 500),
                new ShopItem( new Item(" Солдатская броня ", 115, 120, 120), null, 1000),
                new ShopItem( new Item(" Броня воина", 250, 250, 250), null, 2000),
                new ShopItem( new Item(" Броня ветра", 600, 300, 300), null, 3000),
                new ShopItem( new Item(" Броня огня", 300, 600, 300), null, 3000)                           
            };
            Array.Sort(items);


            var petArray = new ArrayList();
            petArray.Add(new ShopPet(new Pet("Дракончик", 700, 1500, 300), null, 5000));
            petArray.Add(new ShopPet(new Pet("Единорожек", 600, 200, 500), null, 3000));
            petArray.Add(new ShopPet(new Pet("Зубастик", 100, 3000, 100), null, 6000));
            petArray.Sort(new PetComparer());
            ShopPet[] pets = (ShopPet[])petArray.ToArray(typeof(ShopPet));
            shop = new Shop(items, pets);
        }
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            if(inventory == null || !inventory.Visible)
            {
                inventory = new InventoryForm(Character, ForCharacter, ForPet);
                inventory.Show();
            }
            inventory.ShowAll();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            shop.BuyItem((Shop.ProductType)СategoriesComboBox.SelectedIndex,
                ItemComboBox.SelectedItem.ToString(), Character);
            MoneyLabel.Text = "Баланс: " + Character.money;
        }
        private void СategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(СategoriesComboBox.SelectedIndex == (int)Shop.ProductType.item)
            {
                ItemComboBox.DataSource = shop.GetItemsName();
            }
            else if (СategoriesComboBox.SelectedIndex == (int)Shop.ProductType.pet)
            {
                ItemComboBox.DataSource = shop.GetPetsName();
            }
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (СategoriesComboBox.SelectedIndex == (int)Shop.ProductType.item)
            {
                var CurrentItem = shop.Items[ItemComboBox.SelectedIndex];
                CostLabel.Text = "Цена: " + CurrentItem.Cost;
                NameItemLabel.Text = CurrentItem.Name;
                ItemInfoLabel.Text = CurrentItem.ToString();
            }
            else if (СategoriesComboBox.SelectedIndex == (int)Shop.ProductType.pet)
            {
                var CurrentPet = shop.Pets[ItemComboBox.SelectedIndex];
                CostLabel.Text = "Цена: " + CurrentPet.Cost;
                NameItemLabel.Text = CurrentPet.Name;
                ItemInfoLabel.Text = CurrentPet.ToString();
            }

        }

        public IOpenAForm Create(IOpenAForm form) => form = this;
    }
}
