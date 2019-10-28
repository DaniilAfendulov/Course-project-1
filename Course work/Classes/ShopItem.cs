using System;
using System.Drawing;
using Adventure;

namespace ShopForm
{
    public class ShopItem : Item, IComparable
    {
        public uint Cost { get; set; }
        public Bitmap Image { get; private set; }

        public ShopItem(Item item, Bitmap image, uint Cost) : base(item)
        {
            this.Cost = Cost;
            Image = image;
        }

        public override string ToString()
        {
            return base.ToString() + $"\ncost:\t {Cost}";
        }

        public int CompareTo(object obj)
        {
            return (int)Cost - (int)((ShopItem)obj).Cost;
        }
    }
}
