using System;
using System.Windows.Forms;
using System.Drawing;
using Adventure;
using System.Collections;

namespace ShopForm
{
    public class Shop
    {
        public enum ProductType : int
        {
            item,
            pet
        }

        public ShopPet[] Pets { get; private set; }
        public ShopItem[] Items { get; private set; }

        public Shop(ShopItem[] items, ShopPet[] pets)
        {
            Items = items;
            Pets = pets;
        }

        public string[] GetItemsName()
        {
            //метод создает ArrayList массив содержащих значения names 
            //каждого элемента из массива объектов класса ShopItem
            //и затем преобразует новый массив в массив строк и возвращает его
            ArrayList names = new ArrayList();
            foreach (ShopItem item in Items) names.Add(item.Name);
            return (string[])names.ToArray(typeof(string));
        }

        public string[] GetPetsName()
        {
            ArrayList names = new ArrayList();
            foreach(ShopPet pet in Pets) names.Add(pet.Name);
            return (string[])names.ToArray(typeof(string));
        }


        public void BuyItem(ProductType type, string item, Player character)
        {
            if (type == ProductType.item)
            {
                bool IsInShop = false;
                if (!string.IsNullOrWhiteSpace(item))
                {
                    for (int i = 0; i < Items.Length; i++)
                    {
                        if (Items[i].Name.ToLower() == item.ToLower())
                        {
                            IsInShop = true;
                            if (Items[i].Cost <= character.money)
                            {
                                character.money -= (int)Items[i].Cost;
                                character.AddItems(Items[i]);
                            }
                            else MessageBox.Show("Не достаточно денег");
                            break;
                        }
                    }
                }
                if (!IsInShop) MessageBox.Show("Предмет в магазине не найден");
            }
            else if (type == ProductType.pet)
            {
                bool IsInShop = false;
                if (!string.IsNullOrWhiteSpace(item))
                {
                    for (int i = 0; i < Pets.Length; i++)
                    {
                        if (Pets[i].Name == item)
                        {
                            IsInShop = true;
                            if (Pets[i].Cost <= character.money)
                            {
                                character.money -= (int)Pets[i].Cost;
                                character.pet = Pets[i];
                            }
                            else MessageBox.Show("Не достаточно денег");
                            break;
                        }
                    }
                }
                if (!IsInShop) MessageBox.Show("Питомец в магазине не найден");
            }
            else MessageBox.Show("Тип товара в магазине не найден");
        }

        public void AddItemToShop(Item item, Bitmap Image, uint Cost)
        {
            ShopItem[] Items = new ShopItem[this.Items.Length + 1];
            for (int i = 0; i < Items.Length; i++) Items[i] = this.Items[i];
            Items[this.Items.Length] = new ShopItem(item, Image, Cost);
            this.Items = Items;
        }
    }

}
