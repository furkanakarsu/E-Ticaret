namespace OOP_Hamburgerci
{
    partial class RaporForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSiparisSayisi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkstraGelir = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMenuAdet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Siparişler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 420);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(297, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(97, 44);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(13, 13);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSiparisSayisi);
            this.groupBox2.Location = new System.Drawing.Point(297, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // lblSiparisSayisi
            // 
            this.lblSiparisSayisi.AutoSize = true;
            this.lblSiparisSayisi.Location = new System.Drawing.Point(97, 44);
            this.lblSiparisSayisi.Name = "lblSiparisSayisi";
            this.lblSiparisSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblSiparisSayisi.TabIndex = 0;
            this.lblSiparisSayisi.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkstraGelir);
            this.groupBox3.Location = new System.Drawing.Point(297, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra Malzeme Gelir";
            // 
            // lblEkstraGelir
            // 
            this.lblEkstraGelir.AutoSize = true;
            this.lblEkstraGelir.Location = new System.Drawing.Point(97, 44);
            this.lblEkstraGelir.Name = "lblEkstraGelir";
            this.lblEkstraGelir.Size = new System.Drawing.Size(13, 13);
            this.lblEkstraGelir.TabIndex = 0;
            this.lblEkstraGelir.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMenuAdet);
            this.groupBox4.Location = new System.Drawing.Point(297, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Menu Adet";
            // 
            // lblMenuAdet
            // 
            this.lblMenuAdet.AutoSize = true;
            this.lblMenuAdet.Location = new System.Drawing.Point(97, 44);
            this.lblMenuAdet.Name = "lblMenuAdet";
            this.lblMenuAdet.Size = new System.Drawing.Size(13, 13);
            this.lblMenuAdet.TabIndex = 0;
            this.lblMenuAdet.Text = "0";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 487);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "RaporForm";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSiparisSayisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEkstraGelir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMenuAdet;
    }
}