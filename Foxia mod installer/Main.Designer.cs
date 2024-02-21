namespace Foxia_mod_installer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            SimpleVoiceChat = new CheckBox();
            ReccomendedPMods = new CheckBox();
            CreateBackup = new CheckBox();
            pictureBox2 = new PictureBox();
            Sodium = new CheckBox();
            Lithium = new CheckBox();
            Starlight = new CheckBox();
            Exordium = new CheckBox();
            entityCulling = new CheckBox();
            ModernFix = new CheckBox();
            Krypton = new CheckBox();
            InstallBtn = new RJButton();
            CreditLink = new LinkLabel();
            Nvidium = new CheckBox();
            Nvidium_label = new Label();
            ModMenu = new CheckBox();
            FerriteCore = new CheckBox();
            LazyDFU = new CheckBox();
            MandatoryMods = new CheckBox();
            Credits = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            exitButton.Location = new Point(751, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(49, 51);
            exitButton.TabIndex = 0;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 71, 80);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 68);
            label3.Name = "label3";
            label3.Size = new Size(418, 29);
            label3.TabIndex = 7;
            label3.Text = "Welcome to the Foxia mod installer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(767, 34);
            label4.TabIndex = 8;
            label4.Text = "_______________________________________________";
            // 
            // SimpleVoiceChat
            // 
            SimpleVoiceChat.AutoSize = true;
            SimpleVoiceChat.Checked = true;
            SimpleVoiceChat.CheckState = CheckState.Checked;
            SimpleVoiceChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SimpleVoiceChat.ForeColor = Color.White;
            SimpleVoiceChat.Location = new Point(20, 130);
            SimpleVoiceChat.Name = "SimpleVoiceChat";
            SimpleVoiceChat.Size = new Size(199, 25);
            SimpleVoiceChat.TabIndex = 9;
            SimpleVoiceChat.Text = "Install Simple Voice Chat";
            SimpleVoiceChat.UseVisualStyleBackColor = true;
            // 
            // ReccomendedPMods
            // 
            ReccomendedPMods.AutoSize = true;
            ReccomendedPMods.Font = new Font("Segoe UI", 12F);
            ReccomendedPMods.ForeColor = Color.White;
            ReccomendedPMods.Location = new Point(20, 220);
            ReccomendedPMods.Name = "ReccomendedPMods";
            ReccomendedPMods.Size = new Size(302, 25);
            ReccomendedPMods.TabIndex = 10;
            ReccomendedPMods.Text = "Install Reccomended peformance mods";
            ReccomendedPMods.UseVisualStyleBackColor = true;
            ReccomendedPMods.CheckStateChanged += ReccomendedPMods_CheckStateChanged;
            // 
            // CreateBackup
            // 
            CreateBackup.AutoSize = true;
            CreateBackup.Checked = true;
            CreateBackup.CheckState = CheckState.Checked;
            CreateBackup.Font = new Font("Segoe UI", 12F);
            CreateBackup.ForeColor = Color.White;
            CreateBackup.Location = new Point(20, 310);
            CreateBackup.Name = "CreateBackup";
            CreateBackup.Size = new Size(319, 25);
            CreateBackup.TabIndex = 11;
            CreateBackup.Text = "Create a backup of the current mod folder";
            CreateBackup.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(345, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Sodium
            // 
            Sodium.AutoSize = true;
            Sodium.Font = new Font("Segoe UI", 12F);
            Sodium.ForeColor = Color.White;
            Sodium.Location = new Point(420, 130);
            Sodium.Name = "Sodium";
            Sodium.Size = new Size(83, 25);
            Sodium.TabIndex = 13;
            Sodium.Text = "Sodium";
            Sodium.UseVisualStyleBackColor = true;
            // 
            // Lithium
            // 
            Lithium.AutoSize = true;
            Lithium.Font = new Font("Segoe UI", 12F);
            Lithium.ForeColor = Color.White;
            Lithium.Location = new Point(420, 175);
            Lithium.Name = "Lithium";
            Lithium.Size = new Size(82, 25);
            Lithium.TabIndex = 14;
            Lithium.Text = "Lithium";
            Lithium.UseVisualStyleBackColor = true;
            // 
            // Starlight
            // 
            Starlight.AutoSize = true;
            Starlight.Font = new Font("Segoe UI", 12F);
            Starlight.ForeColor = Color.White;
            Starlight.Location = new Point(420, 220);
            Starlight.Name = "Starlight";
            Starlight.Size = new Size(87, 25);
            Starlight.TabIndex = 15;
            Starlight.Text = "Starlight";
            Starlight.UseVisualStyleBackColor = true;
            // 
            // Exordium
            // 
            Exordium.AutoSize = true;
            Exordium.Font = new Font("Segoe UI", 12F);
            Exordium.ForeColor = Color.White;
            Exordium.Location = new Point(420, 265);
            Exordium.Name = "Exordium";
            Exordium.Size = new Size(95, 25);
            Exordium.TabIndex = 16;
            Exordium.Text = "Exordium";
            Exordium.UseVisualStyleBackColor = true;
            // 
            // entityCulling
            // 
            entityCulling.AutoSize = true;
            entityCulling.Font = new Font("Segoe UI", 12F);
            entityCulling.ForeColor = Color.White;
            entityCulling.Location = new Point(420, 310);
            entityCulling.Name = "entityCulling";
            entityCulling.Size = new Size(125, 25);
            entityCulling.TabIndex = 17;
            entityCulling.Text = "Entity Clulling";
            entityCulling.UseVisualStyleBackColor = true;
            // 
            // ModernFix
            // 
            ModernFix.AutoSize = true;
            ModernFix.Font = new Font("Segoe UI", 12F);
            ModernFix.ForeColor = Color.White;
            ModernFix.Location = new Point(420, 355);
            ModernFix.Name = "ModernFix";
            ModernFix.Size = new Size(107, 25);
            ModernFix.TabIndex = 18;
            ModernFix.Text = "Modern Fix";
            ModernFix.UseVisualStyleBackColor = true;
            // 
            // Krypton
            // 
            Krypton.AutoSize = true;
            Krypton.Font = new Font("Segoe UI", 12F);
            Krypton.ForeColor = Color.White;
            Krypton.Location = new Point(418, 400);
            Krypton.Name = "Krypton";
            Krypton.Size = new Size(84, 25);
            Krypton.TabIndex = 19;
            Krypton.Text = "Krypton";
            Krypton.UseVisualStyleBackColor = true;
            // 
            // InstallBtn
            // 
            InstallBtn.BackColor = SystemColors.HotTrack;
            InstallBtn.BackgroundColor = SystemColors.HotTrack;
            InstallBtn.BorderColor = Color.Yellow;
            InstallBtn.BorderRadius = 20;
            InstallBtn.BorderSize = 0;
            InstallBtn.FlatAppearance.BorderSize = 0;
            InstallBtn.FlatStyle = FlatStyle.Flat;
            InstallBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstallBtn.ForeColor = Color.White;
            InstallBtn.Location = new Point(20, 370);
            InstallBtn.Name = "InstallBtn";
            InstallBtn.Size = new Size(170, 40);
            InstallBtn.TabIndex = 22;
            InstallBtn.Text = "Install";
            InstallBtn.TextColor = Color.White;
            InstallBtn.UseVisualStyleBackColor = false;
            InstallBtn.Click += InstallBtn_Click;
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
            CreditLink.TabIndex = 23;
            CreditLink.TabStop = true;
            CreditLink.Text = "© Foxia 2024 All Rights reserved";
            CreditLink.LinkClicked += CreditLink_LinkClicked;
            // 
            // Nvidium
            // 
            Nvidium.AutoSize = true;
            Nvidium.Font = new Font("Segoe UI", 12F);
            Nvidium.ForeColor = Color.White;
            Nvidium.Location = new Point(572, 130);
            Nvidium.Name = "Nvidium";
            Nvidium.Size = new Size(96, 25);
            Nvidium.TabIndex = 24;
            Nvidium.Text = "Nvidium*";
            Nvidium.UseVisualStyleBackColor = true;
            // 
            // Nvidium_label
            // 
            Nvidium_label.AutoSize = true;
            Nvidium_label.ForeColor = Color.White;
            Nvidium_label.Location = new Point(376, 428);
            Nvidium_label.Name = "Nvidium_label";
            Nvidium_label.Size = new Size(403, 15);
            Nvidium_label.TabIndex = 25;
            Nvidium_label.Text = "* Tootab ainult Nvidia graafikakaartidel. See peab olema 16xx gen või uuem";
            // 
            // ModMenu
            // 
            ModMenu.AutoSize = true;
            ModMenu.Font = new Font("Segoe UI", 12F);
            ModMenu.ForeColor = Color.White;
            ModMenu.Location = new Point(572, 175);
            ModMenu.Name = "ModMenu";
            ModMenu.Size = new Size(101, 25);
            ModMenu.TabIndex = 26;
            ModMenu.Text = "ModMenu";
            ModMenu.UseVisualStyleBackColor = true;
            // 
            // FerriteCore
            // 
            FerriteCore.AutoSize = true;
            FerriteCore.Font = new Font("Segoe UI", 12F);
            FerriteCore.ForeColor = Color.White;
            FerriteCore.Location = new Point(572, 220);
            FerriteCore.Name = "FerriteCore";
            FerriteCore.Size = new Size(107, 25);
            FerriteCore.TabIndex = 28;
            FerriteCore.Text = "FerriteCore";
            FerriteCore.UseVisualStyleBackColor = true;
            // 
            // LazyDFU
            // 
            LazyDFU.AutoSize = true;
            LazyDFU.Font = new Font("Segoe UI", 12F);
            LazyDFU.ForeColor = Color.White;
            LazyDFU.Location = new Point(571, 265);
            LazyDFU.Name = "LazyDFU";
            LazyDFU.Size = new Size(90, 25);
            LazyDFU.TabIndex = 29;
            LazyDFU.Text = "LazyDFU";
            LazyDFU.UseVisualStyleBackColor = true;
            // 
            // MandatoryMods
            // 
            MandatoryMods.AutoSize = true;
            MandatoryMods.Checked = true;
            MandatoryMods.CheckState = CheckState.Checked;
            MandatoryMods.Font = new Font("Segoe UI", 12F);
            MandatoryMods.ForeColor = Color.White;
            MandatoryMods.Location = new Point(785, 429);
            MandatoryMods.Name = "MandatoryMods";
            MandatoryMods.Size = new Size(15, 14);
            MandatoryMods.TabIndex = 20;
            MandatoryMods.UseVisualStyleBackColor = true;
            // 
            // Credits
            // 
            Credits.ActiveLinkColor = SystemColors.Highlight;
            Credits.AutoSize = true;
            Credits.LinkBehavior = LinkBehavior.HoverUnderline;
            Credits.LinkColor = Color.LightGray;
            Credits.Location = new Point(237, 426);
            Credits.Name = "Credits";
            Credits.Size = new Size(44, 15);
            Credits.TabIndex = 30;
            Credits.TabStop = true;
            Credits.Text = "Credits";
            Credits.LinkClicked += Credits_LinkClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 65);
            ClientSize = new Size(800, 450);
            Controls.Add(Credits);
            Controls.Add(LazyDFU);
            Controls.Add(FerriteCore);
            Controls.Add(ModMenu);
            Controls.Add(Nvidium_label);
            Controls.Add(Nvidium);
            Controls.Add(CreditLink);
            Controls.Add(InstallBtn);
            Controls.Add(MandatoryMods);
            Controls.Add(Krypton);
            Controls.Add(ModernFix);
            Controls.Add(entityCulling);
            Controls.Add(Exordium);
            Controls.Add(Starlight);
            Controls.Add(Lithium);
            Controls.Add(Sodium);
            Controls.Add(CreateBackup);
            Controls.Add(ReccomendedPMods);
            Controls.Add(SimpleVoiceChat);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Foxia Mod Installer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private CheckBox SimpleVoiceChat;
        private CheckBox ReccomendedPMods;
        private CheckBox CreateBackup;
        private PictureBox pictureBox2;
        private CheckBox Sodium;
        private CheckBox Lithium;
        private CheckBox Starlight;
        private CheckBox Exordium;
        private CheckBox entityCulling;
        private CheckBox ModernFix;
        private CheckBox Krypton;
        private RJButton InstallBtn;
        private LinkLabel CreditLink;
        private CheckBox Nvidium;
        private Label Nvidium_label;
        private CheckBox ModMenu;
        private CheckBox FerriteCore;
        private CheckBox LazyDFU;
        private CheckBox MandatoryMods;
        private LinkLabel Credits;
    }
}
