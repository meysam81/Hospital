namespace Hospital
{
    partial class FormReleasePatient
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
            this.buttonAcceptRelease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showPriceTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDarayeBime = new System.Windows.Forms.CheckBox();
            this.checkBoxBakhsheKhosousi = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTarkhis = new System.Windows.Forms.DateTimePicker();
            this.textBoxTarkhis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownBastari = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTazrighat = new System.Windows.Forms.CheckBox();
            this.checkBoxRadioLojy = new System.Windows.Forms.CheckBox();
            this.checkBoxBastari = new System.Windows.Forms.CheckBox();
            this.checkBoxJarahi = new System.Windows.Forms.CheckBox();
            this.checkBoxAzmayeshgah = new System.Windows.Forms.CheckBox();
            this.checkBoxPazireshOrjansi = new System.Windows.Forms.CheckBox();
            this.buttonBaresiTaghirat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBastari)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAcceptRelease
            // 
            this.buttonAcceptRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAcceptRelease.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.buttonAcceptRelease.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAcceptRelease.Location = new System.Drawing.Point(296, 546);
            this.buttonAcceptRelease.Name = "buttonAcceptRelease";
            this.buttonAcceptRelease.Size = new System.Drawing.Size(79, 41);
            this.buttonAcceptRelease.TabIndex = 2;
            this.buttonAcceptRelease.Text = "اعمال";
            this.buttonAcceptRelease.UseVisualStyleBackColor = false;
            this.buttonAcceptRelease.Click += new System.EventHandler(this.buttonAcceptRelease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد بیمارستانی بیمار";
            // 
            // textBoxPatientId
            // 
            this.textBoxPatientId.Location = new System.Drawing.Point(153, 30);
            this.textBoxPatientId.Name = "textBoxPatientId";
            this.textBoxPatientId.ReadOnly = true;
            this.textBoxPatientId.Size = new System.Drawing.Size(153, 31);
            this.textBoxPatientId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد ملی";
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(153, 83);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.ReadOnly = true;
            this.textBoxSSN.Size = new System.Drawing.Size(153, 31);
            this.textBoxSSN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "هزینه‌های بیمارستان";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(140, 499);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(153, 31);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPriceTableToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showPriceTableToolStripMenuItem
            // 
            this.showPriceTableToolStripMenuItem.Name = "showPriceTableToolStripMenuItem";
            this.showPriceTableToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.showPriceTableToolStripMenuItem.Text = "نمایش جدول صندوق";
            this.showPriceTableToolStripMenuItem.Click += new System.EventHandler(this.showPriceTableToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "(ریال)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDarayeBime);
            this.groupBox1.Controls.Add(this.checkBoxBakhsheKhosousi);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پذیرش و ترخیص";
            // 
            // checkBoxDarayeBime
            // 
            this.checkBoxDarayeBime.AutoSize = true;
            this.checkBoxDarayeBime.Location = new System.Drawing.Point(48, 30);
            this.checkBoxDarayeBime.Name = "checkBoxDarayeBime";
            this.checkBoxDarayeBime.Size = new System.Drawing.Size(80, 28);
            this.checkBoxDarayeBime.TabIndex = 1;
            this.checkBoxDarayeBime.Text = "دارای بیمه";
            this.checkBoxDarayeBime.UseVisualStyleBackColor = true;
            // 
            // checkBoxBakhsheKhosousi
            // 
            this.checkBoxBakhsheKhosousi.AutoSize = true;
            this.checkBoxBakhsheKhosousi.Location = new System.Drawing.Point(207, 30);
            this.checkBoxBakhsheKhosousi.Name = "checkBoxBakhsheKhosousi";
            this.checkBoxBakhsheKhosousi.Size = new System.Drawing.Size(103, 28);
            this.checkBoxBakhsheKhosousi.TabIndex = 0;
            this.checkBoxBakhsheKhosousi.Text = "بخش خصوصی";
            this.checkBoxBakhsheKhosousi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePickerTarkhis);
            this.panel2.Controls.Add(this.textBoxTarkhis);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(8, 68);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(302, 91);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 7);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "تاریخ ترخیص";
            // 
            // dateTimePickerTarkhis
            // 
            this.dateTimePickerTarkhis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTarkhis.Location = new System.Drawing.Point(9, 7);
            this.dateTimePickerTarkhis.Name = "dateTimePickerTarkhis";
            this.dateTimePickerTarkhis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerTarkhis.Size = new System.Drawing.Size(153, 31);
            this.dateTimePickerTarkhis.TabIndex = 0;
            this.dateTimePickerTarkhis.ValueChanged += new System.EventHandler(this.dateTimePickerTarkhis_ValueChanged);
            // 
            // textBoxTarkhis
            // 
            this.textBoxTarkhis.Location = new System.Drawing.Point(9, 54);
            this.textBoxTarkhis.Name = "textBoxTarkhis";
            this.textBoxTarkhis.ReadOnly = true;
            this.textBoxTarkhis.Size = new System.Drawing.Size(153, 31);
            this.textBoxTarkhis.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "معادل شمسی";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownBastari);
            this.groupBox2.Controls.Add(this.checkBoxTazrighat);
            this.groupBox2.Controls.Add(this.checkBoxRadioLojy);
            this.groupBox2.Controls.Add(this.checkBoxBastari);
            this.groupBox2.Controls.Add(this.checkBoxJarahi);
            this.groupBox2.Controls.Add(this.checkBoxAzmayeshgah);
            this.groupBox2.Controls.Add(this.checkBoxPazireshOrjansi);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "خدمات استفاده شده";
            // 
            // numericUpDownBastari
            // 
            this.numericUpDownBastari.Enabled = false;
            this.numericUpDownBastari.Location = new System.Drawing.Point(48, 29);
            this.numericUpDownBastari.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownBastari.Name = "numericUpDownBastari";
            this.numericUpDownBastari.ReadOnly = true;
            this.numericUpDownBastari.Size = new System.Drawing.Size(44, 31);
            this.numericUpDownBastari.TabIndex = 4;
            // 
            // checkBoxTazrighat
            // 
            this.checkBoxTazrighat.AutoSize = true;
            this.checkBoxTazrighat.Location = new System.Drawing.Point(108, 115);
            this.checkBoxTazrighat.Name = "checkBoxTazrighat";
            this.checkBoxTazrighat.Size = new System.Drawing.Size(67, 28);
            this.checkBoxTazrighat.TabIndex = 6;
            this.checkBoxTazrighat.Text = "تزریقات";
            this.checkBoxTazrighat.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadioLojy
            // 
            this.checkBoxRadioLojy.AutoSize = true;
            this.checkBoxRadioLojy.Location = new System.Drawing.Point(99, 73);
            this.checkBoxRadioLojy.Name = "checkBoxRadioLojy";
            this.checkBoxRadioLojy.Size = new System.Drawing.Size(76, 28);
            this.checkBoxRadioLojy.TabIndex = 5;
            this.checkBoxRadioLojy.Text = "رادیولوژی";
            this.checkBoxRadioLojy.UseVisualStyleBackColor = true;
            // 
            // checkBoxBastari
            // 
            this.checkBoxBastari.AutoSize = true;
            this.checkBoxBastari.Location = new System.Drawing.Point(113, 30);
            this.checkBoxBastari.Name = "checkBoxBastari";
            this.checkBoxBastari.Size = new System.Drawing.Size(62, 28);
            this.checkBoxBastari.TabIndex = 3;
            this.checkBoxBastari.Text = "بستری";
            this.checkBoxBastari.UseVisualStyleBackColor = true;
            this.checkBoxBastari.CheckedChanged += new System.EventHandler(this.checkBoxBastari_CheckedChanged);
            // 
            // checkBoxJarahi
            // 
            this.checkBoxJarahi.AutoSize = true;
            this.checkBoxJarahi.Location = new System.Drawing.Point(291, 115);
            this.checkBoxJarahi.Name = "checkBoxJarahi";
            this.checkBoxJarahi.Size = new System.Drawing.Size(63, 28);
            this.checkBoxJarahi.TabIndex = 2;
            this.checkBoxJarahi.Text = "جراحی";
            this.checkBoxJarahi.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzmayeshgah
            // 
            this.checkBoxAzmayeshgah.AutoSize = true;
            this.checkBoxAzmayeshgah.Location = new System.Drawing.Point(278, 73);
            this.checkBoxAzmayeshgah.Name = "checkBoxAzmayeshgah";
            this.checkBoxAzmayeshgah.Size = new System.Drawing.Size(76, 28);
            this.checkBoxAzmayeshgah.TabIndex = 1;
            this.checkBoxAzmayeshgah.Text = "آزمایشگاه";
            this.checkBoxAzmayeshgah.UseVisualStyleBackColor = true;
            // 
            // checkBoxPazireshOrjansi
            // 
            this.checkBoxPazireshOrjansi.AutoSize = true;
            this.checkBoxPazireshOrjansi.Location = new System.Drawing.Point(244, 30);
            this.checkBoxPazireshOrjansi.Name = "checkBoxPazireshOrjansi";
            this.checkBoxPazireshOrjansi.Size = new System.Drawing.Size(110, 28);
            this.checkBoxPazireshOrjansi.TabIndex = 0;
            this.checkBoxPazireshOrjansi.Text = "پذیرش اورژانسی";
            this.checkBoxPazireshOrjansi.UseVisualStyleBackColor = true;
            // 
            // buttonBaresiTaghirat
            // 
            this.buttonBaresiTaghirat.BackColor = System.Drawing.Color.Lime;
            this.buttonBaresiTaghirat.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.buttonBaresiTaghirat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBaresiTaghirat.Location = new System.Drawing.Point(153, 546);
            this.buttonBaresiTaghirat.Name = "buttonBaresiTaghirat";
            this.buttonBaresiTaghirat.Size = new System.Drawing.Size(140, 41);
            this.buttonBaresiTaghirat.TabIndex = 2;
            this.buttonBaresiTaghirat.Text = "بررسی تغییرات";
            this.buttonBaresiTaghirat.UseVisualStyleBackColor = false;
            this.buttonBaresiTaghirat.Visible = false;
            this.buttonBaresiTaghirat.Click += new System.EventHandler(this.buttonBaresiTaghirat_Click);
            // 
            // FormReleasePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(381, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBaresiTaghirat);
            this.Controls.Add(this.buttonAcceptRelease);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormReleasePatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترخیص بیمار";
            this.Activated += new System.EventHandler(this.FormReleasePatient_Activated);
            this.Load += new System.EventHandler(this.FormReleasePatient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBastari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptRelease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPriceTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxPatientId;
        public System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBakhsheKhosousi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownBastari;
        private System.Windows.Forms.CheckBox checkBoxBastari;
        private System.Windows.Forms.CheckBox checkBoxJarahi;
        private System.Windows.Forms.CheckBox checkBoxAzmayeshgah;
        private System.Windows.Forms.CheckBox checkBoxPazireshOrjansi;
        private System.Windows.Forms.CheckBox checkBoxRadioLojy;
        private System.Windows.Forms.CheckBox checkBoxDarayeBime;
        private System.Windows.Forms.CheckBox checkBoxTazrighat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarkhis;
        private System.Windows.Forms.TextBox textBoxTarkhis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBaresiTaghirat;
    }
}