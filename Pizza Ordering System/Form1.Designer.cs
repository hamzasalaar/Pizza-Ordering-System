namespace Pizza_Ordering_System
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            sicilianRadbtn = new RadioButton();
            marineRadbtn = new RadioButton();
            napolitanRadbtn = new RadioButton();
            mixedRadbtn = new RadioButton();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            groupBox5 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(6, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(879, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Name Surname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 59);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(sicilianRadbtn);
            groupBox2.Controls.Add(marineRadbtn);
            groupBox2.Controls.Add(napolitanRadbtn);
            groupBox2.Controls.Add(mixedRadbtn);
            groupBox2.Location = new Point(6, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 177);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pizza Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(143, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // sicilianRadbtn
            // 
            sicilianRadbtn.AutoSize = true;
            sicilianRadbtn.Location = new Point(6, 35);
            sicilianRadbtn.Name = "sicilianRadbtn";
            sicilianRadbtn.Size = new Size(77, 24);
            sicilianRadbtn.TabIndex = 1;
            sicilianRadbtn.TabStop = true;
            sicilianRadbtn.Text = "Sicilian";
            sicilianRadbtn.UseVisualStyleBackColor = true;
            // 
            // marineRadbtn
            // 
            marineRadbtn.AutoSize = true;
            marineRadbtn.Location = new Point(6, 65);
            marineRadbtn.Name = "marineRadbtn";
            marineRadbtn.Size = new Size(76, 24);
            marineRadbtn.TabIndex = 2;
            marineRadbtn.TabStop = true;
            marineRadbtn.Text = "Marine";
            marineRadbtn.UseVisualStyleBackColor = true;
            // 
            // napolitanRadbtn
            // 
            napolitanRadbtn.AutoSize = true;
            napolitanRadbtn.Location = new Point(6, 95);
            napolitanRadbtn.Name = "napolitanRadbtn";
            napolitanRadbtn.Size = new Size(96, 24);
            napolitanRadbtn.TabIndex = 3;
            napolitanRadbtn.TabStop = true;
            napolitanRadbtn.Text = "Napolitan";
            napolitanRadbtn.UseVisualStyleBackColor = true;
            // 
            // mixedRadbtn
            // 
            mixedRadbtn.AutoSize = true;
            mixedRadbtn.Location = new Point(6, 125);
            mixedRadbtn.Name = "mixedRadbtn";
            mixedRadbtn.Size = new Size(71, 24);
            mixedRadbtn.TabIndex = 4;
            mixedRadbtn.TabStop = true;
            mixedRadbtn.Text = "Mixed";
            mixedRadbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(6, 497);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 169);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(108, 59);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 133);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 13;
            label6.Text = "Calories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 12;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 11;
            label4.Text = "No of units";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Unit Price";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.Location = new Point(108, 125);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(160, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(108, 92);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(108, 26);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox5);
            groupBox4.Location = new Point(6, 314);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(283, 177);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Additions";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Green Pepper";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Tomato";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 97);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(69, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Pickle";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 127);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 24);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Mushroom";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(146, 37);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(65, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Olive";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(textBox6);
            groupBox5.Controls.Add(listBox1);
            groupBox5.Location = new Point(295, 131);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(590, 360);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Current Order";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 47);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 7;
            label8.Text = "Pizza";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(187, 47);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 8;
            label9.Text = "# of Unit";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 47);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 9;
            label10.Text = "Unit Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(463, 47);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 10;
            label11.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 310);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 14;
            label7.Text = "Grand Total";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlLightLight;
            textBox6.Location = new Point(406, 307);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(172, 27);
            textBox6.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(575, 204);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(298, 509);
            button1.Name = "button1";
            button1.Size = new Size(139, 55);
            button1.TabIndex = 2;
            button1.Text = "Insert Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(443, 509);
            button2.Name = "button2";
            button2.Size = new Size(139, 55);
            button2.TabIndex = 3;
            button2.Text = "Delete Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(588, 509);
            button3.Name = "button3";
            button3.Size = new Size(139, 54);
            button3.TabIndex = 4;
            button3.Text = "New Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(733, 509);
            button4.Name = "button4";
            button4.Size = new Size(139, 53);
            button4.TabIndex = 5;
            button4.Text = "New Customer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(298, 589);
            button5.Name = "button5";
            button5.Size = new Size(574, 53);
            button5.TabIndex = 6;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Sicilian.jpg");
            imageList1.Images.SetKeyName(1, "Marine.jpg");
            imageList1.Images.SetKeyName(2, "Napoliten.jpg");
            imageList1.Images.SetKeyName(3, "Mixed.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 678);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton sicilianRadbtn;
        private RadioButton marineRadbtn;
        private RadioButton napolitanRadbtn;
        private RadioButton mixedRadbtn;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private ListBox listBox1;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
