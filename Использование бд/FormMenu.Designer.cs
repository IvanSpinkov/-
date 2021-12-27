namespace Использование_бд
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.tbxSum2 = new System.Windows.Forms.TextBox();
            this.tbxZakaz2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb33 = new System.Windows.Forms.CheckBox();
            this.chb32 = new System.Windows.Forms.CheckBox();
            this.chb31 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt23 = new System.Windows.Forms.RadioButton();
            this.rbt22 = new System.Windows.Forms.RadioButton();
            this.rbt21 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt13 = new System.Windows.Forms.RadioButton();
            this.rbt12 = new System.Windows.Forms.RadioButton();
            this.rbt11 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(491, 299);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 32);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZakaz
            // 
            this.btnZakaz.Enabled = false;
            this.btnZakaz.Location = new System.Drawing.Point(492, 232);
            this.btnZakaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(188, 45);
            this.btnZakaz.TabIndex = 16;
            this.btnZakaz.Text = "Сформировать заказ:";
            this.btnZakaz.UseVisualStyleBackColor = true;
            this.btnZakaz.Click += new System.EventHandler(this.btnZakaz_Click);
            // 
            // tbxSum2
            // 
            this.tbxSum2.Location = new System.Drawing.Point(492, 70);
            this.tbxSum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSum2.Name = "tbxSum2";
            this.tbxSum2.Size = new System.Drawing.Size(188, 20);
            this.tbxSum2.TabIndex = 15;
            this.tbxSum2.TextChanged += new System.EventHandler(this.tbxSum2_TextChanged);
            this.tbxSum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSum2_KeyPress);
            // 
            // tbxZakaz2
            // 
            this.tbxZakaz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxZakaz2.Location = new System.Drawing.Point(232, 43);
            this.tbxZakaz2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxZakaz2.Multiline = true;
            this.tbxZakaz2.Name = "tbxZakaz2";
            this.tbxZakaz2.ReadOnly = true;
            this.tbxZakaz2.Size = new System.Drawing.Size(231, 288);
            this.tbxZakaz2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Заказ:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(524, 43);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(125, 13);
            this.lblSum.TabIndex = 12;
            this.lblSum.Text = "Сумма денег у клиента";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chb33);
            this.groupBox3.Controls.Add(this.chb32);
            this.groupBox3.Controls.Add(this.chb31);
            this.groupBox3.Location = new System.Drawing.Point(14, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(165, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Десерты и напитки";
            // 
            // chb33
            // 
            this.chb33.AutoSize = true;
            this.chb33.Location = new System.Drawing.Point(22, 63);
            this.chb33.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chb33.Name = "chb33";
            this.chb33.Size = new System.Drawing.Size(78, 17);
            this.chb33.TabIndex = 2;
            this.chb33.Text = "Кекс 30 р.";
            this.chb33.UseVisualStyleBackColor = true;
            // 
            // chb32
            // 
            this.chb32.AutoSize = true;
            this.chb32.Location = new System.Drawing.Point(22, 41);
            this.chb32.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chb32.Name = "chb32";
            this.chb32.Size = new System.Drawing.Size(149, 17);
            this.chb32.TabIndex = 1;
            this.chb32.Text = "Коктель молочный 35 р.";
            this.chb32.UseVisualStyleBackColor = true;
            // 
            // chb31
            // 
            this.chb31.AutoSize = true;
            this.chb31.Location = new System.Drawing.Point(22, 18);
            this.chb31.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chb31.Name = "chb31";
            this.chb31.Size = new System.Drawing.Size(80, 17);
            this.chb31.TabIndex = 0;
            this.chb31.Text = "Кофе 25 р.";
            this.chb31.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt23);
            this.groupBox2.Controls.Add(this.rbt22);
            this.groupBox2.Controls.Add(this.rbt21);
            this.groupBox2.Location = new System.Drawing.Point(14, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(188, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вторые блюда";
            // 
            // rbt23
            // 
            this.rbt23.AutoSize = true;
            this.rbt23.Location = new System.Drawing.Point(14, 63);
            this.rbt23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt23.Name = "rbt23";
            this.rbt23.Size = new System.Drawing.Size(180, 17);
            this.rbt23.TabIndex = 2;
            this.rbt23.TabStop = true;
            this.rbt23.Text = "жарёнка по-деревенски 240 р.";
            this.rbt23.UseVisualStyleBackColor = true;
            // 
            // rbt22
            // 
            this.rbt22.AutoSize = true;
            this.rbt22.Location = new System.Drawing.Point(14, 41);
            this.rbt22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt22.Name = "rbt22";
            this.rbt22.Size = new System.Drawing.Size(84, 17);
            this.rbt22.TabIndex = 1;
            this.rbt22.TabStop = true;
            this.rbt22.Text = "Плов 110 р.";
            this.rbt22.UseVisualStyleBackColor = true;
            // 
            // rbt21
            // 
            this.rbt21.AutoSize = true;
            this.rbt21.Location = new System.Drawing.Point(14, 17);
            this.rbt21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt21.Name = "rbt21";
            this.rbt21.Size = new System.Drawing.Size(166, 17);
            this.rbt21.TabIndex = 0;
            this.rbt21.TabStop = true;
            this.rbt21.Text = "Макороны по-флотски 90 р.";
            this.rbt21.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt13);
            this.groupBox1.Controls.Add(this.rbt12);
            this.groupBox1.Controls.Add(this.rbt11);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(188, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первые блюда";
            // 
            // rbt13
            // 
            this.rbt13.AutoSize = true;
            this.rbt13.Location = new System.Drawing.Point(12, 63);
            this.rbt13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt13.Name = "rbt13";
            this.rbt13.Size = new System.Drawing.Size(124, 17);
            this.rbt13.TabIndex = 2;
            this.rbt13.TabStop = true;
            this.rbt13.Text = "Суп молочный 80 р.";
            this.rbt13.UseVisualStyleBackColor = true;
            // 
            // rbt12
            // 
            this.rbt12.AutoSize = true;
            this.rbt12.Location = new System.Drawing.Point(12, 41);
            this.rbt12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt12.Name = "rbt12";
            this.rbt12.Size = new System.Drawing.Size(133, 17);
            this.rbt12.TabIndex = 1;
            this.rbt12.TabStop = true;
            this.rbt12.Text = "Суп гороховый - 70 р.";
            this.rbt12.UseVisualStyleBackColor = true;
            // 
            // rbt11
            // 
            this.rbt11.AutoSize = true;
            this.rbt11.Location = new System.Drawing.Point(12, 19);
            this.rbt11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt11.Name = "rbt11";
            this.rbt11.Size = new System.Drawing.Size(92, 17);
            this.rbt11.TabIndex = 0;
            this.rbt11.TabStop = true;
            this.rbt11.Text = "Борщ - 100 р.";
            this.rbt11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 425);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZakaz);
            this.Controls.Add(this.tbxSum2);
            this.Controls.Add(this.tbxZakaz2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.TextBox tbxSum2;
        private System.Windows.Forms.TextBox tbxZakaz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chb33;
        private System.Windows.Forms.CheckBox chb32;
        private System.Windows.Forms.CheckBox chb31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbt23;
        private System.Windows.Forms.RadioButton rbt22;
        private System.Windows.Forms.RadioButton rbt21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt13;
        private System.Windows.Forms.RadioButton rbt12;
        private System.Windows.Forms.RadioButton rbt11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}