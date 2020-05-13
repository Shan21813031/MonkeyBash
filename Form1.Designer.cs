namespace Monkey
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
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Coordinates = new System.Windows.Forms.Label();
            this.HitsLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.monkey2 = new System.Windows.Forms.PictureBox();
            this.monkey3 = new System.Windows.Forms.PictureBox();
            this.monkey4 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPicture
            // 
            this.pbxPicture.AccessibleDescription = "";
            this.pbxPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxPicture.ErrorImage")));
            this.pbxPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbxPicture.Image")));
            this.pbxPicture.Location = new System.Drawing.Point(34, 15);
            this.pbxPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(51, 70);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture.TabIndex = 0;
            this.pbxPicture.TabStop = false;
            this.pbxPicture.Click += new System.EventHandler(this.pbxPicture_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 322);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(143, 322);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MessageBox.Location = new System.Drawing.Point(111, 16);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(0, 25);
            this.MessageBox.TabIndex = 6;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.monkey4);
            this.GamePanel.Controls.Add(this.monkey3);
            this.GamePanel.Controls.Add(this.monkey2);
            this.GamePanel.Controls.Add(this.pbxPicture);
            this.GamePanel.Controls.Add(this.MessageBox);
            this.GamePanel.Location = new System.Drawing.Point(9, 6);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(401, 305);
            this.GamePanel.TabIndex = 7;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            this.GamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseClick);
            this.GamePanel.MouseHover += new System.EventHandler(this.GamePanel_MouseHover);
            // 
            // Coordinates
            // 
            this.Coordinates.AutoSize = true;
            this.Coordinates.Location = new System.Drawing.Point(393, 90);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(0, 17);
            this.Coordinates.TabIndex = 8;
            // 
            // HitsLabel
            // 
            this.HitsLabel.AutoSize = true;
            this.HitsLabel.Location = new System.Drawing.Point(379, 328);
            this.HitsLabel.Name = "HitsLabel";
            this.HitsLabel.Size = new System.Drawing.Size(0, 17);
            this.HitsLabel.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // monkey2
            // 
            this.monkey2.Image = ((System.Drawing.Image)(resources.GetObject("monkey2.Image")));
            this.monkey2.Location = new System.Drawing.Point(105, 15);
            this.monkey2.Name = "monkey2";
            this.monkey2.Size = new System.Drawing.Size(51, 70);
            this.monkey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkey2.TabIndex = 7;
            this.monkey2.TabStop = false;
            this.monkey2.Click += new System.EventHandler(this.monkey2_Click);
            // 
            // monkey3
            // 
            this.monkey3.Image = ((System.Drawing.Image)(resources.GetObject("monkey3.Image")));
            this.monkey3.Location = new System.Drawing.Point(174, 15);
            this.monkey3.Name = "monkey3";
            this.monkey3.Size = new System.Drawing.Size(51, 70);
            this.monkey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkey3.TabIndex = 8;
            this.monkey3.TabStop = false;
            this.monkey3.Click += new System.EventHandler(this.monkey3_Click);
            // 
            // monkey4
            // 
            this.monkey4.Image = ((System.Drawing.Image)(resources.GetObject("monkey4.Image")));
            this.monkey4.Location = new System.Drawing.Point(245, 15);
            this.monkey4.Name = "monkey4";
            this.monkey4.Size = new System.Drawing.Size(51, 70);
            this.monkey4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkey4.TabIndex = 9;
            this.monkey4.TabStop = false;
            this.monkey4.Click += new System.EventHandler(this.monkey4_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 364);
            this.Controls.Add(this.HitsLabel);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Bash: Detecting Mouse Clicks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MessageBox;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label Coordinates;
        private System.Windows.Forms.Label HitsLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox monkey4;
        private System.Windows.Forms.PictureBox monkey3;
        private System.Windows.Forms.PictureBox monkey2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

