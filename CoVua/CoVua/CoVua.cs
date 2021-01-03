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
            gnbtOnePlayer.Visible = false;
            gnbtTwoPlayers.Visible = false;
            gnbtHelp.Visible = false;
            gnbtExit.Visible = false;
            gnbtLoad.Visible = false;
            gnbtOnePLayerInGame.Visible = true;
            gnbtTwoPLayersInGame.Visible = true;
            gnbtSave.Visible = true;
            gnbtBack.Visible = true;
            gnbtUndo.Visible = true;
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
                label4.Text = "Play with " +
                    "computer";
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
            gnbtOnePlayer.Visible = true;
           gnbtTwoPlayers.Visible = true;
            gnbtHelp.Visible = true;
            gnbtExit.Visible = true;
            gnbtLoad.Visible = true;
            gnbtSave.Visible = false;
            gnbtOnePLayerInGame.Visible = false;
            gnbtTwoPLayersInGame.Visible = false;
            gnbtBack.Visible = false;
            gnbtUndo.Visible = false;
            this.Controls.Remove(chessBoard);
        }
         private void btSave_Click(object sender, EventArgs e)
        {
            chessBoard.SaveChess();
            MessageBox.Show("Đã lưu thành công!!!");  
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chơi tiếp ván cờ gần đây.");
            chessBoard.LoadChess();
          }

        private void btLoad_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Chơi tiếp ván cờ gần đây.");
            chessBoard.LoadChess();
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            chessBoard.SaveChess();
            MessageBox.Show("Đã lưu thành công!!!");
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gamevh.net/cms/static/guide_chess.jsp");
        }

        private void gnbtOnePLayerInGame_Click(object sender, EventArgs e)
        {
            chessBoard.HinhThucChoi = 2;
            ShowMode(chessBoard.HinhThucChoi);
        }

        private void gnbtTwoPLayersInGame_Click(object sender, EventArgs e)
        {
            chessBoard.HinhThucChoi = 1;
            ShowMode(chessBoard.HinhThucChoi);
        }

        private void gnbtUndo_Click(object sender, EventArgs e)
        {
            chessBoard.undo();
            if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn)
                chessBoard.undo();
        }

        private void gnbtSave_Click(object sender, EventArgs e)
        {
            chessBoard.SaveChess();
            MessageBox.Show("Đã lưu thành công!!!");
        }

        private void gnbtBack_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            gnbtOnePlayer.Visible = true;
            gnbtTwoPlayers.Visible = true;
            gnbtHelp.Visible = true;
            gnbtExit.Visible = true;
            gnbtLoad.Visible = true;
            gnbtSave.Visible = false;
            gnbtOnePLayerInGame.Visible = false;
            gnbtTwoPLayersInGame.Visible = false;
            gnbtBack.Visible = false;
            gnbtUndo.Visible = false;
            this.Controls.Remove(chessBoard);
        }

        private void gnbtOnePlayer_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessBoard);
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 2;
            OnOff();
        }

        private void gnbtTwoPlayers_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
            chessBoard.HinhThucChoi = 1;
            OnOff();
        }

        private void gnbtHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gamevh.net/cms/static/guide_chess.jsp");
        }

        private void gnbtLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chơi tiếp ván cờ gần đây.");
            chessBoard.LoadChess();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
