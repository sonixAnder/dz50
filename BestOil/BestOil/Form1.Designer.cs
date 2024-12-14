namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxFuel = new ComboBox();
            Price = new Label();
            textBoxFuelPrice = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            labelFuelTotal = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            textBoxSum = new TextBox();
            textBoxQuantity = new TextBox();
            radioButtonQuantity = new RadioButton();
            radioButtonSum = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            labelCafeTotal = new Label();
            textBoxColaQuantity = new TextBox();
            textBoxHamburgerQuantity = new TextBox();
            textBoxFriesQuantity = new TextBox();
            textBoxHotDogQuantity = new TextBox();
            textBoxCocaColaPrice = new TextBox();
            textBoxFriesPrice = new TextBox();
            textBoxHamburgerPrice = new TextBox();
            textBoxHotDogPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            checkBoxCola = new CheckBox();
            checkBoxFries = new CheckBox();
            checkBoxHamburger = new CheckBox();
            checkBoxHotDog = new CheckBox();
            groupBox4 = new GroupBox();
            labelTotalSum = new Label();
            buttonCalculate = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Items.AddRange(new object[] { "АИ-92", "АИ-95", "Дизель" });
            comboBoxFuel.Location = new Point(23, 40);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(121, 23);
            comboBoxFuel.TabIndex = 0;
            comboBoxFuel.SelectedIndexChanged += comboBoxFuel_SelectedIndexChanged;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.ForeColor = SystemColors.ButtonHighlight;
            Price.Location = new Point(23, 22);
            Price.Name = "Price";
            Price.Size = new Size(46, 15);
            Price.TabIndex = 1;
            Price.Text = "Бензин";
            // 
            // textBoxFuelPrice
            // 
            textBoxFuelPrice.BackColor = Color.FromArgb(64, 64, 64);
            textBoxFuelPrice.Location = new Point(161, 40);
            textBoxFuelPrice.Multiline = true;
            textBoxFuelPrice.Name = "textBoxFuelPrice";
            textBoxFuelPrice.ReadOnly = true;
            textBoxFuelPrice.Size = new Size(58, 23);
            textBoxFuelPrice.TabIndex = 2;
            textBoxFuelPrice.TextChanged += textBoxFuelPrice_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(25, 25, 25);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(Price);
            groupBox1.Controls.Add(comboBoxFuel);
            groupBox1.Controls.Add(textBoxFuelPrice);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 276);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(161, 22);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Цена";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelFuelTotal);
            groupBox5.ForeColor = SystemColors.ButtonHighlight;
            groupBox5.Location = new Point(23, 192);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(199, 74);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "К оплате";
            // 
            // labelFuelTotal
            // 
            labelFuelTotal.AutoSize = true;
            labelFuelTotal.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold);
            labelFuelTotal.Location = new Point(6, 34);
            labelFuelTotal.Name = "labelFuelTotal";
            labelFuelTotal.Size = new Size(28, 32);
            labelFuelTotal.TabIndex = 0;
            labelFuelTotal.Text = "⠀";
            labelFuelTotal.Click += labelFuelTotal_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBoxSum);
            groupBox3.Controls.Add(textBoxQuantity);
            groupBox3.Controls.Add(radioButtonQuantity);
            groupBox3.Controls.Add(radioButtonSum);
            groupBox3.Location = new Point(23, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(199, 96);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(169, 55);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "руб";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(169, 28);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 7;
            label4.Text = "л";
            // 
            // textBoxSum
            // 
            textBoxSum.BackColor = Color.FromArgb(64, 64, 64);
            textBoxSum.Location = new Point(76, 51);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(88, 23);
            textBoxSum.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = Color.FromArgb(64, 64, 64);
            textBoxQuantity.Location = new Point(76, 22);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(88, 23);
            textBoxQuantity.TabIndex = 5;
            // 
            // radioButtonQuantity
            // 
            radioButtonQuantity.AutoSize = true;
            radioButtonQuantity.ForeColor = SystemColors.ButtonHighlight;
            radioButtonQuantity.Location = new Point(5, 23);
            radioButtonQuantity.Name = "radioButtonQuantity";
            radioButtonQuantity.Size = new Size(64, 19);
            radioButtonQuantity.TabIndex = 4;
            radioButtonQuantity.TabStop = true;
            radioButtonQuantity.Text = "Кол-во";
            radioButtonQuantity.UseVisualStyleBackColor = true;
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.ForeColor = SystemColors.ButtonHighlight;
            radioButtonSum.Location = new Point(5, 55);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(63, 19);
            radioButtonSum.TabIndex = 3;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сумма";
            radioButtonSum.UseVisualStyleBackColor = true;
            radioButtonSum.CheckedChanged += radioButtonSum_CheckedChanged;
            radioButtonSum.Click += radioButtonSum_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(25, 25, 25);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(textBoxColaQuantity);
            groupBox2.Controls.Add(textBoxHamburgerQuantity);
            groupBox2.Controls.Add(textBoxFriesQuantity);
            groupBox2.Controls.Add(textBoxHotDogQuantity);
            groupBox2.Controls.Add(textBoxCocaColaPrice);
            groupBox2.Controls.Add(textBoxFriesPrice);
            groupBox2.Controls.Add(textBoxHamburgerPrice);
            groupBox2.Controls.Add(textBoxHotDogPrice);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkBoxCola);
            groupBox2.Controls.Add(checkBoxFries);
            groupBox2.Controls.Add(checkBoxHamburger);
            groupBox2.Controls.Add(checkBoxHotDog);
            groupBox2.Cursor = Cursors.Cross;
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(330, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(268, 276);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мини-кафе";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(labelCafeTotal);
            groupBox6.ForeColor = SystemColors.ButtonHighlight;
            groupBox6.Location = new Point(6, 192);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(166, 74);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "К оплате";
            // 
            // labelCafeTotal
            // 
            labelCafeTotal.AutoSize = true;
            labelCafeTotal.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold);
            labelCafeTotal.Location = new Point(6, 34);
            labelCafeTotal.Name = "labelCafeTotal";
            labelCafeTotal.Size = new Size(28, 32);
            labelCafeTotal.TabIndex = 0;
            labelCafeTotal.Text = "⠀";
            labelCafeTotal.Click += labelCafeTotal_Click;
            // 
            // textBoxColaQuantity
            // 
            textBoxColaQuantity.BackColor = Color.FromArgb(64, 64, 64);
            textBoxColaQuantity.Location = new Point(185, 130);
            textBoxColaQuantity.Name = "textBoxColaQuantity";
            textBoxColaQuantity.Size = new Size(72, 23);
            textBoxColaQuantity.TabIndex = 13;
            // 
            // textBoxHamburgerQuantity
            // 
            textBoxHamburgerQuantity.BackColor = Color.FromArgb(64, 64, 64);
            textBoxHamburgerQuantity.Location = new Point(185, 72);
            textBoxHamburgerQuantity.Name = "textBoxHamburgerQuantity";
            textBoxHamburgerQuantity.Size = new Size(72, 23);
            textBoxHamburgerQuantity.TabIndex = 12;
            // 
            // textBoxFriesQuantity
            // 
            textBoxFriesQuantity.BackColor = Color.FromArgb(64, 64, 64);
            textBoxFriesQuantity.Location = new Point(185, 101);
            textBoxFriesQuantity.Name = "textBoxFriesQuantity";
            textBoxFriesQuantity.Size = new Size(72, 23);
            textBoxFriesQuantity.TabIndex = 11;
            // 
            // textBoxHotDogQuantity
            // 
            textBoxHotDogQuantity.BackColor = Color.FromArgb(64, 64, 64);
            textBoxHotDogQuantity.Location = new Point(185, 45);
            textBoxHotDogQuantity.Name = "textBoxHotDogQuantity";
            textBoxHotDogQuantity.Size = new Size(72, 23);
            textBoxHotDogQuantity.TabIndex = 10;
            // 
            // textBoxCocaColaPrice
            // 
            textBoxCocaColaPrice.BackColor = Color.FromArgb(64, 64, 64);
            textBoxCocaColaPrice.ForeColor = SystemColors.MenuBar;
            textBoxCocaColaPrice.Location = new Point(125, 130);
            textBoxCocaColaPrice.Name = "textBoxCocaColaPrice";
            textBoxCocaColaPrice.ReadOnly = true;
            textBoxCocaColaPrice.Size = new Size(35, 23);
            textBoxCocaColaPrice.TabIndex = 9;
            textBoxCocaColaPrice.Text = "80.40";
            textBoxCocaColaPrice.TextChanged += textBox4_TextChanged;
            // 
            // textBoxFriesPrice
            // 
            textBoxFriesPrice.BackColor = Color.FromArgb(64, 64, 64);
            textBoxFriesPrice.ForeColor = SystemColors.MenuBar;
            textBoxFriesPrice.Location = new Point(125, 101);
            textBoxFriesPrice.Name = "textBoxFriesPrice";
            textBoxFriesPrice.ReadOnly = true;
            textBoxFriesPrice.Size = new Size(35, 23);
            textBoxFriesPrice.TabIndex = 8;
            textBoxFriesPrice.Text = "35.20";
            // 
            // textBoxHamburgerPrice
            // 
            textBoxHamburgerPrice.BackColor = Color.FromArgb(64, 64, 64);
            textBoxHamburgerPrice.ForeColor = SystemColors.MenuBar;
            textBoxHamburgerPrice.Location = new Point(125, 72);
            textBoxHamburgerPrice.Name = "textBoxHamburgerPrice";
            textBoxHamburgerPrice.ReadOnly = true;
            textBoxHamburgerPrice.Size = new Size(35, 23);
            textBoxHamburgerPrice.TabIndex = 7;
            textBoxHamburgerPrice.Text = "40.40";
            // 
            // textBoxHotDogPrice
            // 
            textBoxHotDogPrice.BackColor = Color.FromArgb(64, 64, 64);
            textBoxHotDogPrice.ForeColor = SystemColors.MenuBar;
            textBoxHotDogPrice.Location = new Point(125, 45);
            textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            textBoxHotDogPrice.ReadOnly = true;
            textBoxHotDogPrice.Size = new Size(35, 23);
            textBoxHotDogPrice.TabIndex = 6;
            textBoxHotDogPrice.Text = "50.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(185, 19);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(125, 19);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // checkBoxCola
            // 
            checkBoxCola.AutoSize = true;
            checkBoxCola.ForeColor = SystemColors.ButtonHighlight;
            checkBoxCola.Location = new Point(6, 132);
            checkBoxCola.Name = "checkBoxCola";
            checkBoxCola.Size = new Size(83, 19);
            checkBoxCola.TabIndex = 3;
            checkBoxCola.Text = "Кока-кола";
            checkBoxCola.UseVisualStyleBackColor = true;
            checkBoxCola.CheckedChanged += checkBoxCola_CheckedChanged;
            // 
            // checkBoxFries
            // 
            checkBoxFries.AutoSize = true;
            checkBoxFries.ForeColor = SystemColors.ButtonHighlight;
            checkBoxFries.Location = new Point(6, 102);
            checkBoxFries.Name = "checkBoxFries";
            checkBoxFries.Size = new Size(108, 19);
            checkBoxFries.TabIndex = 2;
            checkBoxFries.Text = "Кртофель-фри";
            checkBoxFries.UseVisualStyleBackColor = true;
            checkBoxFries.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBoxHamburger
            // 
            checkBoxHamburger.AutoSize = true;
            checkBoxHamburger.ForeColor = SystemColors.ButtonHighlight;
            checkBoxHamburger.Location = new Point(6, 74);
            checkBoxHamburger.Name = "checkBoxHamburger";
            checkBoxHamburger.Size = new Size(85, 19);
            checkBoxHamburger.TabIndex = 1;
            checkBoxHamburger.Text = "Гамбургер";
            checkBoxHamburger.UseVisualStyleBackColor = true;
            checkBoxHamburger.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBoxHotDog
            // 
            checkBoxHotDog.AutoSize = true;
            checkBoxHotDog.ForeColor = SystemColors.ButtonHighlight;
            checkBoxHotDog.Location = new Point(6, 45);
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.Size = new Size(68, 19);
            checkBoxHotDog.TabIndex = 0;
            checkBoxHotDog.Text = "Хот-дог";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelTotalSum);
            groupBox4.Controls.Add(buttonCalculate);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Cursor = Cursors.Cross;
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(12, 294);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(586, 120);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Всего к оплате";
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold);
            labelTotalSum.Location = new Point(302, 58);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(28, 32);
            labelTotalSum.TabIndex = 2;
            labelTotalSum.Text = "⠀";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculate.ForeColor = SystemColors.ActiveCaptionText;
            buttonCalculate.Location = new Point(112, 40);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(149, 55);
            buttonCalculate.TabIndex = 1;
            buttonCalculate.Text = "Расчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(604, 422);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nova Neft";
            FormClosing += MainForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxFuel;
        private Label Price;
        private TextBox textBoxFuelPrice;
        private GroupBox groupBox1;
        private RadioButton radioButtonSum;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxSum;
        private TextBox textBoxQuantity;
        private RadioButton radioButtonQuantity;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label1;
        private Label labelFuelTotal;
        private CheckBox checkBoxCola;
        private CheckBox checkBoxFries;
        private CheckBox checkBoxHamburger;
        private CheckBox checkBoxHotDog;
        private TextBox textBoxCocaColaPrice;
        private TextBox textBoxFriesPrice;
        private TextBox textBoxHamburgerPrice;
        private TextBox textBoxHotDogPrice;
        private Label label3;
        private Label label2;
        private TextBox textBoxColaQuantity;
        private TextBox textBoxHamburgerQuantity;
        private TextBox textBoxFriesQuantity;
        private TextBox textBoxHotDogQuantity;
        private GroupBox groupBox6;
        private Label labelCafeTotal;
        private Label labelTotalSum;
        private Button buttonCalculate;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
    }
}
