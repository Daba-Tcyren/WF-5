using System;

namespace WF
{
    public class Fridge : Appliance
    {
        private string energy;
        private int height;
        private int amount;

        public Fridge() : base()
        {
            energy = null;
            height = 0;
            amount = 0;
        }

        public Fridge(string typ_control, int price, int guarantee, string energy, int height, int amount) : base(typ_control, price, guarantee)
        {
            if (amount > 0 && amount < 7)
            {
                this.amount = amount;
            }
            if (height > 0 && height < 300)
            {
                this.height = height;
            }
            Energy = energy;
        }
        public override string GetInfo()
        {
            string info = base.GetInfo();
            return info += $"\nКоличество дверей: {amount}\nВысота: {height}\nЭнергопотребление: {energy}";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество дверей: {amount}\nВысота: {height}\nЭнергопотребление: {energy}");
        }
        public string Energy
        {
            get { return energy; }
            set
            {
                if (value == "")
                {
                    energy = "неизвестно";
                }
                else
                {
                    energy = value;
                }
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value < 300)
                {
                    height = value;
                }
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value > 0 && value < 7)
                {
                    amount = value;
                }
            }
        }
    }
}
