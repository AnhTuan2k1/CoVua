namespace CoVua
{
    partial class PromotionPawn
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
            this.queen = new System.Windows.Forms.Button();
            this.rook = new System.Windows.Forms.Button();
            this.bishop = new System.Windows.Forms.Button();
            this.knight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // queen
            // 
            this.queen.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.queen.Location = new System.Drawing.Point(10, 42);
            this.queen.Name = "queen";
            this.queen.Size = new System.Drawing.Size(259, 90);
            this.queen.TabIndex = 0;
            this.queen.Text = "QUEEN";
            this.queen.UseVisualStyleBackColor = true;
            this.queen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // rook
            // 
            this.rook.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rook.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rook.Location = new System.Drawing.Point(10, 138);
            this.rook.Name = "rook";
            this.rook.Size = new System.Drawing.Size(259, 90);
            this.rook.TabIndex = 1;
            this.rook.Text = "ROOK";
            this.rook.UseVisualStyleBackColor = true;
            this.rook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // bishop
            // 
            this.bishop.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bishop.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bishop.Location = new System.Drawing.Point(10, 234);
            this.bishop.Name = "bishop";
            this.bishop.Size = new System.Drawing.Size(259, 90);
            this.bishop.TabIndex = 2;
            this.bishop.Text = "BISHOP";
            this.bishop.UseVisualStyleBackColor = true;
            this.bishop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // knight
            // 
            this.knight.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knight.ForeColor = System.Drawing.Color.RoyalBlue;
            this.knight.Location = new System.Drawing.Point(10, 330);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(259, 90);
            this.knight.TabIndex = 3;
            this.knight.Text = "KNIGHT";
            this.knight.UseVisualStyleBackColor = true;
            this.knight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoVua.Properties.Resources.hau_trang;
            this.pictureBox1.Location = new System.Drawing.Point(357, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoVua.Properties.Resources.xe_trang;
            this.pictureBox2.Location = new System.Drawing.Point(357, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 61);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoVua.Properties.Resources.tuong_trang_ne;
            this.pictureBox3.Location = new System.Drawing.Point(357, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 64);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CoVua.Properties.Resources.ngua_trang;
            this.pictureBox4.Location = new System.Drawing.Point(357, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 69);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // PromotionPawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 448);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.knight);
            this.Controls.Add(this.bishop);
            this.Controls.Add(this.rook);
            this.Controls.Add(this.queen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromotionPawn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotion";
            this.Load += new System.EventHandler(this.PromotionPawn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button queen;
        private System.Windows.Forms.Button rook;
        private System.Windows.Forms.Button bishop;
        private System.Windows.Forms.Button knight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}