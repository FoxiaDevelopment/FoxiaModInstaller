using System;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Diagnostics;




namespace Foxia_mod_installer
{
    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        string minecraftModsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
        string minecraftPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions";
        string backupFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods.backup";
        string version = "1.20.4";

        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;


            if (!FabricLoaderInstalled(minecraftPath, version))
            {
                DialogResult FabricLoader0 = MessageBox.Show($"Fabric loader ei ole installitud verstoonile {version} \n Kas soovite selle installida?",
                                                              "Fabic loader not found!",
                                                               MessageBoxButtons.YesNo);
                if (FabricLoader0 == DialogResult.Yes)
                {
                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "https://maven.fabricmc.net/net/fabricmc/fabric-installer/1.0.0/fabric-installer-1.0.0.exe",
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while trying to open the URL: " + ex.Message);
                    }
                }
            }

            Sodium.Visible = false;
            Lithium.Visible = false;
            Starlight.Visible = false;
            Exordium.Visible = false;
            entityCulling.Visible = false;
            ModernFix.Visible = false;
            Krypton.Visible = false;
            Nvidium.Visible = false;
            Nvidium_label.Visible = false;
            FerriteCore.Visible = false;
            ModMenu.Visible = false;
            LazyDFU.Visible = false;
            MandatoryMods.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://foxia.eu",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while trying to open the URL: " + ex.Message);
            }

        }

        void BackupFolder()
        {
            if (Directory.Exists(minecraftModsFolder))
            {
                if (Directory.GetFiles(minecraftModsFolder).Length > 0 || Directory.GetDirectories(minecraftModsFolder).Length > 0)
                {
                    string backupFolderWithSuffix = backupFolder + viisRandom();

                    // Create backup folder if it doesn't exist
                    if (!Directory.Exists(backupFolderWithSuffix))
                    {
                        Directory.CreateDirectory(backupFolderWithSuffix);
                    }

                    // Copy files and directories to backup folder
                    foreach (string file in Directory.GetFiles(minecraftModsFolder))
                    {
                        string destFile = Path.Combine(backupFolderWithSuffix, Path.GetFileName(file));
                        File.Copy(file, destFile, true);
                    }
                    foreach (string dirPath in Directory.GetDirectories(minecraftModsFolder, "*", SearchOption.AllDirectories))
                    {
                        string destDirPath = Path.Combine(backupFolderWithSuffix, dirPath.Substring(minecraftModsFolder.Length + 1));
                        Directory.CreateDirectory(destDirPath);
                        foreach (string file in Directory.GetFiles(dirPath))
                        {
                            string destFile = Path.Combine(destDirPath, Path.GetFileName(file));
                            File.Copy(file, destFile, true);
                        }
                    }

                    // Delete contents of mods folder
                    foreach (string file in Directory.GetFiles(minecraftModsFolder))
                    {
                        try
                        { 
                            File.Delete(file); 
                        }
                        catch (Exception ex) 
                        { 
                            MessageBox.Show($"Palun sulge minecraft enne installeri kasutamist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        
                    }
                    foreach (string dir in Directory.GetDirectories(minecraftModsFolder))
                    {
                        Directory.Delete(dir, true);
                    }

                    MessageBox.Show("Backup created and mods folder cleared.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mods folder is empty.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Minecraft mods folder does not exist.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static bool FabricLoaderInstalled(string minecraftPath, string version)
        {
            try
            {
                string[] fabricLoaderDirectories = Directory.GetDirectories(minecraftPath, $"fabric-loader-*-{version}");

                // Check if there is at least one directory matching the pattern
                return fabricLoaderDirectories.Length > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        static string viisRandom()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string rand5 = new String(stringChars);
            return rand5;
        }

        private void InstallBtn_Click(object sender, EventArgs e)
        {
            bool isChecked = IsCheckboxChecked("SimpleVoiceChat", this);
            bool isChecked2 = IsCheckboxChecked("ReccomendedPMods", this);
            bool isChecked3 = IsCheckboxChecked("MandatoryMods", this);
            bool isChecked4 = IsCheckboxChecked("CreateBackup", this);
            bool isChecked5 = IsCheckboxChecked("Sodium", this);
            bool isChecked6 = IsCheckboxChecked("Lithium", this);
            bool isChecked7 = IsCheckboxChecked("Starlight", this);
            bool isChecked8 = IsCheckboxChecked("Exordium", this);
            bool isChecked9 = IsCheckboxChecked("EntityCulling", this);
            bool isChecked10 = IsCheckboxChecked("ModernFix", this);
            bool isChecked11 = IsCheckboxChecked("Krypton", this);
            bool isChecked12 = IsCheckboxChecked("Nvidium", this);
            bool isChecked13 = IsCheckboxChecked("ModMenu", this);
            bool isChecked14 = IsCheckboxChecked("FerriteCore", this);
            bool isChecked15 = IsCheckboxChecked("LazyDFU", this);

                DialogResult warn = MessageBox.Show("Oled sa kindel et soovid jätkata?", "Foxia Mod Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn == DialogResult.No) { this.Close(); }

                if (isChecked4)
                {
                    BackupFolder();
                }

                if (isChecked)
                {
                    Install("https://cdn.modrinth.com/data/9eGKb6K1/versions/2OsfFUxE/voicechat-fabric-1.20.4-2.5.4.jar", minecraftModsFolder);
                }

                if (isChecked3)
                {
                    Install("https://cdn.modrinth.com/data/P7dR8mSH/versions/Ca6gRk94/fabric-api-0.96.3%2B1.20.4.jar", minecraftModsFolder);
                    Install("https://cdn.modrinth.com/data/9s6osm5g/versions/eBZiZ9NS/cloth-config-13.0.121-fabric.jar", minecraftModsFolder);
                    
                }

                if (isChecked2)
                {
                    if (isChecked5) { Install("https://cdn.modrinth.com/data/AANobbMI/versions/4GyXKCLd/sodium-fabric-0.5.8%2Bmc1.20.4.jar", minecraftModsFolder); }
                    if (isChecked6) { Install("https://cdn.modrinth.com/data/gvQqBUqZ/versions/nMhjKWVE/lithium-fabric-mc1.20.4-0.12.1.jar", minecraftModsFolder); }
                    if (isChecked7) { Install("https://cdn.modrinth.com/data/H8CaAYZC/versions/HZYU0kdg/starlight-1.1.3%2Bfabric.f5dcd1a.jar", minecraftModsFolder); }
                    if (isChecked8) { Install("https://cdn.modrinth.com/data/DynYZEae/versions/WyhKYeMf/exordium-fabric-1.2.1-mc1.20.4.jar", minecraftModsFolder); };
                    if (isChecked9) { Install("https://cdn.modrinth.com/data/NNAgCjsB/versions/HSirwtwV/entityculling-fabric-1.6.3.1-mc1.20.4.jar", minecraftModsFolder); }
                    if (isChecked10) { Install("https://cdn.modrinth.com/data/nmDcB62a/versions/Btq1HFzk/modernfix-fabric-5.13.0%2Bmc1.20.4.jar", minecraftModsFolder); }
                    if (isChecked11) { Install("https://cdn.modrinth.com/data/fQEb0iXm/versions/bRcuOnao/krypton-0.2.6.jar", minecraftModsFolder); }
                }

                if (isChecked5 && isChecked2)
                {
                    Install("https://cdn.modrinth.com/data/PtjYWJkn/versions/M0ndiav7/sodium-extra-0.5.4%2Bmc1.20.4-build.116.jar", minecraftModsFolder);
                    Install("https://cdn.modrinth.com/data/Bh37bMuy/versions/fkLiGoHs/reeses_sodium_options-1.7.2%2Bmc1.20.4-build.102.jar", minecraftModsFolder);

                    if(isChecked12) { Install("https://cdn.modrinth.com/data/SfMw2IZN/versions/J2fuM58R/nvidium-0.2.6-beta.jar", minecraftModsFolder); }
                }

                if (isChecked13) { Install("https://cdn.modrinth.com/data/mOgUt4GM/versions/sjtVVlsA/modmenu-9.0.0.jar", minecraftModsFolder); }
                if (isChecked14) { Install("https://cdn.modrinth.com/data/uXXizFIs/versions/pguEMpy9/ferritecore-6.0.3-fabric.jar", minecraftModsFolder); }
                if (isChecked15) { Install("https://cdn.modrinth.com/data/hvFnDODi/versions/0.1.3/lazydfu-0.1.3.jar", minecraftModsFolder); }

            MessageBox.Show("All mods installed seccessfully \n Now you can launch minecraft.", "Foxia Mod Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool IsCheckboxChecked(string checkboxName, Control container)
        {
            CheckBox? checkBox = container.Controls.Find(checkboxName, true).FirstOrDefault() as CheckBox;

            if (checkBox != null)
            {
                return checkBox.Checked;
            }
            else
            {
                throw new ArgumentException($"Checkbox with name '{checkboxName}' not found in the specified container.");
            }
        }

        static async Task Install(string url, string minecraftModsFolder)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] fileBytes = await client.GetByteArrayAsync(url);
                    string fileName = Path.GetFileName(url);
                    string filePath = Path.Combine(minecraftModsFolder, fileName);
                    await File.WriteAllBytesAsync(filePath, fileBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ReccomendedPMods_CheckStateChanged(object sender, EventArgs e)
        {
            if (IsCheckboxChecked("ReccomendedPMods", this))
            {
                Sodium.Visible = true;
                Lithium.Visible = true;
                Starlight.Visible = true;
                Exordium.Visible = true;
                entityCulling.Visible = true;
                ModernFix.Visible = true;
                Krypton.Visible = true;
                Nvidium.Visible = true;
                Nvidium_label.Visible = true;
                FerriteCore.Visible = true;
                ModMenu.Visible = true;
                LazyDFU.Visible = true;
            }
            else
            {
                Sodium.Visible = false;
                Lithium.Visible = false;
                Starlight.Visible = false;
                Exordium.Visible = false;
                entityCulling.Visible = false;
                ModernFix.Visible = false;
                Krypton.Visible = false;
                Nvidium.Visible = false;
                Nvidium_label.Visible = false;
                FerriteCore.Visible = false;
                ModMenu.Visible = false;
                LazyDFU.Visible = false;
            }
        }
    }

    public class RJButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}


