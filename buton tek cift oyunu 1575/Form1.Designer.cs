namespace buton_tek_cift_oyunu_1575
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayi.Location = new System.Drawing.Point(22, 32);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(50, 21);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "Sayı :";
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.Lime;
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(125, 27);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(75, 23);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "Sayı Üret";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnTek
            // 
            this.btnTek.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTek.Location = new System.Drawing.Point(12, 114);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(75, 23);
            this.btnTek.TabIndex = 2;
            this.btnTek.Text = "Tek Sayı ";
            this.btnTek.UseVisualStyleBackColor = false;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // btnCift
            // 
            this.btnCift.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCift.Location = new System.Drawing.Point(125, 114);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(75, 23);
            this.btnCift.TabIndex = 3;
            this.btnCift.Text = "Çift Sayı";
            this.btnCift.UseVisualStyleBackColor = false;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.Location = new System.Drawing.Point(22, 189);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(57, 21);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "Puan :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(269, 266);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Label lblPuan;
    }
}

