namespace CSharp_Dangkimonhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.cbxNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndangki = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.clbMonhoc = new System.Windows.Forms.CheckedListBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(222, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÍ MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niên khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Năm học";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(183, 68);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(121, 20);
            this.txtMSSV.TabIndex = 7;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(183, 122);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(121, 20);
            this.txtHovaten.TabIndex = 10;
            // 
            // cbxNienkhoa
            // 
            this.cbxNienkhoa.FormattingEnabled = true;
            this.cbxNienkhoa.Location = new System.Drawing.Point(183, 171);
            this.cbxNienkhoa.Name = "cbxNienkhoa";
            this.cbxNienkhoa.Size = new System.Drawing.Size(121, 21);
            this.cbxNienkhoa.TabIndex = 12;
            this.cbxNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbxNienkhoa_SelectedIndexChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(183, 210);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(121, 21);
            this.cbxLop.TabIndex = 13;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(229, 432);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(112, 35);
            this.btnhuy.TabIndex = 15;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btndangki
            // 
            this.btndangki.Location = new System.Drawing.Point(63, 432);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(112, 35);
            this.btndangki.TabIndex = 17;
            this.btndangki.Text = "ĐĂNG KÍ";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(398, 432);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 35);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(217, 254);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(31, 17);
            this.rad2.TabIndex = 20;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(266, 252);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(34, 17);
            this.rad3.TabIndex = 21;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(306, 252);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(35, 17);
            this.rad4.TabIndex = 22;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // clbMonhoc
            // 
            this.clbMonhoc.FormattingEnabled = true;
            this.clbMonhoc.Items.AddRange(new object[] {
            "LT WIN",
            "LT INTERNET",
            "Mạng máy tính",
            "UML"});
            this.clbMonhoc.Location = new System.Drawing.Point(183, 298);
            this.clbMonhoc.Name = "clbMonhoc";
            this.clbMonhoc.Size = new System.Drawing.Size(199, 79);
            this.clbMonhoc.TabIndex = 23;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(180, 254);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(28, 17);
            this.rad1.TabIndex = 24;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.clbMonhoc);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxNienkhoa);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.ComboBox cbxNienkhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.CheckedListBox clbMonhoc;
        private System.Windows.Forms.RadioButton rad1;
    }
}

