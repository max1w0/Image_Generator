using System.Windows.Controls;
using System.Xml.Linq;
using WindowsInput.Events;
using static System.Net.Mime.MediaTypeNames;

namespace ImageGenerator
{
    partial class GeneratorFrm
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorFrm));
            Head = new System.Windows.Forms.Panel();
            CloseButton = new System.Windows.Forms.Label();
            ButtonsGrid = new TableLayoutPanel();
            ButtonsStoragePanel = new FlowLayoutPanel();
            buttonOneByOneFirst = new System.Windows.Forms.Button();
            buttonOneByOneSecond = new System.Windows.Forms.Button();
            buttonOneByTwo = new System.Windows.Forms.Button();
            buttonOneByThree = new System.Windows.Forms.Button();
            PictureBox = new PictureBox();
            state = new System.Windows.Forms.RichTextBox();
            GenerateButton = new System.Windows.Forms.Button();
            Head.SuspendLayout();
            ButtonsStoragePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // Head
            // 
            Head.BackColor = Color.FromArgb(0, 202, 116);
            Head.Controls.Add(CloseButton);
            Head.Location = new Point(0, 0);
            Head.Name = "Head";
            Head.Size = new Size(989, 38);
            Head.TabIndex = 0;
            Head.MouseDown += GeneratorFrm_MouseDown;
            Head.MouseMove += GeneratorFrm_MouseMove;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(956, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // ButtonsGrid
            // 
            ButtonsGrid.BackColor = Color.FromArgb(0, 202, 116);
            ButtonsGrid.ColumnCount = 4;
            ButtonsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsGrid.Location = new Point(11, 171);
            ButtonsGrid.Name = "ButtonsGrid";
            ButtonsGrid.RowCount = 4;
            ButtonsGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonsGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonsGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonsGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonsGrid.Size = new Size(480, 480);
            ButtonsGrid.TabIndex = 4;
            // 
            // ButtonsStoragePanel
            // 
            ButtonsStoragePanel.Controls.Add(buttonOneByOneFirst);
            ButtonsStoragePanel.Controls.Add(buttonOneByOneSecond);
            ButtonsStoragePanel.Controls.Add(buttonOneByTwo);
            ButtonsStoragePanel.Controls.Add(buttonOneByThree);
            ButtonsStoragePanel.Location = new Point(8, 45);
            ButtonsStoragePanel.Name = "ButtonsStoragePanel";
            ButtonsStoragePanel.Size = new Size(491, 123);
            ButtonsStoragePanel.TabIndex = 4;
            // 
            // buttonOneByOneFirst
            // 
            buttonOneByOneFirst.BackColor = Color.FromArgb(0, 206, 230);
            buttonOneByOneFirst.Cursor = Cursors.Hand;
            buttonOneByOneFirst.Font = new System.Drawing.Font("XO Oriel", 9F, FontStyle.Bold);
            buttonOneByOneFirst.ForeColor = Color.White;
            buttonOneByOneFirst.Location = new Point(3, 3);
            buttonOneByOneFirst.Name = "buttonOneByOneFirst";
            buttonOneByOneFirst.Size = new Size(115, 115);
            buttonOneByOneFirst.TabIndex = 0;
            buttonOneByOneFirst.Text = "1 x 1";
            buttonOneByOneFirst.UseVisualStyleBackColor = false;
            buttonOneByOneFirst.Click += OnButtonClick;
            buttonOneByOneFirst.MouseDown += OnButtonDown;
            // 
            // buttonOneByOneSecond
            // 
            buttonOneByOneSecond.BackColor = Color.FromArgb(255, 147, 112);
            buttonOneByOneSecond.Cursor = Cursors.Hand;
            buttonOneByOneSecond.Font = new System.Drawing.Font("XO Oriel", 9F, FontStyle.Bold);
            buttonOneByOneSecond.ForeColor = Color.White;
            buttonOneByOneSecond.Location = new Point(124, 3);
            buttonOneByOneSecond.Name = "buttonOneByOneSecond";
            buttonOneByOneSecond.Size = new Size(115, 115);
            buttonOneByOneSecond.TabIndex = 1;
            buttonOneByOneSecond.Text = "1 x 1";
            buttonOneByOneSecond.UseVisualStyleBackColor = false;
            buttonOneByOneSecond.Click += OnButtonClick;
            buttonOneByOneSecond.MouseDown += OnButtonDown;
            // 
            // buttonOneByTwo
            // 
            buttonOneByTwo.BackColor = Color.FromArgb(0, 206, 230);
            buttonOneByTwo.Cursor = Cursors.Hand;
            buttonOneByTwo.Font = new System.Drawing.Font("XO Oriel", 9F, FontStyle.Bold);
            buttonOneByTwo.ForeColor = Color.White;
            buttonOneByTwo.Location = new Point(245, 3);
            buttonOneByTwo.Name = "buttonOneByTwo";
            buttonOneByTwo.Size = new Size(115, 115);
            buttonOneByTwo.TabIndex = 2;
            buttonOneByTwo.Text = "1 x 2";
            buttonOneByTwo.UseVisualStyleBackColor = false;
            buttonOneByTwo.Click += OnButtonClick;
            buttonOneByTwo.MouseDown += OnButtonDown;
            // 
            // buttonOneByThree
            // 
            buttonOneByThree.BackColor = Color.FromArgb(255, 147, 112);
            buttonOneByThree.Cursor = Cursors.Hand;
            buttonOneByThree.Font = new System.Drawing.Font("XO Oriel", 9F, FontStyle.Bold);
            buttonOneByThree.ForeColor = Color.White;
            buttonOneByThree.Location = new Point(366, 3);
            buttonOneByThree.Name = "buttonOneByThree";
            buttonOneByThree.Size = new Size(115, 115);
            buttonOneByThree.TabIndex = 3;
            buttonOneByThree.Text = "1 x 3";
            buttonOneByThree.UseVisualStyleBackColor = false;
            buttonOneByThree.Click += OnButtonClick;
            buttonOneByThree.MouseDown += OnButtonDown;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.Black;
            PictureBox.BackgroundImageLayout = ImageLayout.None;
            PictureBox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox.Location = new Point(499, 48);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(480, 480);
            PictureBox.TabIndex = 5;
            PictureBox.TabStop = false;
            // 
            // state
            // 
            state.BackColor = Color.LightGray;
            state.BorderStyle = BorderStyle.None;
            state.Location = new Point(499, 589);
            state.Name = "state";
            state.ReadOnly = true;
            state.ScrollBars = RichTextBoxScrollBars.Vertical;
            state.Size = new Size(479, 62);
            state.TabIndex = 6;
            state.Text = "";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(0, 202, 116);
            GenerateButton.Cursor = Cursors.Hand;
            GenerateButton.FlatStyle = FlatStyle.Popup;
            GenerateButton.Font = new System.Drawing.Font("XO Oriel", 12F, FontStyle.Bold);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(499, 535);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(479, 45);
            GenerateButton.TabIndex = 7;
            GenerateButton.Text = "G E N E R A T E";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButtonClick;
            GenerateButton.MouseEnter += GenerateButton_MouseEnter;
            GenerateButton.MouseLeave += GenerateButton_MouseLeave;
            // 
            // GeneratorFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(989, 663);
            Controls.Add(state);
            Controls.Add(GenerateButton);
            Controls.Add(PictureBox);
            Controls.Add(ButtonsStoragePanel);
            Controls.Add(ButtonsGrid);
            Controls.Add(Head);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GeneratorFrm";
            Text = "GeneratorForm";
            MouseDown += GeneratorFrm_MouseDown;
            MouseMove += GeneratorFrm_MouseMove;
            Head.ResumeLayout(false);
            Head.PerformLayout();
            ButtonsStoragePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Head;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsGrid;
        private System.Windows.Forms.FlowLayoutPanel ButtonsStoragePanel;
        private System.Windows.Forms.Button buttonOneByOneFirst;
        private System.Windows.Forms.Button buttonOneByOneSecond;
        private System.Windows.Forms.Button buttonOneByTwo;
        private System.Windows.Forms.Button buttonOneByThree;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.RichTextBox state;
        private System.Windows.Forms.Button GenerateButton;
    }
}