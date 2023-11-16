namespace anket2023
{
    partial class anketFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listelebtn = new System.Windows.Forms.Button();
            this.listelst = new System.Windows.Forms.ListBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sec3txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sec2txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sec1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sorutxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baslatbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sec1rb = new System.Windows.Forms.RadioButton();
            this.sec2rb = new System.Windows.Forms.RadioButton();
            this.sec3rb = new System.Windows.Forms.RadioButton();
            this.ilerlebtn = new System.Windows.Forms.Button();
            this.sorrtb = new System.Windows.Forms.RichTextBox();
            this.sgosterbtn = new System.Windows.Forms.Button();
            this.istatistiklst = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listelebtn);
            this.groupBox1.Controls.Add(this.listelst);
            this.groupBox1.Controls.Add(this.kaydetbtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sec3txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sec2txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sec1txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sorutxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket Hazırla";
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(168, 158);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(99, 35);
            this.listelebtn.TabIndex = 10;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // listelst
            // 
            this.listelst.FormattingEnabled = true;
            this.listelst.ItemHeight = 16;
            this.listelst.Location = new System.Drawing.Point(11, 212);
            this.listelst.Name = "listelst";
            this.listelst.Size = new System.Drawing.Size(361, 196);
            this.listelst.TabIndex = 9;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(273, 158);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(99, 35);
            this.kaydetbtn.TabIndex = 8;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seçenek 3";
            // 
            // sec3txt
            // 
            this.sec3txt.Location = new System.Drawing.Point(85, 121);
            this.sec3txt.Name = "sec3txt";
            this.sec3txt.Size = new System.Drawing.Size(287, 22);
            this.sec3txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seçenek 2";
            // 
            // sec2txt
            // 
            this.sec2txt.Location = new System.Drawing.Point(85, 93);
            this.sec2txt.Name = "sec2txt";
            this.sec2txt.Size = new System.Drawing.Size(287, 22);
            this.sec2txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçenek 1";
            // 
            // sec1txt
            // 
            this.sec1txt.Location = new System.Drawing.Point(85, 65);
            this.sec1txt.Name = "sec1txt";
            this.sec1txt.Size = new System.Drawing.Size(287, 22);
            this.sec1txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru";
            // 
            // sorutxt
            // 
            this.sorutxt.Location = new System.Drawing.Point(85, 37);
            this.sorutxt.Name = "sorutxt";
            this.sorutxt.Size = new System.Drawing.Size(287, 22);
            this.sorutxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.istatistiklst);
            this.groupBox2.Controls.Add(this.sgosterbtn);
            this.groupBox2.Controls.Add(this.sorrtb);
            this.groupBox2.Controls.Add(this.ilerlebtn);
            this.groupBox2.Controls.Add(this.sec3rb);
            this.groupBox2.Controls.Add(this.sec2rb);
            this.groupBox2.Controls.Add(this.sec1rb);
            this.groupBox2.Controls.Add(this.baslatbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anket Oylama";
            // 
            // baslatbtn
            // 
            this.baslatbtn.Location = new System.Drawing.Point(317, 237);
            this.baslatbtn.Name = "baslatbtn";
            this.baslatbtn.Size = new System.Drawing.Size(99, 35);
            this.baslatbtn.TabIndex = 11;
            this.baslatbtn.Text = "Başlat";
            this.baslatbtn.UseVisualStyleBackColor = true;
            this.baslatbtn.Click += new System.EventHandler(this.baslatbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soru:";
            // 
            // sec1rb
            // 
            this.sec1rb.AutoSize = true;
            this.sec1rb.Location = new System.Drawing.Point(71, 149);
            this.sec1rb.Name = "sec1rb";
            this.sec1rb.Size = new System.Drawing.Size(17, 16);
            this.sec1rb.TabIndex = 13;
            this.sec1rb.TabStop = true;
            this.sec1rb.UseVisualStyleBackColor = true;
            // 
            // sec2rb
            // 
            this.sec2rb.AutoSize = true;
            this.sec2rb.Location = new System.Drawing.Point(71, 177);
            this.sec2rb.Name = "sec2rb";
            this.sec2rb.Size = new System.Drawing.Size(17, 16);
            this.sec2rb.TabIndex = 14;
            this.sec2rb.TabStop = true;
            this.sec2rb.UseVisualStyleBackColor = true;
            // 
            // sec3rb
            // 
            this.sec3rb.AutoSize = true;
            this.sec3rb.Location = new System.Drawing.Point(71, 205);
            this.sec3rb.Name = "sec3rb";
            this.sec3rb.Size = new System.Drawing.Size(17, 16);
            this.sec3rb.TabIndex = 15;
            this.sec3rb.TabStop = true;
            this.sec3rb.UseVisualStyleBackColor = true;
            // 
            // ilerlebtn
            // 
            this.ilerlebtn.Location = new System.Drawing.Point(167, 237);
            this.ilerlebtn.Name = "ilerlebtn";
            this.ilerlebtn.Size = new System.Drawing.Size(99, 35);
            this.ilerlebtn.TabIndex = 16;
            this.ilerlebtn.Text = "İlerle";
            this.ilerlebtn.UseVisualStyleBackColor = true;
            this.ilerlebtn.Click += new System.EventHandler(this.ilerlebtn_Click);
            // 
            // sorrtb
            // 
            this.sorrtb.Location = new System.Drawing.Point(71, 37);
            this.sorrtb.Name = "sorrtb";
            this.sorrtb.Size = new System.Drawing.Size(355, 96);
            this.sorrtb.TabIndex = 17;
            this.sorrtb.Text = "";
            // 
            // sgosterbtn
            // 
            this.sgosterbtn.Location = new System.Drawing.Point(30, 237);
            this.sgosterbtn.Name = "sgosterbtn";
            this.sgosterbtn.Size = new System.Drawing.Size(127, 35);
            this.sgosterbtn.TabIndex = 18;
            this.sgosterbtn.Text = "Sonuçları Göster";
            this.sgosterbtn.UseVisualStyleBackColor = true;
            this.sgosterbtn.Click += new System.EventHandler(this.sgosterbtn_Click);
            // 
            // istatistiklst
            // 
            this.istatistiklst.FormattingEnabled = true;
            this.istatistiklst.HorizontalScrollbar = true;
            this.istatistiklst.ItemHeight = 16;
            this.istatistiklst.Location = new System.Drawing.Point(30, 294);
            this.istatistiklst.Name = "istatistiklst";
            this.istatistiklst.Size = new System.Drawing.Size(396, 116);
            this.istatistiklst.TabIndex = 11;
            // 
            // anketFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "anketFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sec3txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sec2txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sec1txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sorutxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.ListBox listelst;
        private System.Windows.Forms.Button baslatbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ilerlebtn;
        private System.Windows.Forms.RadioButton sec3rb;
        private System.Windows.Forms.RadioButton sec2rb;
        private System.Windows.Forms.RadioButton sec1rb;
        private System.Windows.Forms.RichTextBox sorrtb;
        private System.Windows.Forms.Button sgosterbtn;
        private System.Windows.Forms.ListBox istatistiklst;
    }
}

