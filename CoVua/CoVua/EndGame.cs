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
    public partial class EndGame : Form
    {
        ChessBoard chessBoard;
        public EndGame(ChessBoard chessBoard)
        {
            this.chessBoard = chessBoard;
            InitializeComponent();
        }

        private void EndGame_Shown(object sender, EventArgs e)
        {
            if (chessBoard.MyTurn)
                label1.Text = "You loss";
            else
                label1.Text = "You Win";
            label2.Text += " " + chessBoard.movementInfos.Count.ToString();

            chessBoard.Enabled = false;
        }
    }
}
