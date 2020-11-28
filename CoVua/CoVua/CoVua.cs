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
            Controls.Add(chessBoard);
            
        }

        private void DanhVoiMay_Click(object sender, EventArgs e)
        {
            //Controls.Remove(chessBoard);
            //chessBoard = new ChessBoard();
            //Controls.Add(chessBoard);

            if (!chessBoard.MyTurn)
            {
                ChessBoard.ResetBoderColor(chessBoard);
                Computer.Move(chessBoard);
                chessBoard.HinhThucChoi = 2;
                chessBoard.MyTurn = !chessBoard.MyTurn;
            }
            else
                chessBoard.HinhThucChoi = 2;
        }

        private void tuChoi1Minh_Click(object sender, EventArgs e)
        {
            chessBoard.HinhThucChoi = 1;
        }

        private void ChoiLaitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessBoard);
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
        }
    }
}
