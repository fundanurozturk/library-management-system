namespace WindowsFormOdev
{
    partial class kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.icerik = new MetroFramework.Controls.MetroPanel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.appBarClose = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AnaSayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ana = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Teal;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(349, 10);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(411, 25);
            this.metroLabel1.TabIndex = 104;
            this.metroLabel1.Text = "Welcome to our Library Automation Application.";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // icerik
            // 
            this.icerik.HorizontalScrollbarBarColor = true;
            this.icerik.HorizontalScrollbarHighlightOnWheel = false;
            this.icerik.HorizontalScrollbarSize = 12;
            this.icerik.Location = new System.Drawing.Point(229, 44);
            this.icerik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icerik.Name = "icerik";
            this.icerik.Size = new System.Drawing.Size(851, 622);
            this.icerik.TabIndex = 101;
            this.icerik.Theme = MetroFramework.MetroThemeStyle.Light;
            this.icerik.VerticalScrollbarBarColor = true;
            this.icerik.VerticalScrollbarHighlightOnWheel = false;
            this.icerik.VerticalScrollbarSize = 13;
            this.icerik.Paint += new System.Windows.Forms.PaintEventHandler(this.icerik_Paint);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            this.ımageList1.Images.SetKeyName(1, "register.png");
            this.ımageList1.Images.SetKeyName(2, "help.png");
            this.ımageList1.Images.SetKeyName(3, "report.png");
            this.ımageList1.Images.SetKeyName(4, "close.png");
            // 
            // appBarClose
            // 
            this.appBarClose.BackColor = System.Drawing.Color.Teal;
            this.appBarClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.appBarClose.FlatAppearance.BorderSize = 0;
            this.appBarClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appBarClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appBarClose.ForeColor = System.Drawing.Color.White;
            this.appBarClose.ImageIndex = 0;
            this.appBarClose.ImageList = this.ımageList2;
            this.appBarClose.Location = new System.Drawing.Point(1032, 7);
            this.appBarClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appBarClose.Name = "appBarClose";
            this.appBarClose.Size = new System.Drawing.Size(43, 37);
            this.appBarClose.TabIndex = 99;
            this.appBarClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.appBarClose.UseVisualStyleBackColor = false;
            this.appBarClose.Click += new System.EventHandler(this.appBarClose_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "close.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox2.Location = new System.Drawing.Point(1, 190);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 4);
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AnaSayfa.BackColor = System.Drawing.Color.Teal;
            this.AnaSayfa.FlatAppearance.BorderSize = 0;
            this.AnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfa.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSayfa.ForeColor = System.Drawing.Color.White;
            this.AnaSayfa.Image = global::WindowsFormOdev.Properties.Resources._1492126387_home;
            this.AnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.Location = new System.Drawing.Point(3, 199);
            this.AnaSayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.Size = new System.Drawing.Size(227, 47);
            this.AnaSayfa.TabIndex = 98;
            this.AnaSayfa.Text = "        Home";
            this.AnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.UseVisualStyleBackColor = false;
            this.AnaSayfa.Click += new System.EventHandler(this.AnaSayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(8, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "        Menus ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Location = new System.Drawing.Point(229, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(851, 39);
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ana.Image = ((System.Drawing.Image)(resources.GetObject("ana.Image")));
            this.ana.Location = new System.Drawing.Point(3, 7);
            this.ana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(227, 138);
            this.ana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ana.TabIndex = 95;
            this.ana.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 658);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormOdev.Properties.Resources._1492126387_home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 47);
            this.button1.TabIndex = 107;
            this.button1.Text = "        Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 665);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.appBarClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AnaSayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ana);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullanici";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel icerik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button appBarClose;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AnaSayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ana;
        private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
  }
}