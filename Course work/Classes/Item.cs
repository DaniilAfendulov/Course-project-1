namespace Adventure
{
    public class Item : Characteristics
    {
        public Item(string name, uint speed, uint power, uint defence)
            : base(name, speed, power, defence)
        {
        }

        public Item(Item item)
            : base(item.Name, item.Speed, item.Attack, item.Defence)
        {
        }

        public override string ToString()
        {
            string[] hint = new string[]{
                //Использование свойств Name, Speed, Attack, Defence
                //Для добавления их значений в массив строк 
                $"name:\t {Name}",
                $"speed:\t {Speed}",
                $"power:\t {Attack}",
                $"defence:\t {Defence}" };
            return string.Join("\n", hint);
        }

    }
}
