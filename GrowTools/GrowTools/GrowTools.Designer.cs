
namespace GrowTools
{
    partial class GrowTools
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
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnHome = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdvancedTools = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHackTools = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnStartup = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnMainTools = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAutoRestart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbAutoRestart = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStartServer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbStartIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStartMaintenance = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbMaintenance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbAutoPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStartAutoSetup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbAutoIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCreateHosts = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbHostsIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMainTools.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 16;
            this.Elipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnHome;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.pictureBox1);
            this.pnHome.Controls.Add(this.btnAdvancedTools);
            this.pnHome.Controls.Add(this.label2);
            this.pnHome.Controls.Add(this.btnHackTools);
            this.pnHome.Controls.Add(this.btnStartup);
            this.pnHome.Controls.Add(this.label1);
            this.pnHome.Location = new System.Drawing.Point(-1, -1);
            this.pnHome.Name = "pnHome";
            this.pnHome.ShadowDecoration.Parent = this.pnHome;
            this.pnHome.Size = new System.Drawing.Size(816, 478);
            this.pnHome.TabIndex = 7;
            this.pnHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHostNMaint_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GrowTools.Properties.Resources.Growtopia_logo_17_352048;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdvancedTools
            // 
            this.btnAdvancedTools.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvancedTools.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAdvancedTools.BorderRadius = 9;
            this.btnAdvancedTools.BorderThickness = 1;
            this.btnAdvancedTools.CheckedState.Parent = this.btnAdvancedTools;
            this.btnAdvancedTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvancedTools.CustomImages.Parent = this.btnAdvancedTools;
            this.btnAdvancedTools.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdvancedTools.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdvancedTools.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdvancedTools.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdvancedTools.DisabledState.Parent = this.btnAdvancedTools;
            this.btnAdvancedTools.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAdvancedTools.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdvancedTools.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedTools.ForeColor = System.Drawing.Color.White;
            this.btnAdvancedTools.HoverState.Parent = this.btnAdvancedTools;
            this.btnAdvancedTools.Image = global::GrowTools.Properties.Resources.Devils;
            this.btnAdvancedTools.ImageSize = new System.Drawing.Size(75, 60);
            this.btnAdvancedTools.Location = new System.Drawing.Point(19, 137);
            this.btnAdvancedTools.Name = "btnAdvancedTools";
            this.btnAdvancedTools.ShadowDecoration.Parent = this.btnAdvancedTools;
            this.btnAdvancedTools.Size = new System.Drawing.Size(250, 246);
            this.btnAdvancedTools.TabIndex = 2;
            this.btnAdvancedTools.Text = "Advanced Tools";
            this.btnAdvancedTools.Click += new System.EventHandler(this.btnAdvancedTools_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "https://github.com/Pronner/GrowTools";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnHackTools
            // 
            this.btnHackTools.BackColor = System.Drawing.Color.Transparent;
            this.btnHackTools.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnHackTools.BorderRadius = 9;
            this.btnHackTools.BorderThickness = 1;
            this.btnHackTools.CheckedState.Parent = this.btnHackTools;
            this.btnHackTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHackTools.CustomImages.Parent = this.btnHackTools;
            this.btnHackTools.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHackTools.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHackTools.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHackTools.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHackTools.DisabledState.Parent = this.btnHackTools;
            this.btnHackTools.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnHackTools.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHackTools.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHackTools.ForeColor = System.Drawing.Color.White;
            this.btnHackTools.HoverState.Parent = this.btnHackTools;
            this.btnHackTools.Image = global::GrowTools.Properties.Resources.Worldlock;
            this.btnHackTools.ImageSize = new System.Drawing.Size(60, 60);
            this.btnHackTools.Location = new System.Drawing.Point(531, 137);
            this.btnHackTools.Name = "btnHackTools";
            this.btnHackTools.ShadowDecoration.Parent = this.btnHackTools;
            this.btnHackTools.Size = new System.Drawing.Size(250, 246);
            this.btnHackTools.TabIndex = 5;
            this.btnHackTools.Text = "Cheat Tools";
            this.btnHackTools.Click += new System.EventHandler(this.btnHackTools_Click);
            // 
            // btnStartup
            // 
            this.btnStartup.BackColor = System.Drawing.Color.Transparent;
            this.btnStartup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStartup.BorderRadius = 9;
            this.btnStartup.BorderThickness = 1;
            this.btnStartup.CheckedState.Parent = this.btnStartup;
            this.btnStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartup.CustomImages.Parent = this.btnStartup;
            this.btnStartup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartup.DisabledState.Parent = this.btnStartup;
            this.btnStartup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStartup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnStartup.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartup.ForeColor = System.Drawing.Color.White;
            this.btnStartup.HoverState.Parent = this.btnStartup;
            this.btnStartup.Image = global::GrowTools.Properties.Resources.Growtopia_logo_17_352048;
            this.btnStartup.ImageSize = new System.Drawing.Size(120, 60);
            this.btnStartup.Location = new System.Drawing.Point(275, 137);
            this.btnStartup.Name = "btnStartup";
            this.btnStartup.ShadowDecoration.Parent = this.btnStartup;
            this.btnStartup.Size = new System.Drawing.Size(250, 246);
            this.btnStartup.TabIndex = 3;
            this.btnStartup.Text = "Startup Tools";
            this.btnStartup.Click += new System.EventHandler(this.btnStartup_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(769, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // pnMainTools
            // 
            this.pnMainTools.AutoScroll = true;
            this.pnMainTools.Controls.Add(this.guna2Panel5);
            this.pnMainTools.Controls.Add(this.guna2Panel4);
            this.pnMainTools.Controls.Add(this.guna2Panel3);
            this.pnMainTools.Controls.Add(this.guna2Panel2);
            this.pnMainTools.Controls.Add(this.guna2Panel1);
            this.pnMainTools.Controls.Add(this.label3);
            this.pnMainTools.Controls.Add(this.pictureBox2);
            this.pnMainTools.Location = new System.Drawing.Point(-1, -1);
            this.pnMainTools.Name = "pnMainTools";
            this.pnMainTools.ShadowDecoration.Parent = this.pnMainTools;
            this.pnMainTools.Size = new System.Drawing.Size(816, 478);
            this.pnMainTools.TabIndex = 7;
            this.pnMainTools.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMainTools_Paint);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel5.BorderRadius = 9;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.btnAutoRestart);
            this.guna2Panel5.Controls.Add(this.tbAutoRestart);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel5.Location = new System.Drawing.Point(649, 137);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(303, 196);
            this.guna2Panel5.TabIndex = 6;
            // 
            // btnAutoRestart
            // 
            this.btnAutoRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoRestart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAutoRestart.BorderRadius = 10;
            this.btnAutoRestart.BorderThickness = 1;
            this.btnAutoRestart.CheckedState.Parent = this.btnAutoRestart;
            this.btnAutoRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoRestart.CustomImages.Parent = this.btnAutoRestart;
            this.btnAutoRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAutoRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAutoRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAutoRestart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAutoRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAutoRestart.DisabledState.Parent = this.btnAutoRestart;
            this.btnAutoRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAutoRestart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAutoRestart.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoRestart.ForeColor = System.Drawing.Color.White;
            this.btnAutoRestart.HoverState.Parent = this.btnAutoRestart;
            this.btnAutoRestart.Location = new System.Drawing.Point(111, 132);
            this.btnAutoRestart.Name = "btnAutoRestart";
            this.btnAutoRestart.ShadowDecoration.Parent = this.btnAutoRestart;
            this.btnAutoRestart.Size = new System.Drawing.Size(180, 45);
            this.btnAutoRestart.TabIndex = 4;
            this.btnAutoRestart.Text = "Enable";
            this.btnAutoRestart.Click += new System.EventHandler(this.btnAutoRestart_Click);
            // 
            // tbAutoRestart
            // 
            this.tbAutoRestart.Animated = true;
            this.tbAutoRestart.BackColor = System.Drawing.Color.Transparent;
            this.tbAutoRestart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoRestart.BorderRadius = 9;
            this.tbAutoRestart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAutoRestart.DefaultText = "";
            this.tbAutoRestart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAutoRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAutoRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoRestart.DisabledState.Parent = this.tbAutoRestart;
            this.tbAutoRestart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoRestart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoRestart.FocusedState.Parent = this.tbAutoRestart;
            this.tbAutoRestart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAutoRestart.ForeColor = System.Drawing.Color.White;
            this.tbAutoRestart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoRestart.HoverState.Parent = this.tbAutoRestart;
            this.tbAutoRestart.Location = new System.Drawing.Point(9, 38);
            this.tbAutoRestart.Name = "tbAutoRestart";
            this.tbAutoRestart.PasswordChar = '\0';
            this.tbAutoRestart.PlaceholderText = "Server executable name here.";
            this.tbAutoRestart.SelectedText = "";
            this.tbAutoRestart.ShadowDecoration.Parent = this.tbAutoRestart;
            this.tbAutoRestart.Size = new System.Drawing.Size(282, 88);
            this.tbAutoRestart.TabIndex = 4;
            this.tbAutoRestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "AutoRestarter";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel4.BorderRadius = 9;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.btnStartServer);
            this.guna2Panel4.Controls.Add(this.tbStartIP);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel4.Location = new System.Drawing.Point(340, 353);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(303, 196);
            this.guna2Panel4.TabIndex = 6;
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.Transparent;
            this.btnStartServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStartServer.BorderRadius = 10;
            this.btnStartServer.BorderThickness = 1;
            this.btnStartServer.CheckedState.Parent = this.btnStartServer;
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.CustomImages.Parent = this.btnStartServer;
            this.btnStartServer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartServer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartServer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartServer.DisabledState.Parent = this.btnStartServer;
            this.btnStartServer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStartServer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.HoverState.Parent = this.btnStartServer;
            this.btnStartServer.Location = new System.Drawing.Point(111, 132);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.ShadowDecoration.Parent = this.btnStartServer;
            this.btnStartServer.Size = new System.Drawing.Size(180, 45);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // tbStartIP
            // 
            this.tbStartIP.Animated = true;
            this.tbStartIP.BackColor = System.Drawing.Color.Transparent;
            this.tbStartIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbStartIP.BorderRadius = 9;
            this.tbStartIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStartIP.DefaultText = "";
            this.tbStartIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStartIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStartIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStartIP.DisabledState.Parent = this.tbStartIP;
            this.tbStartIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStartIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbStartIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartIP.FocusedState.Parent = this.tbStartIP;
            this.tbStartIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbStartIP.ForeColor = System.Drawing.Color.White;
            this.tbStartIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartIP.HoverState.Parent = this.tbStartIP;
            this.tbStartIP.Location = new System.Drawing.Point(9, 38);
            this.tbStartIP.Name = "tbStartIP";
            this.tbStartIP.PasswordChar = '\0';
            this.tbStartIP.PlaceholderText = "Server exectuable name here.";
            this.tbStartIP.SelectedText = "";
            this.tbStartIP.ShadowDecoration.Parent = this.tbStartIP;
            this.tbStartIP.Size = new System.Drawing.Size(282, 77);
            this.tbStartIP.TabIndex = 4;
            this.tbStartIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start/stop server";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel3.BorderRadius = 9;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.btnStartMaintenance);
            this.guna2Panel3.Controls.Add(this.tbMaintenance);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel3.Location = new System.Drawing.Point(19, 353);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(303, 196);
            this.guna2Panel3.TabIndex = 5;
            // 
            // btnStartMaintenance
            // 
            this.btnStartMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnStartMaintenance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStartMaintenance.BorderRadius = 10;
            this.btnStartMaintenance.BorderThickness = 1;
            this.btnStartMaintenance.CheckedState.Parent = this.btnStartMaintenance;
            this.btnStartMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartMaintenance.CustomImages.Parent = this.btnStartMaintenance;
            this.btnStartMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartMaintenance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartMaintenance.DisabledState.Parent = this.btnStartMaintenance;
            this.btnStartMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStartMaintenance.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStartMaintenance.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnStartMaintenance.HoverState.Parent = this.btnStartMaintenance;
            this.btnStartMaintenance.Location = new System.Drawing.Point(111, 132);
            this.btnStartMaintenance.Name = "btnStartMaintenance";
            this.btnStartMaintenance.ShadowDecoration.Parent = this.btnStartMaintenance;
            this.btnStartMaintenance.Size = new System.Drawing.Size(180, 45);
            this.btnStartMaintenance.TabIndex = 4;
            this.btnStartMaintenance.Text = "Start";
            this.btnStartMaintenance.Click += new System.EventHandler(this.btnStartMaintenance_Click);
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Animated = true;
            this.tbMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.tbMaintenance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbMaintenance.BorderRadius = 9;
            this.tbMaintenance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaintenance.DefaultText = "";
            this.tbMaintenance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaintenance.DisabledState.Parent = this.tbMaintenance;
            this.tbMaintenance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbMaintenance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaintenance.FocusedState.Parent = this.tbMaintenance;
            this.tbMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaintenance.ForeColor = System.Drawing.Color.White;
            this.tbMaintenance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaintenance.HoverState.Parent = this.tbMaintenance;
            this.tbMaintenance.Location = new System.Drawing.Point(9, 38);
            this.tbMaintenance.Multiline = true;
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.PasswordChar = '\0';
            this.tbMaintenance.PlaceholderText = "Text here";
            this.tbMaintenance.SelectedText = "";
            this.tbMaintenance.ShadowDecoration.Parent = this.tbMaintenance;
            this.tbMaintenance.Size = new System.Drawing.Size(282, 77);
            this.tbMaintenance.TabIndex = 4;
            this.tbMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maintenance";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel2.BorderRadius = 9;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.tbAutoPort);
            this.guna2Panel2.Controls.Add(this.btnStartAutoSetup);
            this.guna2Panel2.Controls.Add(this.tbAutoIP);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel2.Location = new System.Drawing.Point(340, 137);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(303, 196);
            this.guna2Panel2.TabIndex = 4;
            // 
            // tbAutoPort
            // 
            this.tbAutoPort.Animated = true;
            this.tbAutoPort.BackColor = System.Drawing.Color.Transparent;
            this.tbAutoPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoPort.BorderRadius = 9;
            this.tbAutoPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAutoPort.DefaultText = "";
            this.tbAutoPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAutoPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAutoPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoPort.DisabledState.Parent = this.tbAutoPort;
            this.tbAutoPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoPort.FocusedState.Parent = this.tbAutoPort;
            this.tbAutoPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAutoPort.ForeColor = System.Drawing.Color.White;
            this.tbAutoPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoPort.HoverState.Parent = this.tbAutoPort;
            this.tbAutoPort.Location = new System.Drawing.Point(9, 85);
            this.tbAutoPort.Name = "tbAutoPort";
            this.tbAutoPort.PasswordChar = '\0';
            this.tbAutoPort.PlaceholderText = "Port Here (ex: 8080)";
            this.tbAutoPort.SelectedText = "";
            this.tbAutoPort.ShadowDecoration.Parent = this.tbAutoPort;
            this.tbAutoPort.Size = new System.Drawing.Size(282, 41);
            this.tbAutoPort.TabIndex = 5;
            this.tbAutoPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartAutoSetup
            // 
            this.btnStartAutoSetup.BackColor = System.Drawing.Color.Transparent;
            this.btnStartAutoSetup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStartAutoSetup.BorderRadius = 10;
            this.btnStartAutoSetup.BorderThickness = 1;
            this.btnStartAutoSetup.CheckedState.Parent = this.btnStartAutoSetup;
            this.btnStartAutoSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAutoSetup.CustomImages.Parent = this.btnStartAutoSetup;
            this.btnStartAutoSetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartAutoSetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartAutoSetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartAutoSetup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartAutoSetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartAutoSetup.DisabledState.Parent = this.btnStartAutoSetup;
            this.btnStartAutoSetup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStartAutoSetup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStartAutoSetup.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAutoSetup.ForeColor = System.Drawing.Color.White;
            this.btnStartAutoSetup.HoverState.Parent = this.btnStartAutoSetup;
            this.btnStartAutoSetup.Location = new System.Drawing.Point(111, 132);
            this.btnStartAutoSetup.Name = "btnStartAutoSetup";
            this.btnStartAutoSetup.ShadowDecoration.Parent = this.btnStartAutoSetup;
            this.btnStartAutoSetup.Size = new System.Drawing.Size(180, 45);
            this.btnStartAutoSetup.TabIndex = 4;
            this.btnStartAutoSetup.Text = "Start setup";
            this.btnStartAutoSetup.Click += new System.EventHandler(this.btnStartAutoSetup_Click);
            // 
            // tbAutoIP
            // 
            this.tbAutoIP.Animated = true;
            this.tbAutoIP.BackColor = System.Drawing.Color.Transparent;
            this.tbAutoIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoIP.BorderRadius = 9;
            this.tbAutoIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAutoIP.DefaultText = "";
            this.tbAutoIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAutoIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAutoIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoIP.DisabledState.Parent = this.tbAutoIP;
            this.tbAutoIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAutoIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAutoIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoIP.FocusedState.Parent = this.tbAutoIP;
            this.tbAutoIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAutoIP.ForeColor = System.Drawing.Color.White;
            this.tbAutoIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAutoIP.HoverState.Parent = this.tbAutoIP;
            this.tbAutoIP.Location = new System.Drawing.Point(9, 38);
            this.tbAutoIP.Name = "tbAutoIP";
            this.tbAutoIP.PasswordChar = '\0';
            this.tbAutoIP.PlaceholderText = "IP Here (exclude growtopiax.com)";
            this.tbAutoIP.SelectedText = "";
            this.tbAutoIP.ShadowDecoration.Parent = this.tbAutoIP;
            this.tbAutoIP.Size = new System.Drawing.Size(282, 41);
            this.tbAutoIP.TabIndex = 4;
            this.tbAutoIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "GTPS AutoSetup";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnCreateHosts);
            this.guna2Panel1.Controls.Add(this.tbHostsIP);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel1.Location = new System.Drawing.Point(19, 137);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(303, 196);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnCreateHosts
            // 
            this.btnCreateHosts.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateHosts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreateHosts.BorderRadius = 10;
            this.btnCreateHosts.BorderThickness = 1;
            this.btnCreateHosts.CheckedState.Parent = this.btnCreateHosts;
            this.btnCreateHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateHosts.CustomImages.Parent = this.btnCreateHosts;
            this.btnCreateHosts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateHosts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateHosts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateHosts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateHosts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateHosts.DisabledState.Parent = this.btnCreateHosts;
            this.btnCreateHosts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCreateHosts.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCreateHosts.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateHosts.ForeColor = System.Drawing.Color.White;
            this.btnCreateHosts.HoverState.Parent = this.btnCreateHosts;
            this.btnCreateHosts.Location = new System.Drawing.Point(111, 132);
            this.btnCreateHosts.Name = "btnCreateHosts";
            this.btnCreateHosts.ShadowDecoration.Parent = this.btnCreateHosts;
            this.btnCreateHosts.Size = new System.Drawing.Size(180, 45);
            this.btnCreateHosts.TabIndex = 4;
            this.btnCreateHosts.Text = "Create";
            this.btnCreateHosts.Click += new System.EventHandler(this.btnCreateHosts_Click);
            // 
            // tbHostsIP
            // 
            this.tbHostsIP.Animated = true;
            this.tbHostsIP.BackColor = System.Drawing.Color.Transparent;
            this.tbHostsIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbHostsIP.BorderRadius = 9;
            this.tbHostsIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHostsIP.DefaultText = "";
            this.tbHostsIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHostsIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHostsIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHostsIP.DisabledState.Parent = this.tbHostsIP;
            this.tbHostsIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHostsIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbHostsIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHostsIP.FocusedState.Parent = this.tbHostsIP;
            this.tbHostsIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbHostsIP.ForeColor = System.Drawing.Color.White;
            this.tbHostsIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHostsIP.HoverState.Parent = this.tbHostsIP;
            this.tbHostsIP.Location = new System.Drawing.Point(9, 38);
            this.tbHostsIP.Multiline = true;
            this.tbHostsIP.Name = "tbHostsIP";
            this.tbHostsIP.PasswordChar = '\0';
            this.tbHostsIP.PlaceholderText = "IP Here (include growtopiax.com)";
            this.tbHostsIP.SelectedText = "";
            this.tbHostsIP.ShadowDecoration.Parent = this.tbHostsIP;
            this.tbHostsIP.Size = new System.Drawing.Size(282, 74);
            this.tbHostsIP.TabIndex = 4;
            this.tbHostsIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hosts Maker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Main Tools";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GrowTools.Properties.Resources.Growtopia_logo_17_352048;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnMainTools;
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // GrowTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(815, 475);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pnMainTools);
            this.Controls.Add(this.pnHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "GrowTools";
            this.Text = "GrowTools by Pronner";
            this.Load += new System.EventHandler(this.GrowTools_Load);
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMainTools.ResumeLayout(false);
            this.pnMainTools.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TileButton btnAdvancedTools;
        private Guna.UI2.WinForms.Guna2TileButton btnStartup;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TileButton btnHackTools;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnHome;
        private Guna.UI2.WinForms.Guna2Panel pnMainTools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbHostsIP;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateHosts;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartAutoSetup;
        private Guna.UI2.WinForms.Guna2TextBox tbAutoIP;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbAutoPort;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartMaintenance;
        private Guna.UI2.WinForms.Guna2TextBox tbMaintenance;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartServer;
        private Guna.UI2.WinForms.Guna2TextBox tbStartIP;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnAutoRestart;
        private Guna.UI2.WinForms.Guna2TextBox tbAutoRestart;
        private System.Windows.Forms.Label label8;
    }
}

