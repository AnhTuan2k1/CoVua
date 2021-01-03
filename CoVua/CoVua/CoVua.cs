using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace CoVua
{
    public partial class CoVua : Form
    {
        private ChessBoard chessBoard;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public CoVua()
        {
            InitializeComponent();  
        }

        private void DanhVoiMay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mode One player is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 2;
        }

        private void tuChoi1Minh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mode Two players is on!!", "Announcement!!!");
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
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
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
        }

        private void btOnePlayer_Click(object sender, EventArgs e)
        {

            chessBoard.HinhThucChoi = 2;
        }

        private void btTwoPlayers_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mode Two players is on!!", "Announcement!!!");
            //this.Controls.Remove(chessBoard);
            //chessBoard = new ChessBoard();
            //Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 1;
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            try
            {
                chessBoard.undo();
                if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn)
                    chessBoard.undo();
            }
            catch (Exception)
            {
             
            }           
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
            player.URL = @"D:\Luyện tập\Sound\Đen x JustaTee - Đi Về Nhà (M-V).mp3";
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
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
    }
}
