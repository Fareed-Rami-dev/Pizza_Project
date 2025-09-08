namespace Pizza_Project_Course_14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_largeSize = new System.Windows.Forms.RadioButton();
            this.rd_mediumSize = new System.Windows.Forms.RadioButton();
            this.rd_smallSize = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_smallCrust = new System.Windows.Forms.RadioButton();
            this.rd_thinCrust = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_greenPepper = new System.Windows.Forms.CheckBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_onion = new System.Windows.Forms.CheckBox();
            this.chk_tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_extraCheese = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_TakeOut = new System.Windows.Forms.RadioButton();
            this.rd_eatIn = new System.Windows.Forms.RadioButton();
            this.btn_orderPizza = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_WhereToEat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_crustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_toppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_largeSize);
            this.groupBox1.Controls.Add(this.rd_mediumSize);
            this.groupBox1.Controls.Add(this.rd_smallSize);
            this.groupBox1.Location = new System.Drawing.Point(32, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rd_largeSize
            // 
            this.rd_largeSize.AutoSize = true;
            this.rd_largeSize.Location = new System.Drawing.Point(22, 120);
            this.rd_largeSize.Name = "rd_largeSize";
            this.rd_largeSize.Size = new System.Drawing.Size(75, 24);
            this.rd_largeSize.TabIndex = 2;
            this.rd_largeSize.TabStop = true;
            this.rd_largeSize.Text = "Large";
            this.rd_largeSize.UseVisualStyleBackColor = true;
            this.rd_largeSize.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rd_mediumSize
            // 
            this.rd_mediumSize.AutoSize = true;
            this.rd_mediumSize.Location = new System.Drawing.Point(22, 85);
            this.rd_mediumSize.Name = "rd_mediumSize";
            this.rd_mediumSize.Size = new System.Drawing.Size(90, 24);
            this.rd_mediumSize.TabIndex = 1;
            this.rd_mediumSize.TabStop = true;
            this.rd_mediumSize.Text = "Medium";
            this.rd_mediumSize.UseVisualStyleBackColor = true;
            this.rd_mediumSize.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_smallSize
            // 
            this.rd_smallSize.AutoSize = true;
            this.rd_smallSize.Location = new System.Drawing.Point(22, 50);
            this.rd_smallSize.Name = "rd_smallSize";
            this.rd_smallSize.Size = new System.Drawing.Size(73, 24);
            this.rd_smallSize.TabIndex = 0;
            this.rd_smallSize.TabStop = true;
            this.rd_smallSize.Text = "Small";
            this.rd_smallSize.UseVisualStyleBackColor = true;
            this.rd_smallSize.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_smallCrust);
            this.groupBox2.Controls.Add(this.rd_thinCrust);
            this.groupBox2.Location = new System.Drawing.Point(31, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // rd_smallCrust
            // 
            this.rd_smallCrust.AutoSize = true;
            this.rd_smallCrust.Location = new System.Drawing.Point(23, 68);
            this.rd_smallCrust.Name = "rd_smallCrust";
            this.rd_smallCrust.Size = new System.Drawing.Size(115, 24);
            this.rd_smallCrust.TabIndex = 2;
            this.rd_smallCrust.TabStop = true;
            this.rd_smallCrust.Text = "Small Crust";
            this.rd_smallCrust.UseVisualStyleBackColor = true;
            this.rd_smallCrust.CheckedChanged += new System.EventHandler(this.rd_smallCrust_CheckedChanged);
            // 
            // rd_thinCrust
            // 
            this.rd_thinCrust.AutoSize = true;
            this.rd_thinCrust.Location = new System.Drawing.Point(23, 38);
            this.rd_thinCrust.Name = "rd_thinCrust";
            this.rd_thinCrust.Size = new System.Drawing.Size(106, 24);
            this.rd_thinCrust.TabIndex = 1;
            this.rd_thinCrust.TabStop = true;
            this.rd_thinCrust.Text = "Thin Crust";
            this.rd_thinCrust.UseVisualStyleBackColor = true;
            this.rd_thinCrust.CheckedChanged += new System.EventHandler(this.rd_thinCrust_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_greenPepper);
            this.groupBox3.Controls.Add(this.chk_olives);
            this.groupBox3.Controls.Add(this.chk_onion);
            this.groupBox3.Controls.Add(this.chk_tomatoes);
            this.groupBox3.Controls.Add(this.chk_mushrooms);
            this.groupBox3.Controls.Add(this.chk_extraCheese);
            this.groupBox3.Location = new System.Drawing.Point(346, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chk_greenPepper
            // 
            this.chk_greenPepper.AutoSize = true;
            this.chk_greenPepper.Location = new System.Drawing.Point(138, 108);
            this.chk_greenPepper.Name = "chk_greenPepper";
            this.chk_greenPepper.Size = new System.Drawing.Size(135, 24);
            this.chk_greenPepper.TabIndex = 5;
            this.chk_greenPepper.Text = "Green Pepper";
            this.chk_greenPepper.UseVisualStyleBackColor = true;
            this.chk_greenPepper.CheckedChanged += new System.EventHandler(this.chk_greenPepper_CheckedChanged);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.Location = new System.Drawing.Point(157, 78);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(77, 24);
            this.chk_olives.TabIndex = 4;
            this.chk_olives.Text = "Olives";
            this.chk_olives.UseVisualStyleBackColor = true;
            this.chk_olives.CheckedChanged += new System.EventHandler(this.chk_olives_CheckedChanged);
            // 
            // chk_onion
            // 
            this.chk_onion.AutoSize = true;
            this.chk_onion.Location = new System.Drawing.Point(157, 48);
            this.chk_onion.Name = "chk_onion";
            this.chk_onion.Size = new System.Drawing.Size(77, 24);
            this.chk_onion.TabIndex = 3;
            this.chk_onion.Text = "Onion";
            this.chk_onion.UseVisualStyleBackColor = true;
            this.chk_onion.CheckedChanged += new System.EventHandler(this.chk_onion_CheckedChanged);
            // 
            // chk_tomatoes
            // 
            this.chk_tomatoes.AutoSize = true;
            this.chk_tomatoes.Location = new System.Drawing.Point(6, 112);
            this.chk_tomatoes.Name = "chk_tomatoes";
            this.chk_tomatoes.Size = new System.Drawing.Size(106, 24);
            this.chk_tomatoes.TabIndex = 2;
            this.chk_tomatoes.Text = "Tomatoes";
            this.chk_tomatoes.UseVisualStyleBackColor = true;
            this.chk_tomatoes.CheckedChanged += new System.EventHandler(this.chk_tomatoes_CheckedChanged);
            // 
            // chk_mushrooms
            // 
            this.chk_mushrooms.AutoSize = true;
            this.chk_mushrooms.Location = new System.Drawing.Point(6, 78);
            this.chk_mushrooms.Name = "chk_mushrooms";
            this.chk_mushrooms.Size = new System.Drawing.Size(118, 24);
            this.chk_mushrooms.TabIndex = 1;
            this.chk_mushrooms.Text = "Mushrooms";
            this.chk_mushrooms.UseVisualStyleBackColor = true;
            this.chk_mushrooms.CheckedChanged += new System.EventHandler(this.chk_mushrooms_CheckedChanged);
            // 
            // chk_extraCheese
            // 
            this.chk_extraCheese.AutoSize = true;
            this.chk_extraCheese.Location = new System.Drawing.Point(6, 44);
            this.chk_extraCheese.Name = "chk_extraCheese";
            this.chk_extraCheese.Size = new System.Drawing.Size(131, 24);
            this.chk_extraCheese.TabIndex = 0;
            this.chk_extraCheese.Text = "Extra Cheese";
            this.chk_extraCheese.UseVisualStyleBackColor = true;
            this.chk_extraCheese.CheckedChanged += new System.EventHandler(this.chk_extraCheese_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_TakeOut);
            this.groupBox4.Controls.Add(this.rd_eatIn);
            this.groupBox4.Location = new System.Drawing.Point(300, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where to eat";
            // 
            // rd_TakeOut
            // 
            this.rd_TakeOut.AutoSize = true;
            this.rd_TakeOut.Location = new System.Drawing.Point(21, 56);
            this.rd_TakeOut.Name = "rd_TakeOut";
            this.rd_TakeOut.Size = new System.Drawing.Size(99, 24);
            this.rd_TakeOut.TabIndex = 1;
            this.rd_TakeOut.TabStop = true;
            this.rd_TakeOut.Text = "Take Out";
            this.rd_TakeOut.UseVisualStyleBackColor = true;
            this.rd_TakeOut.CheckedChanged += new System.EventHandler(this.rd_TakeOut_CheckedChanged);
            // 
            // rd_eatIn
            // 
            this.rd_eatIn.AutoSize = true;
            this.rd_eatIn.Location = new System.Drawing.Point(21, 26);
            this.rd_eatIn.Name = "rd_eatIn";
            this.rd_eatIn.Size = new System.Drawing.Size(77, 24);
            this.rd_eatIn.TabIndex = 0;
            this.rd_eatIn.TabStop = true;
            this.rd_eatIn.Text = "Eat In";
            this.rd_eatIn.UseVisualStyleBackColor = true;
            this.rd_eatIn.CheckedChanged += new System.EventHandler(this.rd_eatIn_CheckedChanged);
            // 
            // btn_orderPizza
            // 
            this.btn_orderPizza.AutoSize = true;
            this.btn_orderPizza.Location = new System.Drawing.Point(300, 398);
            this.btn_orderPizza.Name = "btn_orderPizza";
            this.btn_orderPizza.Size = new System.Drawing.Size(101, 40);
            this.btn_orderPizza.TabIndex = 4;
            this.btn_orderPizza.Text = "Order Pizza";
            this.btn_orderPizza.UseVisualStyleBackColor = true;
            this.btn_orderPizza.Click += new System.EventHandler(this.btn_orderPizza_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.AutoSize = true;
            this.btn_resetForm.Location = new System.Drawing.Point(423, 398);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(103, 40);
            this.btn_resetForm.TabIndex = 5;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = true;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.lbl_TotalPrice);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lbl_WhereToEat);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lbl_crustType);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lbl_toppings);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lbl_size);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(722, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(749, 354);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Sumary";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_TotalPrice.Location = new System.Drawing.Point(120, 184);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(105, 110);
            this.lbl_TotalPrice.TabIndex = 9;
            this.lbl_TotalPrice.Text = "0";
            this.lbl_TotalPrice.Click += new System.EventHandler(this.lbl_TotalPrice_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Price";
            // 
            // lbl_WhereToEat
            // 
            this.lbl_WhereToEat.AutoSize = true;
            this.lbl_WhereToEat.Location = new System.Drawing.Point(150, 152);
            this.lbl_WhereToEat.Name = "lbl_WhereToEat";
            this.lbl_WhereToEat.Size = new System.Drawing.Size(31, 20);
            this.lbl_WhereToEat.TabIndex = 7;
            this.lbl_WhereToEat.Text = "NA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Where to Eat";
            // 
            // lbl_crustType
            // 
            this.lbl_crustType.AutoSize = true;
            this.lbl_crustType.Location = new System.Drawing.Point(138, 120);
            this.lbl_crustType.Name = "lbl_crustType";
            this.lbl_crustType.Size = new System.Drawing.Size(31, 20);
            this.lbl_crustType.TabIndex = 5;
            this.lbl_crustType.Text = "NA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crust Type";
            // 
            // lbl_toppings
            // 
            this.lbl_toppings.AutoSize = true;
            this.lbl_toppings.Location = new System.Drawing.Point(117, 75);
            this.lbl_toppings.Name = "lbl_toppings";
            this.lbl_toppings.Size = new System.Drawing.Size(31, 20);
            this.lbl_toppings.TabIndex = 3;
            this.lbl_toppings.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(96, 32);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(31, 20);
            this.lbl_size.TabIndex = 1;
            this.lbl_size.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1569, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_resetForm);
            this.Controls.Add(this.btn_orderPizza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_largeSize;
        private System.Windows.Forms.RadioButton rd_mediumSize;
        private System.Windows.Forms.RadioButton rd_smallSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_smallCrust;
        private System.Windows.Forms.RadioButton rd_thinCrust;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_greenPepper;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_onion;
        private System.Windows.Forms.CheckBox chk_tomatoes;
        private System.Windows.Forms.CheckBox chk_mushrooms;
        private System.Windows.Forms.CheckBox chk_extraCheese;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_TakeOut;
        private System.Windows.Forms.RadioButton rd_eatIn;
        private System.Windows.Forms.Button btn_orderPizza;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_WhereToEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_crustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_toppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label1;
    }
}

