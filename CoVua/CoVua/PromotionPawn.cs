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
    public partial class PromotionPawn : Form
    {
        ChessBoard chessboard;
        public PromotionPawn(ChessBoard chessBoard)
        {
            chessboard = chessBoard; 
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (chessboard.promotionPawn == -1)
            {
                Close();
                return;
            }
                

            Button chessman = (Button)sender;
            if(chessboard.MyTurn)
            {
                chessboard.cells[chessboard.promotionPawn, 0].Text = chessman.Name;
                chessboard.cells[chessboard.promotionPawn, 0].ForeColor = Color.Red;
                
            }
            else
            {
                chessboard.cells[chessboard.promotionPawn, 7].Text = chessman.Name;
                chessboard.cells[chessboard.promotionPawn, 7].ForeColor = Color.Black;
            }

            this.Close();
        }

        private void PromotionPawn_Load(object sender, EventArgs e)
        {

        }
    }
}
