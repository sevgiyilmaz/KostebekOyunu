namespace KostebekOyunu
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
            this.components = new System.ComponentModel.Container();
            this.btnBaslaDurdur = new System.Windows.Forms.Button();
            this.pnlTarla = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaslaDurdur
            // 
            this.btnBaslaDurdur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaslaDurdur.Location = new System.Drawing.Point(77, 6);
            this.btnBaslaDurdur.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaslaDurdur.Name = "btnBaslaDurdur";
            this.btnBaslaDurdur.Size = new System.Drawing.Size(134, 47);
            this.btnBaslaDurdur.TabIndex = 7;
            this.btnBaslaDurdur.Text = "Basla";
            this.btnBaslaDurdur.UseVisualStyleBackColor = false;
            this.btnBaslaDurdur.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlTarla
            // 
            this.pnlTarla.Location = new System.Drawing.Point(7, 61);
            this.pnlTarla.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTarla.Name = "pnlTarla";
            this.pnlTarla.Size = new System.Drawing.Size(560, 565);
            this.pnlTarla.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPuan.Location = new System.Drawing.Point(355, 8);
            this.lblPuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(141, 45);
            this.lblPuan.TabIndex = 8;
            this.lblPuan.Text = "PUAN=0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 631);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnBaslaDurdur);
            this.Controls.Add(this.pnlTarla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaslaDurdur;
        private System.Windows.Forms.Panel pnlTarla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPuan;
    }
}

