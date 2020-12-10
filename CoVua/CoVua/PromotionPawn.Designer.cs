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
            this.SuspendLayout();
            // 
            // queen
            // 
            this.queen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.rook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bishop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.knight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knight.Location = new System.Drawing.Point(10, 330);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(259, 90);
            this.knight.TabIndex = 3;
            this.knight.Text = "KNIGHT";
            this.knight.UseVisualStyleBackColor = true;
            this.knight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // PromotionPawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 430);
            this.Controls.Add(this.knight);
            this.Controls.Add(this.bishop);
            this.Controls.Add(this.rook);
            this.Controls.Add(this.queen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromotionPawn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button queen;
        private System.Windows.Forms.Button rook;
        private System.Windows.Forms.Button bishop;
        private System.Windows.Forms.Button knight;
    }
}