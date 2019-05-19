namespace FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OngDuoi1 = new System.Windows.Forms.PictureBox();
            this.OngTren2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonPlay = new System.Windows.Forms.PictureBox();
            this.Diem = new System.Windows.Forms.Label();
            this.OngTren1 = new System.Windows.Forms.PictureBox();
            this.OngDuoi2 = new System.Windows.Forms.PictureBox();
            this.ConChim = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.HuongDan = new System.Windows.Forms.PictureBox();
            this.PlayFirst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConChim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HuongDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // OngDuoi1
            // 
            this.OngDuoi1.Image = ((System.Drawing.Image)(resources.GetObject("OngDuoi1.Image")));
            this.OngDuoi1.Location = new System.Drawing.Point(194, 353);
            this.OngDuoi1.Name = "OngDuoi1";
            this.OngDuoi1.Size = new System.Drawing.Size(145, 1004);
            this.OngDuoi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OngDuoi1.TabIndex = 1;
            this.OngDuoi1.TabStop = false;
            // 
            // OngTren2
            // 
            this.OngTren2.Image = ((System.Drawing.Image)(resources.GetObject("OngTren2.Image")));
            this.OngTren2.Location = new System.Drawing.Point(582, -664);
            this.OngTren2.Name = "OngTren2";
            this.OngTren2.Size = new System.Drawing.Size(145, 934);
            this.OngTren2.TabIndex = 2;
            this.OngTren2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPlay.BackgroundImage")));
            this.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPlay.Location = new System.Drawing.Point(168, 163);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(54, 50);
            this.ButtonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPlay.TabIndex = 5;
            this.ButtonPlay.TabStop = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click_1);
            // 
            // Diem
            // 
            this.Diem.AutoSize = true;
            this.Diem.BackColor = System.Drawing.Color.Transparent;
            this.Diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diem.Location = new System.Drawing.Point(434, 9);
            this.Diem.Name = "Diem";
            this.Diem.Size = new System.Drawing.Size(0, 42);
            this.Diem.TabIndex = 6;
            // 
            // OngTren1
            // 
            this.OngTren1.BackColor = System.Drawing.SystemColors.Control;
            this.OngTren1.Image = ((System.Drawing.Image)(resources.GetObject("OngTren1.Image")));
            this.OngTren1.Location = new System.Drawing.Point(194, -684);
            this.OngTren1.Name = "OngTren1";
            this.OngTren1.Size = new System.Drawing.Size(145, 934);
            this.OngTren1.TabIndex = 0;
            this.OngTren1.TabStop = false;
            // 
            // OngDuoi2
            // 
            this.OngDuoi2.Image = ((System.Drawing.Image)(resources.GetObject("OngDuoi2.Image")));
            this.OngDuoi2.Location = new System.Drawing.Point(582, 385);
            this.OngDuoi2.Name = "OngDuoi2";
            this.OngDuoi2.Size = new System.Drawing.Size(145, 1004);
            this.OngDuoi2.TabIndex = 3;
            this.OngDuoi2.TabStop = false;
            // 
            // ConChim
            // 
            this.ConChim.BackColor = System.Drawing.Color.Transparent;
            this.ConChim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConChim.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ConChim.Location = new System.Drawing.Point(12, 220);
            this.ConChim.Name = "ConChim";
            this.ConChim.Size = new System.Drawing.Size(65, 54);
            this.ConChim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConChim.TabIndex = 4;
            this.ConChim.TabStop = false;
            this.ConChim.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ButtonPlay);
            this.panel1.Location = new System.Drawing.Point(241, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 251);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 21.75F);
            this.label1.Location = new System.Drawing.Point(201, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // HuongDan
            // 
            this.HuongDan.BackColor = System.Drawing.Color.Transparent;
            this.HuongDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HuongDan.Image = ((System.Drawing.Image)(resources.GetObject("HuongDan.Image")));
            this.HuongDan.Location = new System.Drawing.Point(264, 67);
            this.HuongDan.Name = "HuongDan";
            this.HuongDan.Size = new System.Drawing.Size(335, 243);
            this.HuongDan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HuongDan.TabIndex = 10;
            this.HuongDan.TabStop = false;
            this.HuongDan.UseWaitCursor = true;
            // 
            // PlayFirst
            // 
            this.PlayFirst.BackColor = System.Drawing.Color.Transparent;
            this.PlayFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFirst.Image = ((System.Drawing.Image)(resources.GetObject("PlayFirst.Image")));
            this.PlayFirst.Location = new System.Drawing.Point(400, 341);
            this.PlayFirst.Name = "PlayFirst";
            this.PlayFirst.Size = new System.Drawing.Size(78, 73);
            this.PlayFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayFirst.TabIndex = 11;
            this.PlayFirst.TabStop = false;
            this.PlayFirst.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 495);
            this.Controls.Add(this.PlayFirst);
            this.Controls.Add(this.HuongDan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConChim);
            this.Controls.Add(this.Diem);
            this.Controls.Add(this.OngDuoi1);
            this.Controls.Add(this.OngTren2);
            this.Controls.Add(this.OngDuoi2);
            this.Controls.Add(this.OngTren1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConChim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HuongDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox OngDuoi1;
        private System.Windows.Forms.PictureBox OngTren2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ButtonPlay;
        private System.Windows.Forms.Label Diem;
        private System.Windows.Forms.PictureBox OngTren1;
        private System.Windows.Forms.PictureBox OngDuoi2;
        private System.Windows.Forms.PictureBox ConChim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox HuongDan;
        private System.Windows.Forms.PictureBox PlayFirst;
    }
}

