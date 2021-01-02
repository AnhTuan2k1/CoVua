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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhVoiMay = new System.Windows.Forms.ToolStripMenuItem();
            this.tuChoi1Minh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChoiLaitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOnePlayer = new System.Windows.Forms.Button();
            this.btTwoPlayers = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btHelp);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btOnePlayer);
            this.panel1.Controls.Add(this.btTwoPlayers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btLoad);
            this.panel1.Controls.Add(this.btUndo);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 762);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 150);
            this.panel2.TabIndex = 0;
            // 
            // btOnePlayer
            // 
            this.btOnePlayer.BackColor = System.Drawing.Color.White;
            this.btOnePlayer.FlatAppearance.BorderSize = 0;
            this.btOnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnePlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOnePlayer.Location = new System.Drawing.Point(0, 146);
            this.btOnePlayer.Name = "btOnePlayer";
            this.btOnePlayer.Size = new System.Drawing.Size(232, 88);
            this.btOnePlayer.TabIndex = 1;
            this.btOnePlayer.Text = "One Player";
            this.btOnePlayer.UseVisualStyleBackColor = false;
            this.btOnePlayer.Click += new System.EventHandler(this.btOnePlayer_Click);
            // 
            // btTwoPlayers
            // 
            this.btTwoPlayers.BackColor = System.Drawing.Color.White;
            this.btTwoPlayers.FlatAppearance.BorderSize = 0;
            this.btTwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTwoPlayers.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTwoPlayers.Location = new System.Drawing.Point(0, 220);
            this.btTwoPlayers.Name = "btTwoPlayers";
            this.btTwoPlayers.Size = new System.Drawing.Size(232, 97);
            this.btTwoPlayers.TabIndex = 2;
            this.btTwoPlayers.Text = "Two Players";
            this.btTwoPlayers.UseVisualStyleBackColor = false;
            this.btTwoPlayers.Click += new System.EventHandler(this.btTwoPlayers_Click);
            // 
            // btUndo
            // 
            this.btUndo.BackColor = System.Drawing.Color.White;
            this.btUndo.FlatAppearance.BorderSize = 0;
            this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUndo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.Location = new System.Drawing.Point(-3, 314);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(232, 93);
            this.btUndo.TabIndex = 3;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = false;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(-3, 406);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(232, 99);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.White;
            this.btLoad.FlatAppearance.BorderSize = 0;
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoad.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(-3, 499);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(232, 94);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = false;
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.White;
            this.btHelp.FlatAppearance.BorderSize = 0;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.Location = new System.Drawing.Point(-3, 586);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(232, 90);
            this.btHelp.TabIndex = 5;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(-3, 673);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(238, 89);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chess Game";
            // 
            // button2
            // 
            this.button2.Image = global::CoVua.Properties.Resources.icons8_no_audio_40;
            this.button2.Location = new System.Drawing.Point(1102, 732);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 51);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CoVua.Properties.Resources.icons8_low_volume_40;
            this.button1.Location = new System.Drawing.Point(1024, 732);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 51);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoVua.Properties.Resources.icons8_knight_100;
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // CoVua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1177, 795);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoVua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Game";
            this.Load += new System.EventHandler(this.CoVua_Load);
            this.Resize += new System.EventHandler(this.CoVua_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btTwoPlayers;
        private System.Windows.Forms.Button btOnePlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

