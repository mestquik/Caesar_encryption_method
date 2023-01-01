namespace SezarSifreleme
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
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.txtSifreliVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSifreyiCoz = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veri:";
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(152, 43);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(274, 26);
            this.txtVeri.TabIndex = 1;
            this.txtVeri.TextChanged += new System.EventHandler(this.txtVeri_TextChanged);
            // 
            // txtSifreliVeri
            // 
            this.txtSifreliVeri.Location = new System.Drawing.Point(152, 75);
            this.txtSifreliVeri.Name = "txtSifreliVeri";
            this.txtSifreliVeri.Size = new System.Drawing.Size(274, 26);
            this.txtSifreliVeri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Veri:";
            // 
            // btnSifreyiCoz
            // 
            this.btnSifreyiCoz.Location = new System.Drawing.Point(299, 107);
            this.btnSifreyiCoz.Name = "btnSifreyiCoz";
            this.btnSifreyiCoz.Size = new System.Drawing.Size(127, 39);
            this.btnSifreyiCoz.TabIndex = 5;
            this.btnSifreyiCoz.Text = "Şifreyi Çöz";
            this.btnSifreyiCoz.UseVisualStyleBackColor = true;
            this.btnSifreyiCoz.Click += new System.EventHandler(this.btnSifreyiCoz_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(152, 107);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(127, 39);
            this.btnSifrele.TabIndex = 6;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 278);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.btnSifreyiCoz);
            this.Controls.Add(this.txtSifreliVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.TextBox txtSifreliVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSifreyiCoz;
        private System.Windows.Forms.Button btnSifrele;
    }
}

