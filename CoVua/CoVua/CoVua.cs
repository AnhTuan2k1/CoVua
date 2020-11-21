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
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chessBoard = new ChessBoard();
            Controls.Add(chessBoard);
        }

    }
}
