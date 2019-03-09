namespace Posilki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Kcal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Carbohydrates = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sugar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Fat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Salt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Protein = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AmountError = new System.Windows.Forms.ErrorProvider(this.components);
            this.staticName = new System.Windows.Forms.Label();
            this.staticCarbohydrates = new System.Windows.Forms.Label();
            this.staticKcal = new System.Windows.Forms.Label();
            this.staticSugar = new System.Windows.Forms.Label();
            this.staticFat = new System.Windows.Forms.Label();
            this.staticSalt = new System.Windows.Forms.Label();
            this.staticWeight = new System.Windows.Forms.Label();
            this.staticProtein = new System.Windows.Forms.Label();
            this.staticCost = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.numericCarbohydrates = new System.Windows.Forms.NumericUpDown();
            this.numericKcal = new System.Windows.Forms.NumericUpDown();
            this.numericSugar = new System.Windows.Forms.NumericUpDown();
            this.numericFat = new System.Windows.Forms.NumericUpDown();
            this.numericSalt = new System.Windows.Forms.NumericUpDown();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.numericProtein = new System.Windows.Forms.NumericUpDown();
            this.numericCost = new System.Windows.Forms.NumericUpDown();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AmountError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbohydrates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKcal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(454, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 199);
            this.listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rice",
            "Potatoes",
            "Groats",
            "Pasta",
            "Bread",
            "Cheese",
            "Cola",
            "Apple",
            "Chips",
            "Chicken Breast Fry",
            "Chicken Breast Boiled",
            "Carrot",
            "Ham",
            "Egg",
            "Oil",
            "Bun",
            "Margarine",
            "Pork Chop",
            "Apple Juice",
            "Yoghourt",
            "Cookie",
            "Soup"});
            this.comboBox1.Location = new System.Drawing.Point(42, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pick";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 289);
            this.progressBar1.Maximum = 2400;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kcal";
            // 
            // Kcal
            // 
            this.Kcal.AutoSize = true;
            this.Kcal.Location = new System.Drawing.Point(76, 270);
            this.Kcal.Name = "Kcal";
            this.Kcal.Size = new System.Drawing.Size(13, 13);
            this.Kcal.TabIndex = 8;
            this.Kcal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Carbohydrates";
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.AutoSize = true;
            this.Carbohydrates.Location = new System.Drawing.Point(123, 319);
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.Size = new System.Drawing.Size(13, 13);
            this.Carbohydrates.TabIndex = 11;
            this.Carbohydrates.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sugar";
            // 
            // Sugar
            // 
            this.Sugar.AutoSize = true;
            this.Sugar.Location = new System.Drawing.Point(83, 336);
            this.Sugar.Name = "Sugar";
            this.Sugar.Size = new System.Drawing.Size(13, 13);
            this.Sugar.TabIndex = 13;
            this.Sugar.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fat";
            // 
            // Fat
            // 
            this.Fat.AutoSize = true;
            this.Fat.Location = new System.Drawing.Point(64, 352);
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(13, 13);
            this.Fat.TabIndex = 15;
            this.Fat.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Salt";
            // 
            // Salt
            // 
            this.Salt.AutoSize = true;
            this.Salt.Location = new System.Drawing.Point(64, 369);
            this.Salt.Name = "Salt";
            this.Salt.Size = new System.Drawing.Size(13, 13);
            this.Salt.TabIndex = 17;
            this.Salt.Text = "0";
            this.Salt.Click += new System.EventHandler(this.label13_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Protein";
            // 
            // Protein
            // 
            this.Protein.AutoSize = true;
            this.Protein.Location = new System.Drawing.Point(83, 385);
            this.Protein.Name = "Protein";
            this.Protein.Size = new System.Drawing.Size(13, 13);
            this.Protein.TabIndex = 19;
            this.Protein.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AmountError
            // 
            this.AmountError.ContainerControl = this;
            // 
            // staticName
            // 
            this.staticName.AutoSize = true;
            this.staticName.Location = new System.Drawing.Point(42, 426);
            this.staticName.Name = "staticName";
            this.staticName.Size = new System.Drawing.Size(35, 13);
            this.staticName.TabIndex = 21;
            this.staticName.Text = "Name";
            // 
            // staticCarbohydrates
            // 
            this.staticCarbohydrates.AutoSize = true;
            this.staticCarbohydrates.Location = new System.Drawing.Point(143, 426);
            this.staticCarbohydrates.Name = "staticCarbohydrates";
            this.staticCarbohydrates.Size = new System.Drawing.Size(75, 13);
            this.staticCarbohydrates.TabIndex = 22;
            this.staticCarbohydrates.Text = "Carbohydrates";
            // 
            // staticKcal
            // 
            this.staticKcal.AutoSize = true;
            this.staticKcal.Location = new System.Drawing.Point(227, 426);
            this.staticKcal.Name = "staticKcal";
            this.staticKcal.Size = new System.Drawing.Size(28, 13);
            this.staticKcal.TabIndex = 23;
            this.staticKcal.Text = "Kcal";
            this.staticKcal.Click += new System.EventHandler(this.staticKcal_Click);
            // 
            // staticSugar
            // 
            this.staticSugar.AutoSize = true;
            this.staticSugar.Location = new System.Drawing.Point(277, 426);
            this.staticSugar.Name = "staticSugar";
            this.staticSugar.Size = new System.Drawing.Size(35, 13);
            this.staticSugar.TabIndex = 24;
            this.staticSugar.Text = "Sugar";
            // 
            // staticFat
            // 
            this.staticFat.AutoSize = true;
            this.staticFat.Location = new System.Drawing.Point(324, 426);
            this.staticFat.Name = "staticFat";
            this.staticFat.Size = new System.Drawing.Size(22, 13);
            this.staticFat.TabIndex = 25;
            this.staticFat.Text = "Fat";
            // 
            // staticSalt
            // 
            this.staticSalt.AutoSize = true;
            this.staticSalt.Location = new System.Drawing.Point(380, 426);
            this.staticSalt.Name = "staticSalt";
            this.staticSalt.Size = new System.Drawing.Size(25, 13);
            this.staticSalt.TabIndex = 26;
            this.staticSalt.Text = "Salt";
            // 
            // staticWeight
            // 
            this.staticWeight.AutoSize = true;
            this.staticWeight.Location = new System.Drawing.Point(437, 426);
            this.staticWeight.Name = "staticWeight";
            this.staticWeight.Size = new System.Drawing.Size(41, 13);
            this.staticWeight.TabIndex = 27;
            this.staticWeight.Text = "Weight";
            // 
            // staticProtein
            // 
            this.staticProtein.AutoSize = true;
            this.staticProtein.Location = new System.Drawing.Point(497, 426);
            this.staticProtein.Name = "staticProtein";
            this.staticProtein.Size = new System.Drawing.Size(40, 13);
            this.staticProtein.TabIndex = 28;
            this.staticProtein.Text = "Protein";
            // 
            // staticCost
            // 
            this.staticCost.AutoSize = true;
            this.staticCost.Location = new System.Drawing.Point(561, 426);
            this.staticCost.Name = "staticCost";
            this.staticCost.Size = new System.Drawing.Size(28, 13);
            this.staticCost.TabIndex = 29;
            this.staticCost.Text = "Cost";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(36, 447);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 20);
            this.inputName.TabIndex = 31;
            // 
            // numericCarbohydrates
            // 
            this.numericCarbohydrates.Location = new System.Drawing.Point(146, 447);
            this.numericCarbohydrates.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCarbohydrates.Name = "numericCarbohydrates";
            this.numericCarbohydrates.Size = new System.Drawing.Size(60, 20);
            this.numericCarbohydrates.TabIndex = 32;
            // 
            // numericKcal
            // 
            this.numericKcal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericKcal.Location = new System.Drawing.Point(215, 447);
            this.numericKcal.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericKcal.Name = "numericKcal";
            this.numericKcal.Size = new System.Drawing.Size(58, 20);
            this.numericKcal.TabIndex = 33;
            // 
            // numericSugar
            // 
            this.numericSugar.Location = new System.Drawing.Point(280, 447);
            this.numericSugar.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSugar.Name = "numericSugar";
            this.numericSugar.Size = new System.Drawing.Size(40, 20);
            this.numericSugar.TabIndex = 34;
            // 
            // numericFat
            // 
            this.numericFat.Location = new System.Drawing.Point(327, 447);
            this.numericFat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericFat.Name = "numericFat";
            this.numericFat.Size = new System.Drawing.Size(49, 20);
            this.numericFat.TabIndex = 35;
            // 
            // numericSalt
            // 
            this.numericSalt.Location = new System.Drawing.Point(383, 447);
            this.numericSalt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSalt.Name = "numericSalt";
            this.numericSalt.Size = new System.Drawing.Size(51, 20);
            this.numericSalt.TabIndex = 36;
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(441, 446);
            this.numericWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(47, 20);
            this.numericWeight.TabIndex = 37;
            // 
            // numericProtein
            // 
            this.numericProtein.Location = new System.Drawing.Point(495, 447);
            this.numericProtein.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericProtein.Name = "numericProtein";
            this.numericProtein.Size = new System.Drawing.Size(43, 20);
            this.numericProtein.TabIndex = 38;
            // 
            // numericCost
            // 
            this.numericCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCost.Location = new System.Drawing.Point(545, 447);
            this.numericCost.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericCost.Name = "numericCost";
            this.numericCost.Size = new System.Drawing.Size(55, 20);
            this.numericCost.TabIndex = 39;
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(206, 31);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(67, 20);
            this.numericAmount.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 604);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.numericCost);
            this.Controls.Add(this.numericProtein);
            this.Controls.Add(this.numericWeight);
            this.Controls.Add(this.numericSalt);
            this.Controls.Add(this.numericFat);
            this.Controls.Add(this.numericSugar);
            this.Controls.Add(this.numericKcal);
            this.Controls.Add(this.numericCarbohydrates);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.staticCost);
            this.Controls.Add(this.staticProtein);
            this.Controls.Add(this.staticWeight);
            this.Controls.Add(this.staticSalt);
            this.Controls.Add(this.staticFat);
            this.Controls.Add(this.staticSugar);
            this.Controls.Add(this.staticKcal);
            this.Controls.Add(this.staticCarbohydrates);
            this.Controls.Add(this.staticName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Protein);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Fat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Sugar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Carbohydrates);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Kcal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmountError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbohydrates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKcal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Kcal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Carbohydrates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Sugar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Fat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Salt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Protein;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider AmountError;
        private System.Windows.Forms.Label staticFat;
        private System.Windows.Forms.Label staticSugar;
        private System.Windows.Forms.Label staticKcal;
        private System.Windows.Forms.Label staticCarbohydrates;
        private System.Windows.Forms.Label staticName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label staticCost;
        private System.Windows.Forms.Label staticProtein;
        private System.Windows.Forms.Label staticWeight;
        private System.Windows.Forms.Label staticSalt;
        private System.Windows.Forms.NumericUpDown numericKcal;
        private System.Windows.Forms.NumericUpDown numericCarbohydrates;
        private System.Windows.Forms.NumericUpDown numericCost;
        private System.Windows.Forms.NumericUpDown numericProtein;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.NumericUpDown numericSalt;
        private System.Windows.Forms.NumericUpDown numericFat;
        private System.Windows.Forms.NumericUpDown numericSugar;
        private System.Windows.Forms.NumericUpDown numericAmount;
    }
}

