namespace Hastane_Otomasyonu
{
    partial class danismanlog
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
            this.dakadi = new System.Windows.Forms.TextBox();
            this.dapasw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dnsmnlogbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dakadi
            // 
            this.dakadi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dakadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakadi.Location = new System.Drawing.Point(202, 193);
            this.dakadi.Name = "dakadi";
            this.dakadi.Size = new System.Drawing.Size(236, 38);
            this.dakadi.TabIndex = 4;
            this.dakadi.TextChanged += new System.EventHandler(this.dakadi_TextChanged);
            // 
            // dapasw
            // 
            this.dapasw.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dapasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dapasw.Location = new System.Drawing.Point(202, 249);
            this.dapasw.Name = "dapasw";
            this.dapasw.Size = new System.Drawing.Size(236, 38);
            this.dapasw.TabIndex = 5;
            this.dapasw.TextChanged += new System.EventHandler(this.dapasw_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "ŞİFRE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dnsmnlogbtn
            // 
            this.dnsmnlogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dnsmnlogbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dnsmnlogbtn.Location = new System.Drawing.Point(202, 328);
            this.dnsmnlogbtn.Name = "dnsmnlogbtn";
            this.dnsmnlogbtn.Size = new System.Drawing.Size(236, 110);
            this.dnsmnlogbtn.TabIndex = 7;
            this.dnsmnlogbtn.Text = "SİSTEME GİRİŞ";
            this.dnsmnlogbtn.UseVisualStyleBackColor = true;
            this.dnsmnlogbtn.Click += new System.EventHandler(this.dktrlogbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hastane_Otomasyonu.Properties.Resources.saglik_bakanligi_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 126);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(202, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // danismanlog
            // 
            this.AcceptButton = this.dnsmnlogbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dnsmnlogbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dapasw);
            this.Controls.Add(this.dakadi);
            this.Controls.Add(this.label1);
            this.Name = "danismanlog";
            this.Text = "danismanlog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dakadi;
        private System.Windows.Forms.TextBox dapasw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dnsmnlogbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}