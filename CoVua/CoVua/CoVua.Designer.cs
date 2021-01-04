namespace CoVua
{
    partial class CoVua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoVua));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhVoiMay = new System.Windows.Forms.ToolStripMenuItem();
            this.tuChoi1Minh = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChoiLaitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gnbtOnePLayerInGame = new Guna.UI.WinForms.GunaButton();
            this.gnbtTwoPLayersInGame = new Guna.UI.WinForms.GunaButton();
            this.gnbtUndo = new Guna.UI.WinForms.GunaButton();
            this.gnbtSave = new Guna.UI.WinForms.GunaButton();
            this.gnbtBack = new Guna.UI.WinForms.GunaButton();
            this.gnbtOnePlayer = new Guna.UI.WinForms.GunaGradientButton();
            this.gnbtTwoPlayers = new Guna.UI.WinForms.GunaGradientButton();
            this.gnbtHelp = new Guna.UI.WinForms.GunaGradientButton();
            this.gnbtLoad = new Guna.UI.WinForms.GunaGradientButton();
            this.gnbtExit = new Guna.UI.WinForms.GunaGradientButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhVoiMay,
            this.tuChoi1Minh,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // DanhVoiMay
            // 
            this.DanhVoiMay.Name = "DanhVoiMay";
            this.DanhVoiMay.Size = new System.Drawing.Size(169, 26);
            this.DanhVoiMay.Text = "One Player";
            this.DanhVoiMay.Click += new System.EventHandler(this.DanhVoiMay_Click);
            // 
            // tuChoi1Minh
            // 
            this.tuChoi1Minh.Name = "tuChoi1Minh";
            this.tuChoi1Minh.Size = new System.Drawing.Size(169, 26);
            this.tuChoi1Minh.Text = "Two Players";
            this.tuChoi1Minh.Click += new System.EventHandler(this.tuChoi1Minh_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChoiLaitoolStripMenuItem,
            this.quayLạiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // ChoiLaitoolStripMenuItem
            // 
            this.ChoiLaitoolStripMenuItem.Name = "ChoiLaitoolStripMenuItem";
            this.ChoiLaitoolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.ChoiLaitoolStripMenuItem.Text = "Chơi Lại";
            this.ChoiLaitoolStripMenuItem.Click += new System.EventHandler(this.ChoiLaitoolStripMenuItem_Click);
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.quayLạiToolStripMenuItem.Text = "Quay Lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(485, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font(".VnMysticalH", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 81);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Mode To Play :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(273, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 79);
            this.label1.TabIndex = 9;
            this.label1.Text = "Let\'s Play Chess!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font(".VnRevueH", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(19, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 157);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 61);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mode:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1120, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 54;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1057, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 55;
            // 
            // gnbtOnePLayerInGame
            // 
            this.gnbtOnePLayerInGame.AnimationHoverSpeed = 0.07F;
            this.gnbtOnePLayerInGame.AnimationSpeed = 0.03F;
            this.gnbtOnePLayerInGame.BackColor = System.Drawing.Color.Transparent;
            this.gnbtOnePLayerInGame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtOnePLayerInGame.BorderColor = System.Drawing.Color.Black;
            this.gnbtOnePLayerInGame.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtOnePLayerInGame.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtOnePLayerInGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtOnePLayerInGame.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtOnePLayerInGame.Image = ((System.Drawing.Image)(resources.GetObject("gnbtOnePLayerInGame.Image")));
            this.gnbtOnePLayerInGame.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtOnePLayerInGame.Location = new System.Drawing.Point(0, 366);
            this.gnbtOnePLayerInGame.Name = "gnbtOnePLayerInGame";
            this.gnbtOnePLayerInGame.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtOnePLayerInGame.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtOnePLayerInGame.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtOnePLayerInGame.OnHoverImage = null;
            this.gnbtOnePLayerInGame.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtOnePLayerInGame.Radius = 20;
            this.gnbtOnePLayerInGame.Size = new System.Drawing.Size(232, 88);
            this.gnbtOnePLayerInGame.TabIndex = 56;
            this.gnbtOnePLayerInGame.Text = "One Player";
            this.gnbtOnePLayerInGame.Visible = false;
            this.gnbtOnePLayerInGame.Click += new System.EventHandler(this.gnbtOnePLayerInGame_Click);
            // 
            // gnbtTwoPLayersInGame
            // 
            this.gnbtTwoPLayersInGame.AnimationHoverSpeed = 0.07F;
            this.gnbtTwoPLayersInGame.AnimationSpeed = 0.03F;
            this.gnbtTwoPLayersInGame.BackColor = System.Drawing.Color.Transparent;
            this.gnbtTwoPLayersInGame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtTwoPLayersInGame.BorderColor = System.Drawing.Color.Black;
            this.gnbtTwoPLayersInGame.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtTwoPLayersInGame.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtTwoPLayersInGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtTwoPLayersInGame.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtTwoPLayersInGame.Image = ((System.Drawing.Image)(resources.GetObject("gnbtTwoPLayersInGame.Image")));
            this.gnbtTwoPLayersInGame.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtTwoPLayersInGame.Location = new System.Drawing.Point(0, 449);
            this.gnbtTwoPLayersInGame.Name = "gnbtTwoPLayersInGame";
            this.gnbtTwoPLayersInGame.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtTwoPLayersInGame.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtTwoPLayersInGame.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtTwoPLayersInGame.OnHoverImage = null;
            this.gnbtTwoPLayersInGame.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtTwoPLayersInGame.Radius = 20;
            this.gnbtTwoPLayersInGame.Size = new System.Drawing.Size(232, 88);
            this.gnbtTwoPLayersInGame.TabIndex = 57;
            this.gnbtTwoPLayersInGame.Text = "Two Players";
            this.gnbtTwoPLayersInGame.Visible = false;
            this.gnbtTwoPLayersInGame.Click += new System.EventHandler(this.gnbtTwoPLayersInGame_Click);
            // 
            // gnbtUndo
            // 
            this.gnbtUndo.AnimationHoverSpeed = 0.07F;
            this.gnbtUndo.AnimationSpeed = 0.03F;
            this.gnbtUndo.BackColor = System.Drawing.Color.Transparent;
            this.gnbtUndo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtUndo.BorderColor = System.Drawing.Color.Black;
            this.gnbtUndo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtUndo.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtUndo.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtUndo.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtUndo.Image = ((System.Drawing.Image)(resources.GetObject("gnbtUndo.Image")));
            this.gnbtUndo.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtUndo.Location = new System.Drawing.Point(0, 536);
            this.gnbtUndo.Name = "gnbtUndo";
            this.gnbtUndo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtUndo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtUndo.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtUndo.OnHoverImage = null;
            this.gnbtUndo.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtUndo.Radius = 20;
            this.gnbtUndo.Size = new System.Drawing.Size(232, 88);
            this.gnbtUndo.TabIndex = 58;
            this.gnbtUndo.Text = "Undo";
            this.gnbtUndo.Visible = false;
            this.gnbtUndo.Click += new System.EventHandler(this.gnbtUndo_Click);
            // 
            // gnbtSave
            // 
            this.gnbtSave.AnimationHoverSpeed = 0.07F;
            this.gnbtSave.AnimationSpeed = 0.03F;
            this.gnbtSave.BackColor = System.Drawing.Color.Transparent;
            this.gnbtSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtSave.BorderColor = System.Drawing.Color.Black;
            this.gnbtSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtSave.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtSave.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtSave.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtSave.Image = ((System.Drawing.Image)(resources.GetObject("gnbtSave.Image")));
            this.gnbtSave.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtSave.Location = new System.Drawing.Point(0, 621);
            this.gnbtSave.Name = "gnbtSave";
            this.gnbtSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtSave.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtSave.OnHoverImage = null;
            this.gnbtSave.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtSave.Radius = 20;
            this.gnbtSave.Size = new System.Drawing.Size(232, 88);
            this.gnbtSave.TabIndex = 59;
            this.gnbtSave.Text = "Save";
            this.gnbtSave.Visible = false;
            this.gnbtSave.Click += new System.EventHandler(this.gnbtSave_Click);
            // 
            // gnbtBack
            // 
            this.gnbtBack.AnimationHoverSpeed = 0.07F;
            this.gnbtBack.AnimationSpeed = 0.03F;
            this.gnbtBack.BackColor = System.Drawing.Color.Transparent;
            this.gnbtBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtBack.BorderColor = System.Drawing.Color.Black;
            this.gnbtBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtBack.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtBack.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtBack.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtBack.Image = ((System.Drawing.Image)(resources.GetObject("gnbtBack.Image")));
            this.gnbtBack.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtBack.Location = new System.Drawing.Point(502, 726);
            this.gnbtBack.Name = "gnbtBack";
            this.gnbtBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtBack.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtBack.OnHoverImage = null;
            this.gnbtBack.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtBack.Radius = 20;
            this.gnbtBack.Size = new System.Drawing.Size(245, 71);
            this.gnbtBack.TabIndex = 60;
            this.gnbtBack.Text = "Return to Menu";
            this.gnbtBack.Visible = false;
            this.gnbtBack.Click += new System.EventHandler(this.gnbtBack_Click);
            // 
            // gnbtOnePlayer
            // 
            this.gnbtOnePlayer.AnimationHoverSpeed = 0.07F;
            this.gnbtOnePlayer.AnimationSpeed = 0.03F;
            this.gnbtOnePlayer.BackColor = System.Drawing.Color.Transparent;
            this.gnbtOnePlayer.BaseColor1 = System.Drawing.Color.White;
            this.gnbtOnePlayer.BaseColor2 = System.Drawing.Color.White;
            this.gnbtOnePlayer.BorderColor = System.Drawing.Color.Black;
            this.gnbtOnePlayer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtOnePlayer.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtOnePlayer.Font = new System.Drawing.Font(".VnMysticalH", 15F, System.Drawing.FontStyle.Bold);
            this.gnbtOnePlayer.ForeColor = System.Drawing.Color.Black;
            this.gnbtOnePlayer.Image = ((System.Drawing.Image)(resources.GetObject("gnbtOnePlayer.Image")));
            this.gnbtOnePlayer.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtOnePlayer.Location = new System.Drawing.Point(393, 340);
            this.gnbtOnePlayer.Name = "gnbtOnePlayer";
            this.gnbtOnePlayer.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.gnbtOnePlayer.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.gnbtOnePlayer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtOnePlayer.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gnbtOnePlayer.OnHoverImage = null;
            this.gnbtOnePlayer.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtOnePlayer.Radius = 20;
            this.gnbtOnePlayer.Size = new System.Drawing.Size(219, 87);
            this.gnbtOnePlayer.TabIndex = 61;
            this.gnbtOnePlayer.Text = "One Player";
            this.gnbtOnePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtOnePlayer.Click += new System.EventHandler(this.gnbtOnePlayer_Click);
            // 
            // gnbtTwoPlayers
            // 
            this.gnbtTwoPlayers.AnimationHoverSpeed = 0.07F;
            this.gnbtTwoPlayers.AnimationSpeed = 0.03F;
            this.gnbtTwoPlayers.BackColor = System.Drawing.Color.Transparent;
            this.gnbtTwoPlayers.BaseColor1 = System.Drawing.Color.White;
            this.gnbtTwoPlayers.BaseColor2 = System.Drawing.Color.White;
            this.gnbtTwoPlayers.BorderColor = System.Drawing.Color.Black;
            this.gnbtTwoPlayers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtTwoPlayers.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtTwoPlayers.Font = new System.Drawing.Font(".VnMysticalH", 15F, System.Drawing.FontStyle.Bold);
            this.gnbtTwoPlayers.ForeColor = System.Drawing.Color.Black;
            this.gnbtTwoPlayers.Image = ((System.Drawing.Image)(resources.GetObject("gnbtTwoPlayers.Image")));
            this.gnbtTwoPlayers.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtTwoPlayers.Location = new System.Drawing.Point(671, 341);
            this.gnbtTwoPlayers.Name = "gnbtTwoPlayers";
            this.gnbtTwoPlayers.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.gnbtTwoPlayers.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.gnbtTwoPlayers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtTwoPlayers.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gnbtTwoPlayers.OnHoverImage = null;
            this.gnbtTwoPlayers.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtTwoPlayers.Radius = 20;
            this.gnbtTwoPlayers.Size = new System.Drawing.Size(219, 87);
            this.gnbtTwoPlayers.TabIndex = 62;
            this.gnbtTwoPlayers.Text = "Two Players";
            this.gnbtTwoPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtTwoPlayers.Click += new System.EventHandler(this.gnbtTwoPlayers_Click);
            // 
            // gnbtHelp
            // 
            this.gnbtHelp.AnimationHoverSpeed = 0.07F;
            this.gnbtHelp.AnimationSpeed = 0.03F;
            this.gnbtHelp.BackColor = System.Drawing.Color.Transparent;
            this.gnbtHelp.BaseColor1 = System.Drawing.Color.White;
            this.gnbtHelp.BaseColor2 = System.Drawing.Color.White;
            this.gnbtHelp.BorderColor = System.Drawing.Color.Black;
            this.gnbtHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtHelp.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtHelp.Font = new System.Drawing.Font(".VnMysticalH", 15F, System.Drawing.FontStyle.Bold);
            this.gnbtHelp.ForeColor = System.Drawing.Color.Black;
            this.gnbtHelp.Image = ((System.Drawing.Image)(resources.GetObject("gnbtHelp.Image")));
            this.gnbtHelp.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtHelp.Location = new System.Drawing.Point(502, 537);
            this.gnbtHelp.Name = "gnbtHelp";
            this.gnbtHelp.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.gnbtHelp.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.gnbtHelp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtHelp.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gnbtHelp.OnHoverImage = null;
            this.gnbtHelp.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtHelp.Radius = 20;
            this.gnbtHelp.Size = new System.Drawing.Size(219, 87);
            this.gnbtHelp.TabIndex = 63;
            this.gnbtHelp.Text = "Help";
            this.gnbtHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtHelp.Click += new System.EventHandler(this.gnbtHelp_Click);
            // 
            // gnbtLoad
            // 
            this.gnbtLoad.AnimationHoverSpeed = 0.07F;
            this.gnbtLoad.AnimationSpeed = 0.03F;
            this.gnbtLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtLoad.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtLoad.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gnbtLoad.BorderColor = System.Drawing.Color.Black;
            this.gnbtLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtLoad.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtLoad.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gnbtLoad.ForeColor = System.Drawing.Color.Maroon;
            this.gnbtLoad.Image = ((System.Drawing.Image)(resources.GetObject("gnbtLoad.Image")));
            this.gnbtLoad.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtLoad.Location = new System.Drawing.Point(4, 715);
            this.gnbtLoad.Name = "gnbtLoad";
            this.gnbtLoad.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gnbtLoad.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.gnbtLoad.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtLoad.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gnbtLoad.OnHoverImage = null;
            this.gnbtLoad.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtLoad.Radius = 20;
            this.gnbtLoad.Size = new System.Drawing.Size(219, 68);
            this.gnbtLoad.TabIndex = 64;
            this.gnbtLoad.Text = "Load";
            this.gnbtLoad.Visible = false;
            this.gnbtLoad.Click += new System.EventHandler(this.gnbtLoad_Click);
            // 
            // gnbtExit
            // 
            this.gnbtExit.AnimationHoverSpeed = 0.07F;
            this.gnbtExit.AnimationSpeed = 0.03F;
            this.gnbtExit.BackColor = System.Drawing.Color.Green;
            this.gnbtExit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gnbtExit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gnbtExit.BorderColor = System.Drawing.Color.Black;
            this.gnbtExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtExit.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtExit.Font = new System.Drawing.Font(".VnMysticalH", 15F, System.Drawing.FontStyle.Bold);
            this.gnbtExit.ForeColor = System.Drawing.Color.Black;
            this.gnbtExit.Image = ((System.Drawing.Image)(resources.GetObject("gnbtExit.Image")));
            this.gnbtExit.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtExit.Location = new System.Drawing.Point(1038, 752);
            this.gnbtExit.Name = "gnbtExit";
            this.gnbtExit.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.gnbtExit.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.gnbtExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtExit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gnbtExit.OnHoverImage = null;
            this.gnbtExit.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtExit.Size = new System.Drawing.Size(127, 31);
            this.gnbtExit.TabIndex = 65;
            this.gnbtExit.Text = "Exit";
            this.gnbtExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtExit.Click += new System.EventHandler(this.gnbtExit_Click);
            // 
            // CoVua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1177, 795);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gnbtExit);
            this.Controls.Add(this.gnbtLoad);
            this.Controls.Add(this.gnbtHelp);
            this.Controls.Add(this.gnbtTwoPlayers);
            this.Controls.Add(this.gnbtOnePlayer);
            this.Controls.Add(this.gnbtBack);
            this.Controls.Add(this.gnbtSave);
            this.Controls.Add(this.gnbtUndo);
            this.Controls.Add(this.gnbtTwoPLayersInGame);
            this.Controls.Add(this.gnbtOnePLayerInGame);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoVua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Game";
            this.Load += new System.EventHandler(this.CoVua_Load);
            this.Resize += new System.EventHandler(this.CoVua_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhVoiMay;
        private System.Windows.Forms.ToolStripMenuItem tuChoi1Minh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChoiLaitoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton gnbtOnePLayerInGame;
        private Guna.UI.WinForms.GunaButton gnbtTwoPLayersInGame;
        private Guna.UI.WinForms.GunaButton gnbtUndo;
        private Guna.UI.WinForms.GunaButton gnbtBack;
        private Guna.UI.WinForms.GunaButton gnbtSave;
        private Guna.UI.WinForms.GunaGradientButton gnbtOnePlayer;
        private Guna.UI.WinForms.GunaGradientButton gnbtTwoPlayers;
        private Guna.UI.WinForms.GunaGradientButton gnbtHelp;
        private Guna.UI.WinForms.GunaGradientButton gnbtLoad;
        private Guna.UI.WinForms.GunaGradientButton gnbtExit;
    }
}

