namespace Adventure.Forms
{
    public struct CurrentPoint
    {
        public uint attack, defence, speed, HP;
        public CurrentPoint(uint attack, uint defence, uint speed, uint HP)
        {
            this.attack = attack;
            this.defence = defence;
            this.speed = speed;
            this.HP = HP;
        }
    }

    

}
