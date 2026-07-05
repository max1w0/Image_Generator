using System.Resources;

namespace ImageGenerator
{
    partial class WelcomeFrm
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
        ///  Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeFrm));
            Head = new Panel();
            CloseButton = new Label();
            StartButton = new Button();
            photo1 = new PictureBox();
            photo2 = new PictureBox();
            textBox1 = new TextBox();
            Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photo2).BeginInit();
            SuspendLayout();
            // 
            // Head
            // 
            Head.BackColor = Color.FromArgb(0, 202, 116);
            Head.Controls.Add(CloseButton);
            Head.Location = new Point(0, 0);
            Head.Name = "Head";
            Head.Size = new Size(674, 39);
            Head.TabIndex = 0;
            Head.MouseDown += WelcomeForm_MouseDown;
            Head.MouseMove += WelcomeForm_MouseMove;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(640, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(0, 202, 116);
            StartButton.Cursor = Cursors.Hand;
            StartButton.FlatStyle = FlatStyle.Popup;
            StartButton.Font = new Font("XO Oriel", 12F, FontStyle.Bold);
            StartButton.ForeColor = Color.White;
            StartButton.Location = new Point(165, 224);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(161, 44);
            StartButton.TabIndex = 1;
            StartButton.Text = "S T A R T";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            StartButton.MouseEnter += StartButton_MouseEnter;
            StartButton.MouseLeave += StartButton_MouseLeave;
            // 
            // photo1
            // 
            photo1.Image = (Image)resources.GetObject("photo1.Image");
            photo1.Location = new Point(561, 45);
            photo1.Name = "photo1";
            photo1.Size = new Size(80, 74);
            photo1.TabIndex = 2;
            photo1.TabStop = false;
            // 
            // photo2
            // 
            photo2.Image = (Image)resources.GetObject("photo2.Image");
            photo2.Location = new Point(448, 181);
            photo2.Name = "photo2";
            photo2.Size = new Size(142, 130);
            photo2.TabIndex = 3;
            photo2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("XO Oriel", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(31, 82);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(536, 93);
            textBox1.TabIndex = 4;
            textBox1.Text = "Welcome to the image generation app!";
            // 
            // WelcomeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(672, 337);
            Controls.Add(textBox1);
            Controls.Add(photo2);
            Controls.Add(photo1);
            Controls.Add(StartButton);
            Controls.Add(Head);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeFrm";
            Text = "Form1";
            MouseDown += WelcomeForm_MouseDown;
            MouseMove += WelcomeForm_MouseMove;
            Head.ResumeLayout(false);
            Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)photo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel Head;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox photo1;
        private System.Windows.Forms.PictureBox photo2;
        private System.Windows.Forms.TextBox textBox1;
    }
}