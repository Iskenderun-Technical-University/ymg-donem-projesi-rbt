
namespace Şantiye_otomasyon_proje
{
    partial class girişform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girişform));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkullanıcıad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.buttongiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBoxkullanıcıad
            // 
            this.textBoxkullanıcıad.Location = new System.Drawing.Point(340, 69);
            this.textBoxkullanıcıad.Name = "textBoxkullanıcıad";
            this.textBoxkullanıcıad.Size = new System.Drawing.Size(153, 30);
            this.textBoxkullanıcıad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şirket Personel Takip Giriş Paneli";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(340, 111);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(153, 30);
            this.textBoxsifre.TabIndex = 4;
            this.textBoxsifre.UseSystemPasswordChar = true;
            // 
            // buttongiris
            // 
            this.buttongiris.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttongiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttongiris.BackgroundImage")));
            this.buttongiris.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongiris.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttongiris.Location = new System.Drawing.Point(340, 172);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(153, 38);
            this.buttongiris.TabIndex = 5;
            this.buttongiris.Text = "Giriş";
            this.buttongiris.UseVisualStyleBackColor = false;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxsifre);
            this.groupBox1.Controls.Add(this.buttongiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxkullanıcıad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 253);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // girişform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "girişform";
            this.Text = "girişform";
            this.Load += new System.EventHandler(this.girişform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkullanıcıad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Button buttongiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}