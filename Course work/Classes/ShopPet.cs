using System;
using System.Collections;
using System.Drawing;
using Adventure;

namespace ShopForm
{
    public class ShopPet: Pet, IComparable
    {
        public uint Cost { get; set; }
        public Bitmap Image { get; private set; }

        public ShopPet(Pet pet, Bitmap image, uint cost) : base(pet)
        {
            Image = image;
            Cost = cost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\ncost:\t {Cost}";
        }

        public int CompareTo(object obj)
        {
            //класс реализует метод CompareTo интерфейса IComparer
            return (int)Cost - (int)((ShopPet)obj).Cost;
        }
    }
}
