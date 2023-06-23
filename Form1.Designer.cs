namespace BilesikGetiriHesaplamaV2
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
            this.txt_anaPara = new System.Windows.Forms.TextBox();
            this.txt_vade = new System.Windows.Forms.TextBox();
            this.txt_karYuzdesi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_yuzdeKacArtti = new System.Windows.Forms.Label();
            this.lbl_yuzdeKacOldu = new System.Windows.Forms.Label();
            this.lbl_sonGelenPara = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_toplamPara = new System.Windows.Forms.Label();
            this.lbl_kacKatinaCikti = new System.Windows.Forms.Label();
            this.lbl_neKadarArtti = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_periyodikEklenecekMiktar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaPlanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_anaPara
            // 
            this.txt_anaPara.Location = new System.Drawing.Point(40, 160);
            this.txt_anaPara.Multiline = true;
            this.txt_anaPara.Name = "txt_anaPara";
            this.txt_anaPara.Size = new System.Drawing.Size(136, 48);
            this.txt_anaPara.TabIndex = 0;
            // 
            // txt_vade
            // 
            this.txt_vade.Location = new System.Drawing.Point(267, 182);
            this.txt_vade.Multiline = true;
            this.txt_vade.Name = "txt_vade";
            this.txt_vade.Size = new System.Drawing.Size(136, 48);
            this.txt_vade.TabIndex = 2;
            // 
            // txt_karYuzdesi
            // 
            this.txt_karYuzdesi.Location = new System.Drawing.Point(491, 160);
            this.txt_karYuzdesi.Multiline = true;
            this.txt_karYuzdesi.Name = "txt_karYuzdesi";
            this.txt_karYuzdesi.Size = new System.Drawing.Size(136, 48);
            this.txt_karYuzdesi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ana Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kar Yüzdesi";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.btn_hesapla.Location = new System.Drawing.Point(267, 103);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(137, 50);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gün/Ay/Yıl";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gün",
            "Ay",
            "Yıl"});
            this.comboBox1.Location = new System.Drawing.Point(267, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yüzde Kaç Arttı ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yüzde Kaç Oldu";
            // 
            // lbl_yuzdeKacArtti
            // 
            this.lbl_yuzdeKacArtti.AutoSize = true;
            this.lbl_yuzdeKacArtti.Location = new System.Drawing.Point(616, 284);
            this.lbl_yuzdeKacArtti.Name = "lbl_yuzdeKacArtti";
            this.lbl_yuzdeKacArtti.Size = new System.Drawing.Size(19, 20);
            this.lbl_yuzdeKacArtti.TabIndex = 11;
            this.lbl_yuzdeKacArtti.Text = "0";
            // 
            // lbl_yuzdeKacOldu
            // 
            this.lbl_yuzdeKacOldu.AutoSize = true;
            this.lbl_yuzdeKacOldu.Location = new System.Drawing.Point(616, 322);
            this.lbl_yuzdeKacOldu.Name = "lbl_yuzdeKacOldu";
            this.lbl_yuzdeKacOldu.Size = new System.Drawing.Size(19, 20);
            this.lbl_yuzdeKacOldu.TabIndex = 12;
            this.lbl_yuzdeKacOldu.Text = "0";
            // 
            // lbl_sonGelenPara
            // 
            this.lbl_sonGelenPara.AutoSize = true;
            this.lbl_sonGelenPara.Location = new System.Drawing.Point(224, 301);
            this.lbl_sonGelenPara.Name = "lbl_sonGelenPara";
            this.lbl_sonGelenPara.Size = new System.Drawing.Size(19, 20);
            this.lbl_sonGelenPara.TabIndex = 14;
            this.lbl_sonGelenPara.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(245, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Parayı Birikireceğim";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Toplam Para :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kaç Katına Çıktı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ne Kadar Arttı :";
            // 
            // lbl_toplamPara
            // 
            this.lbl_toplamPara.AutoSize = true;
            this.lbl_toplamPara.Location = new System.Drawing.Point(224, 348);
            this.lbl_toplamPara.Name = "lbl_toplamPara";
            this.lbl_toplamPara.Size = new System.Drawing.Size(19, 20);
            this.lbl_toplamPara.TabIndex = 21;
            this.lbl_toplamPara.Text = "0";
            // 
            // lbl_kacKatinaCikti
            // 
            this.lbl_kacKatinaCikti.AutoSize = true;
            this.lbl_kacKatinaCikti.Location = new System.Drawing.Point(616, 377);
            this.lbl_kacKatinaCikti.Name = "lbl_kacKatinaCikti";
            this.lbl_kacKatinaCikti.Size = new System.Drawing.Size(19, 20);
            this.lbl_kacKatinaCikti.TabIndex = 20;
            this.lbl_kacKatinaCikti.Text = "0";
            // 
            // lbl_neKadarArtti
            // 
            this.lbl_neKadarArtti.AutoSize = true;
            this.lbl_neKadarArtti.Location = new System.Drawing.Point(224, 387);
            this.lbl_neKadarArtti.Name = "lbl_neKadarArtti";
            this.lbl_neKadarArtti.Size = new System.Drawing.Size(19, 20);
            this.lbl_neKadarArtti.TabIndex = 19;
            this.lbl_neKadarArtti.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Son Gelen Para :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Eklenecek Miktar";
            // 
            // txt_periyodikEklenecekMiktar
            // 
            this.txt_periyodikEklenecekMiktar.Location = new System.Drawing.Point(267, 256);
            this.txt_periyodikEklenecekMiktar.Multiline = true;
            this.txt_periyodikEklenecekMiktar.Name = "txt_periyodikEklenecekMiktar";
            this.txt_periyodikEklenecekMiktar.Size = new System.Drawing.Size(136, 48);
            this.txt_periyodikEklenecekMiktar.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaPlanRengiToolStripMenuItem,
            this.yazıRengiToolStripMenuItem,
            this.labelRengiToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // arkaPlanRengiToolStripMenuItem
            // 
            this.arkaPlanRengiToolStripMenuItem.Name = "arkaPlanRengiToolStripMenuItem";
            this.arkaPlanRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arkaPlanRengiToolStripMenuItem.Text = "Arka Plan Rengi";
            this.arkaPlanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaPlanRengiToolStripMenuItem_Click);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // labelRengiToolStripMenuItem
            // 
            this.labelRengiToolStripMenuItem.Name = "labelRengiToolStripMenuItem";
            this.labelRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labelRengiToolStripMenuItem.Text = "Label Rengi";
            this.labelRengiToolStripMenuItem.Click += new System.EventHandler(this.labelRengiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(678, 432);
            this.Controls.Add(this.txt_periyodikEklenecekMiktar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_toplamPara);
            this.Controls.Add(this.lbl_kacKatinaCikti);
            this.Controls.Add(this.lbl_neKadarArtti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_sonGelenPara);
            this.Controls.Add(this.lbl_yuzdeKacOldu);
            this.Controls.Add(this.lbl_yuzdeKacArtti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_karYuzdesi);
            this.Controls.Add(this.txt_vade);
            this.Controls.Add(this.txt_anaPara);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(16)))), ((int)(((byte)(120)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finansal Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_anaPara;
        private System.Windows.Forms.TextBox txt_vade;
        private System.Windows.Forms.TextBox txt_karYuzdesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_yuzdeKacArtti;
        private System.Windows.Forms.Label lbl_yuzdeKacOldu;
        private System.Windows.Forms.Label lbl_sonGelenPara;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_toplamPara;
        private System.Windows.Forms.Label lbl_kacKatinaCikti;
        private System.Windows.Forms.Label lbl_neKadarArtti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_periyodikEklenecekMiktar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelRengiToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

