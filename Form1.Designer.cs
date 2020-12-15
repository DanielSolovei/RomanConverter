
namespace NumbConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bRomeConvert = new System.Windows.Forms.Button();
            this.bArabkConvert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRomeConvert
            // 
            this.bRomeConvert.BackColor = System.Drawing.SystemColors.Control;
            this.bRomeConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRomeConvert.BackgroundImage")));
            this.bRomeConvert.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRomeConvert.Location = new System.Drawing.Point(318, 146);
            this.bRomeConvert.Name = "bRomeConvert";
            this.bRomeConvert.Size = new System.Drawing.Size(223, 81);
            this.bRomeConvert.TabIndex = 0;
            this.bRomeConvert.Text = "CONVERT TO ROMAN NUMERALS";
            this.bRomeConvert.UseVisualStyleBackColor = false;
            this.bRomeConvert.Click += new System.EventHandler(this.bRomeConvert_Click);
            // 
            // bArabkConvert
            // 
            this.bArabkConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArabkConvert.BackgroundImage")));
            this.bArabkConvert.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArabkConvert.Location = new System.Drawing.Point(318, 255);
            this.bArabkConvert.Name = "bArabkConvert";
            this.bArabkConvert.Size = new System.Drawing.Size(223, 81);
            this.bArabkConvert.TabIndex = 1;
            this.bArabkConvert.Text = "CONVERT TO ARABIC NUMERALS";
            this.bArabkConvert.UseVisualStyleBackColor = true;
            this.bArabkConvert.Click += new System.EventHandler(this.bArabConver_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 49);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SandyBrown;
            this.progressBar1.Location = new System.Drawing.Point(280, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 40);
            this.progressBar1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(577, 205);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 49);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bArabkConvert);
            this.Controls.Add(this.bRomeConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRomeConvert;
        private System.Windows.Forms.Button bArabkConvert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

