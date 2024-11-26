namespace WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button10_appliance = new System.Windows.Forms.Button();
            this.button10_fridge = new System.Windows.Forms.Button();
            this.button10_Microwave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(114, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 74);
            this.button4.TabIndex = 0;
            this.button4.Text = "Добавить объект";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Add);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(114, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 74);
            this.button5.TabIndex = 1;
            this.button5.Text = "Вывести содержимое списка";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Print);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(114, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 74);
            this.button6.TabIndex = 2;
            this.button6.Text = "Завершить программу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Close);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите действие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите тип объекта:";
            this.label3.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(105, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(230, 74);
            this.button7.TabIndex = 6;
            this.button7.Text = "Производный класс Fridge";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button_Fridge);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(105, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(230, 74);
            this.button8.TabIndex = 5;
            this.button8.Text = "Производный класс Microwave";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button_Microwave);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(105, 84);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(230, 74);
            this.button9.TabIndex = 4;
            this.button9.Text = "Базовый класс Appliance";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button_Appliance);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вид управления:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цену:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(83, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Гарантийный срок:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Объем:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(138, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "Введите данные";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(83, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Мощность микроволн:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(83, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Модель:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(83, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Количество дверей:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(83, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Высота:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(83, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "Энергопотребление:";
            this.label13.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            //this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 22);
            this.textBox3.TabIndex = 20;
            this.textBox3.Visible = false;
           // this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(295, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 22);
            this.textBox4.TabIndex = 21;
            this.textBox4.Visible = false;
           // this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(324, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 22);
            this.textBox5.TabIndex = 22;
            this.textBox5.Visible = false;
           // this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(233, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 22);
            this.textBox6.TabIndex = 23;
            this.textBox6.Visible = false;
           // this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(306, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(87, 22);
            this.textBox7.TabIndex = 24;
            this.textBox7.Visible = false;
         //   this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(306, 268);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(87, 22);
            this.textBox8.TabIndex = 25;
            this.textBox8.Visible = false;
         //   this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(306, 309);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(87, 22);
            this.textBox9.TabIndex = 26;
            this.textBox9.Visible = false;
          //  this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button10_appliance
            // 
            this.button10_appliance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10_appliance.Location = new System.Drawing.Point(163, 220);
            this.button10_appliance.Name = "button10_appliance";
            this.button10_appliance.Size = new System.Drawing.Size(147, 41);
            this.button10_appliance.TabIndex = 27;
            this.button10_appliance.Text = "Завершить";
            this.button10_appliance.UseVisualStyleBackColor = true;
            this.button10_appliance.Visible = false;
            this.button10_appliance.Click += new System.EventHandler(this.button10_appliance_Click);
            // 
            // button10_fridge
            // 
            this.button10_fridge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10_fridge.Location = new System.Drawing.Point(163, 346);
            this.button10_fridge.Name = "button10_fridge";
            this.button10_fridge.Size = new System.Drawing.Size(147, 41);
            this.button10_fridge.TabIndex = 28;
            this.button10_fridge.Text = "Завершить";
            this.button10_fridge.UseVisualStyleBackColor = true;
            this.button10_fridge.Visible = false;
            this.button10_fridge.Click += new System.EventHandler(this.button10_fridge_Click);
            // 
            // button10_Microwave
            // 
            this.button10_Microwave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10_Microwave.Location = new System.Drawing.Point(163, 346);
            this.button10_Microwave.Name = "button10_Microwave";
            this.button10_Microwave.Size = new System.Drawing.Size(147, 41);
            this.button10_Microwave.TabIndex = 29;
            this.button10_Microwave.Text = "Завершить";
            this.button10_Microwave.UseVisualStyleBackColor = true;
            this.button10_Microwave.Visible = false;
            this.button10_Microwave.Click += new System.EventHandler(this.button10_Microwave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(157, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 33);
            this.label14.TabIndex = 30;
            this.label14.Text = "  ";
            this.label14.Visible = false;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(163, 43);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 76);
            this.button10.TabIndex = 31;
            this.button10.Text = "Вернуться в меню";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(105, 136);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox10.Size = new System.Drawing.Size(279, 281);
            this.textBox10.TabIndex = 32;
            this.textBox10.Tag = "True";
            this.textBox10.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(496, 587);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button10_Microwave);
            this.Controls.Add(this.button10_fridge);
            this.Controls.Add(this.button10_appliance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button10_appliance;
        private System.Windows.Forms.Button button10_fridge;
        private System.Windows.Forms.Button button10_Microwave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox10;
    }
}

