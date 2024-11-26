using System;

namespace WF
{
    public class Microwave : Appliance
    {
        private int size;
        private int power;
        private string model;

        public Microwave() : base()
        {
            size = 0;
            power = 0;
            model = null;
        }

        public Microwave(string typ_control, int price, int guarantee, int size, int power, string model) :
            base(typ_control, price, guarantee)
        {
            if (size > 0 && size < 100)
            {
                this.size = size;
            }
            if (power > 100 && power < 1000)
            {
                this.power = power;
            }
            this.model = model;
        }
        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += $"\nОбъем: {size}\nМощность: {power}";
            if (model == "")
            {
                 return info += "\nМодель: неизвестна";
            }
            else
            {
                 return info += $"\nМодель: {model}";
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Объем: {size}\nМощность: {power}");
            if (model == "")
            {
                Console.WriteLine("Модель: неизвестна");
            }
            else
            {
                Console.WriteLine($"Модель: {model}");
            }
        }
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0 && value < 100)
                {
                    size = value;
                }
            }
        }
        public int Power
        {
            get { return power; }
            set
            {
                if (value > 100 && value < 1000)
                {
                    power = value;
                }
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value == null)
                {
                    model = "";
                }
                else
                {
                    model = value;
                }
            }
        }
    }
}
