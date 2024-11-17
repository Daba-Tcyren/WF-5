using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        List<Appliance> appliances = new List<Appliance>();
        string typ_control;
        int price, guarantee;

        string model;
        int size, power;

        string energy;
        int amount, height;

        public Form1()
        {
            InitializeComponent();
        }
        // завершение
        private void button_Close(object sender, EventArgs e)
        {
            while (appliances.Count > 0)
            {
                int i = 0;
                var item = appliances[i];
                appliances.Remove(item);
                i++;
            }
            appliances.Clear();
            Close();// Завершаем программу
        }

        // Вывод
        private void button_Print(object sender, EventArgs e)
        {
            // делаем незаметными
            label2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            button10.Visible = true;
            
            if (appliances.Count == 0)
            {
                label14.Visible = true;
                label14.Text = "Список пустой";
                return;
            }

            textBox10.Visible = true;
            textBox10.Text = "Список:";
            textBox10.Text += Environment.NewLine;
            foreach (var item in appliances)
            {
                textBox10.Text += item.GetInfo().Replace("\n", Environment.NewLine);
                textBox10.Text += Environment.NewLine;
                textBox10.Text += Environment.NewLine;
            }
        }
        // кнопка завершения вывода
        private void button10_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            textBox10.Visible = false;
            textBox10.Text = string.Empty;
            label14.Text = string.Empty;
            label14.Visible = false;
            button10.Visible = false;
        }
        // добавление
        private void button_Add(object sender, EventArgs e)
        {
            // делаем незаметными
            label2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            label3.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }

        // класс Appliance
        private void button_Appliance(object sender, EventArgs e)
        {
            label3.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            label8.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            button10_appliance.Visible = true;

        }

        // класс Microwave
        private void button_Microwave(object sender, EventArgs e)
        {
            label3.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            button10_Microwave.Visible = true;
        }

        // класс Fridge
        private void button_Fridge(object sender, EventArgs e)
        {
            label3.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            label8.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            button10_fridge.Visible = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Visible) typ_control = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Visible) price = Convert.ToInt32(textBox2.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Visible) guarantee = Convert.ToInt32(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Visible || string.IsNullOrEmpty(textBox4.Text)) size = Convert.ToInt32(textBox4.Text);
            if (textBox4.Visible) size = Convert.ToInt32(textBox4.Text);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Visible) power = Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Visible) model = textBox6.Text;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Visible) amount = Convert.ToInt32(textBox7.Text);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Visible) height = Convert.ToInt32(textBox8.Text);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Visible) energy = textBox9.Text;
        }

        private void button10_appliance_Click(object sender, EventArgs e)
        {
            appliances.Add(new Appliance(typ_control, price, guarantee));
            label8.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            // Обнуляем значения
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            button10_appliance.Visible = false;

            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button10_Microwave_Click(object sender, EventArgs e)
        {
            appliances.Add(new Microwave(typ_control, price, guarantee, size, power, model));

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            // Обнуляем значения
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;

            button10_Microwave.Visible = false;

            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }
        private void button10_fridge_Click(object sender, EventArgs e)
        {
            appliances.Add(new Fridge(typ_control, price, guarantee, energy, height, amount));

            label8.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            // Обнуляем значения
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;

            button10_fridge.Visible = false;

            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }
    }
}
