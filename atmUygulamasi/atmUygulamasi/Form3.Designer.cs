namespace atmUygulamasi
{
    partial class Form3
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
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cek = new System.Windows.Forms.Button();
            this.tbox_yatirilacak = new System.Windows.Forms.TextBox();
            this.lbl_miktar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(363, 60);
            this.lbl_bakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(32, 22);
            this.lbl_bakiye.TabIndex = 20;
            this.lbl_bakiye.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bakiye: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ana Hesap";
            // 
            // btn_cek
            // 
            this.btn_cek.Location = new System.Drawing.Point(184, 253);
            this.btn_cek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(166, 61);
            this.btn_cek.TabIndex = 16;
            this.btn_cek.Text = "Cek";
            this.btn_cek.UseVisualStyleBackColor = true;
            this.btn_cek.Click += new System.EventHandler(this.btn_cek_Click);
            // 
            // tbox_yatirilacak
            // 
            this.tbox_yatirilacak.Location = new System.Drawing.Point(287, 160);
            this.tbox_yatirilacak.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbox_yatirilacak.Name = "tbox_yatirilacak";
            this.tbox_yatirilacak.Size = new System.Drawing.Size(174, 31);
            this.tbox_yatirilacak.TabIndex = 15;
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_miktar.Location = new System.Drawing.Point(81, 163);
            this.lbl_miktar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(172, 22);
            this.lbl_miktar.TabIndex = 14;
            this.lbl_miktar.Text = "Çekilecek miktar:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 360);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.tbox_yatirilacak);
            this.Controls.Add(this.lbl_miktar);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bakiye;
        private Label label2;
        private Label label1;
        private Button btn_cek;
        private TextBox tbox_yatirilacak;
        private Label lbl_miktar;
    }
}