namespace Foxia_mod_installer
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            TopBar = new Panel();
            button1 = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Credits_title = new Label();
            label4 = new Label();
            CreditLink = new LinkLabel();
            CreditLabel1 = new Label();
            label2 = new Label();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.FromArgb(58, 71, 80);
            TopBar.Controls.Add(button1);
            TopBar.Controls.Add(exitButton);
            TopBar.Controls.Add(pictureBox1);
            TopBar.Controls.Add(label1);
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(800, 51);
            TopBar.TabIndex = 5;
            TopBar.MouseDown += TopBar_MouseDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(751, 0);
            button1.Name = "button1";
            button1.Size = new Size(49, 51);
            button1.TabIndex = 25;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.BackColor = Color.Transparent;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(1351, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(49, 51);
            exitButton.TabIndex = 0;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Foxia_11;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 11);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 3;
            label1.Text = "Foxia Mod Installer";
            // 
            // Credits_title
            // 
            Credits_title.AutoSize = true;
            Credits_title.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Credits_title.ForeColor = Color.White;
            Credits_title.Location = new Point(27, 68);
            Credits_title.Name = "Credits_title";
            Credits_title.Size = new Size(95, 29);
            Credits_title.TabIndex = 8;
            Credits_title.Text = "Credits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(767, 34);
            label4.TabIndex = 9;
            label4.Text = "_______________________________________________";
            // 
            // CreditLink
            // 
            CreditLink.ActiveLinkColor = SystemColors.Highlight;
            CreditLink.AutoSize = true;
            CreditLink.LinkBehavior = LinkBehavior.HoverUnderline;
            CreditLink.LinkColor = Color.LightGray;
            CreditLink.Location = new Point(12, 426);
            CreditLink.Name = "CreditLink";
            CreditLink.Size = new Size(176, 15);
            CreditLink.TabIndex = 24;
            CreditLink.TabStop = true;
            CreditLink.Text = "© Foxia 2024 All Rights reserved";
            CreditLink.LinkClicked += CreditLink_LinkClicked;
            // 
            // CreditLabel1
            // 
            CreditLabel1.AutoSize = true;
            CreditLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CreditLabel1.ForeColor = Color.White;
            CreditLabel1.Location = new Point(27, 131);
            CreditLabel1.Name = "CreditLabel1";
            CreditLabel1.Size = new Size(147, 21);
            CreditLabel1.TabIndex = 25;
            CreditLabel1.Text = "Made by pargivaht";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 178);
            label2.Name = "label2";
            label2.Size = new Size(195, 21);
            label2.TabIndex = 26;
            label2.Text = "Beta testing by Acemavie";
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 65);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(CreditLabel1);
            Controls.Add(CreditLink);
            Controls.Add(Credits_title);
            Controls.Add(label4);
            Controls.Add(TopBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Credits";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopBar;
        private Button exitButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Credits_title;
        private Label label4;
        private LinkLabel CreditLink;
        private Button button1;
        private Label CreditLabel1;
        private Label label2;
    }
}