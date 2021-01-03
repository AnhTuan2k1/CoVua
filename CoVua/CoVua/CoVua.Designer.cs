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
            this.btHelp = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btOnePlayer = new System.Windows.Forms.Button();
            this.btTwoPlayers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btOnePlayerInGame = new System.Windows.Forms.Button();
            this.btTwoPlayersInGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btUndo = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1177, 30);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // DanhVoiMay
            // 
            this.DanhVoiMay.Name = "DanhVoiMay";
            this.DanhVoiMay.Size = new System.Drawing.Size(224, 26);
            this.DanhVoiMay.Text = "One Player";
            this.DanhVoiMay.Click += new System.EventHandler(this.DanhVoiMay_Click);
            // 
            // tuChoi1Minh
            // 
            this.tuChoi1Minh.Name = "tuChoi1Minh";
            this.tuChoi1Minh.Size = new System.Drawing.Size(224, 26);
            this.tuChoi1Minh.Text = "Two Players";
            this.tuChoi1Minh.Click += new System.EventHandler(this.tuChoi1Minh_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.White;
            this.btHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHelp.FlatAppearance.BorderSize = 2;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.Location = new System.Drawing.Point(499, 449);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(232, 88);
            this.btHelp.TabIndex = 5;
            this.btHelp.TabStop = false;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 2;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(499, 669);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(232, 88);
            this.btExit.TabIndex = 5;
            this.btExit.TabStop = false;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btOnePlayer
            // 
            this.btOnePlayer.BackColor = System.Drawing.Color.White;
            this.btOnePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOnePlayer.FlatAppearance.BorderSize = 2;
            this.btOnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnePlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOnePlayer.Location = new System.Drawing.Point(393, 340);
            this.btOnePlayer.Name = "btOnePlayer";
            this.btOnePlayer.Size = new System.Drawing.Size(232, 88);
            this.btOnePlayer.TabIndex = 50;
            this.btOnePlayer.TabStop = false;
            this.btOnePlayer.Text = "One Player";
            this.btOnePlayer.UseVisualStyleBackColor = false;
            this.btOnePlayer.Click += new System.EventHandler(this.btOnePlayer_Click);
            // 
            // btTwoPlayers
            // 
            this.btTwoPlayers.BackColor = System.Drawing.Color.White;
            this.btTwoPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTwoPlayers.FlatAppearance.BorderSize = 2;
            this.btTwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTwoPlayers.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTwoPlayers.Location = new System.Drawing.Point(631, 340);
            this.btTwoPlayers.Name = "btTwoPlayers";
            this.btTwoPlayers.Size = new System.Drawing.Size(232, 88);
            this.btTwoPlayers.TabIndex = 2;
            this.btTwoPlayers.TabStop = false;
            this.btTwoPlayers.Text = "Two Players";
            this.btTwoPlayers.UseVisualStyleBackColor = false;
            this.btTwoPlayers.Click += new System.EventHandler(this.btTwoPlayers_Click);
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
            // btOnePlayerInGame
            // 
            this.btOnePlayerInGame.BackColor = System.Drawing.Color.White;
            this.btOnePlayerInGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOnePlayerInGame.FlatAppearance.BorderSize = 2;
            this.btOnePlayerInGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnePlayerInGame.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOnePlayerInGame.Location = new System.Drawing.Point(35, 270);
            this.btOnePlayerInGame.Name = "btOnePlayerInGame";
            this.btOnePlayerInGame.Size = new System.Drawing.Size(232, 88);
            this.btOnePlayerInGame.TabIndex = 7;
            this.btOnePlayerInGame.Text = "One Player";
            this.btOnePlayerInGame.UseVisualStyleBackColor = false;
            this.btOnePlayerInGame.Visible = false;
            this.btOnePlayerInGame.Click += new System.EventHandler(this.btOnePlayerInGame_Click);
            // 
            // btTwoPlayersInGame
            // 
            this.btTwoPlayersInGame.BackColor = System.Drawing.Color.White;
            this.btTwoPlayersInGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTwoPlayersInGame.FlatAppearance.BorderSize = 2;
            this.btTwoPlayersInGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTwoPlayersInGame.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTwoPlayersInGame.Location = new System.Drawing.Point(35, 373);
            this.btTwoPlayersInGame.Name = "btTwoPlayersInGame";
            this.btTwoPlayersInGame.Size = new System.Drawing.Size(232, 88);
            this.btTwoPlayersInGame.TabIndex = 8;
            this.btTwoPlayersInGame.Text = "Two Players";
            this.btTwoPlayersInGame.UseVisualStyleBackColor = false;
            this.btTwoPlayersInGame.Visible = false;
            this.btTwoPlayersInGame.Click += new System.EventHandler(this.btTwoPlayersInGame_Click);
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
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatAppearance.BorderSize = 2;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(35, 695);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(232, 88);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "Return To Menu";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(119, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 81);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(-8, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 61);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mode:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // btUndo
            // 
            this.btUndo.BackColor = System.Drawing.Color.White;
            this.btUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUndo.FlatAppearance.BorderSize = 2;
            this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUndo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.Location = new System.Drawing.Point(35, 479);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(232, 88);
            this.btUndo.TabIndex = 51;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = false;
            this.btUndo.Visible = false;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.White;
            this.btLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoad.FlatAppearance.BorderSize = 2;
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoad.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(499, 562);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(232, 88);
            this.btLoad.TabIndex = 52;
            this.btLoad.TabStop = false;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click_1);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatAppearance.BorderSize = 2;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(35, 585);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(232, 88);
            this.btSave.TabIndex = 53;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
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
            // CoVua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1177, 795);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTwoPlayersInGame);
            this.Controls.Add(this.btOnePlayerInGame);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTwoPlayers);
            this.Controls.Add(this.btOnePlayer);
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
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btTwoPlayers;
        private System.Windows.Forms.Button btOnePlayer;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOnePlayerInGame;
        private System.Windows.Forms.Button btTwoPlayersInGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}

