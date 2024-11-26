using System;

namespace WF
{
    public class Appliance
    {
        private string typ_control;
        private int price;
        private int guarantee;

        public Appliance()
        {
            typ_control = "";
            price = 0;
            guarantee = 0;
        }
        public Appliance(string typ_control, int price, int guarantee)
        {
            this.typ_control = typ_control;
            this.price = price;
            this.guarantee = guarantee;
        }

        public virtual string GetInfo()
        {
            string info;
            if (typ_control == "")
            {
                info = "Тип управления: неизвестный";
            }
            else
            {
                info = $"Тип управления: {typ_control}";
            }
            return info += $"\nЦена: {price}\nГарантийный срок: {guarantee}";
        }

        public virtual void Print()
        {
            if (typ_control == "")
            {
                Console.WriteLine("Тип управления: неизвестный");
            }
            else
            {
                Console.WriteLine($"Тип управления: {typ_control}");
            }
            Console.WriteLine($"Цена: {price}\nГарантийный срок: {guarantee}");
        }
        public string Typ_control
        {
            get { return typ_control; }
            set
            {
                if (value == null)
                {
                    typ_control = "";
                }
                else
                {
                    typ_control = value;
                }
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (0 < value && value < 999999)
                {
                    price = value;
                }
            }
        }
        public int Guarantee
        {
            get { return guarantee; }
            set
            {
                if (0 <= value && value <= 10)
                {
                    guarantee = value;
                }
            }
        }
    }
}
