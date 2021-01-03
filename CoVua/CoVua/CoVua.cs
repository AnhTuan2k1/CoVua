using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoVua
{
    public partial class CoVua : Form
    {
        private ChessBoard chessBoard;
        public CoVua()
        {
            InitializeComponent();
            chessBoard = new ChessBoard();
        }

        private void DanhVoiMay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mode One player is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 2;
        }

        private void tuChoi1Minh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mode Two players is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 1;
        }

        
        private void ChoiLaitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chessBoard.undo();
            if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn)
                chessBoard.undo();
        }

        private void CoVua_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mode One player is on!!", "Announcement!!!");
            //this.Controls.Remove(chessBoard);
            //chessBoard = new ChessBoard();
            //Controls.Add(chessBoard);
        }

        private void btOnePlayer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mode One player is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 2;
            OnOff();
            


        }

        private void btTwoPlayers_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mode Two players is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 1;
            OnOff();
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
                chessBoard.undo();
                if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn)
                    chessBoard.undo();
                    
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void CoVua_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chessBoard.undo();
            if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn)
                chessBoard.undo();
        }


        private void OnOff()
        {
            int i= chessBoard.HinhThucChoi;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            btOnePlayer.Visible = false;
            btTwoPlayers.Visible = false;
            btHelp.Visible = false;
            btExit.Visible = false;
            btOnePlayerInGame.Visible = true;
            btTwoPlayersInGame.Visible = true;
            btBack.Visible = true;
            btUndo.Visible = true;
            ShowMode(i);

        }
        private void ShowMode(int i)
        {
            if(i==1)
            {
                label4.Text = "PvP";
            }
            else
            {
                label4.Text = "Alone";
            }
            
        }

        private void btOnePlayerInGame_Click(object sender, EventArgs e)
        {
            chessBoard.HinhThucChoi = 2;
            ShowMode(chessBoard.HinhThucChoi);
        }

        private void btTwoPlayersInGame_Click(object sender, EventArgs e)
        {
            chessBoard.HinhThucChoi = 1;
            ShowMode(chessBoard.HinhThucChoi);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible =false;
            btOnePlayer.Visible = true;
            btTwoPlayers.Visible = true;
            btHelp.Visible = true;
            btExit.Visible = true;
            btOnePlayerInGame.Visible = false;
            btTwoPlayersInGame.Visible = false;
            btBack.Visible = false;
            btUndo.Visible = false;
            this.Controls.Remove(chessBoard);
        }
    }
}
