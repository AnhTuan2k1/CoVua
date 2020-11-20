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
            this.Controls.Add(chessBoard);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

    }
}
