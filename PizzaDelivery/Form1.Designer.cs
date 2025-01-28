namespace PizzaDelivery
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
            this.lblName = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkChile = new System.Windows.Forms.CheckBox();
            this.checkKetchup = new System.Windows.Forms.CheckBox();
            this.checkGarlicSauce = new System.Windows.Forms.CheckBox();
            this.checkChubrica = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 145);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Тип пица:";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(58, 17);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Малка";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(6, 55);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Средна";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(6, 78);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(63, 17);
            this.rbBig.TabIndex = 5;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Голяма";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(466, 145);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Брой:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(469, 170);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 7;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Пеперони",
            "Маргарита",
            "Прошуто"});
            this.cmbType.Location = new System.Drawing.Point(41, 170);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Controls.Add(this.rbBig);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Location = new System.Drawing.Point(200, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер:";
            // 
            // checkChile
            // 
            this.checkChile.AutoSize = true;
            this.checkChile.Location = new System.Drawing.Point(6, 31);
            this.checkChile.Name = "checkChile";
            this.checkChile.Size = new System.Drawing.Size(74, 17);
            this.checkChile.TabIndex = 12;
            this.checkChile.Text = "Чили Сос";
            this.checkChile.UseVisualStyleBackColor = true;
            // 
            // checkKetchup
            // 
            this.checkKetchup.AutoSize = true;
            this.checkKetchup.Location = new System.Drawing.Point(6, 56);
            this.checkKetchup.Name = "checkKetchup";
            this.checkKetchup.Size = new System.Drawing.Size(60, 17);
            this.checkKetchup.TabIndex = 13;
            this.checkKetchup.Text = "Кетчуп";
            this.checkKetchup.UseVisualStyleBackColor = true;
            // 
            // checkGarlicSauce
            // 
            this.checkGarlicSauce.AutoSize = true;
            this.checkGarlicSauce.Location = new System.Drawing.Point(6, 79);
            this.checkGarlicSauce.Name = "checkGarlicSauce";
            this.checkGarlicSauce.Size = new System.Drawing.Size(86, 17);
            this.checkGarlicSauce.TabIndex = 14;
            this.checkGarlicSauce.Text = "Чеснов Сос";
            this.checkGarlicSauce.UseVisualStyleBackColor = true;
            // 
            // checkChubrica
            // 
            this.checkChubrica.AutoSize = true;
            this.checkChubrica.Location = new System.Drawing.Point(6, 102);
            this.checkChubrica.Name = "checkChubrica";
            this.checkChubrica.Size = new System.Drawing.Size(69, 17);
            this.checkChubrica.TabIndex = 15;
            this.checkChubrica.Text = "Чубрица";
            this.checkChubrica.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkChile);
            this.groupBox2.Controls.Add(this.checkChubrica);
            this.groupBox2.Controls.Add(this.checkKetchup);
            this.groupBox2.Controls.Add(this.checkGarlicSauce);
            this.groupBox2.Location = new System.Drawing.Point(640, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 149);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавки:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(343, 300);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 75);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Поръчка";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkChile;
        private System.Windows.Forms.CheckBox checkKetchup;
        private System.Windows.Forms.CheckBox checkGarlicSauce;
        private System.Windows.Forms.CheckBox checkChubrica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrder;
    }
}

