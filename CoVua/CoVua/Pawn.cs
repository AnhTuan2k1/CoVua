using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVua
{
    class Pawn 
    {
        static public void goUp(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X /chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
                if (cells[indexX, indexY - 1].Text == "")
                    cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;

            //đi được 2 ô nếu chưa di chuyển.
            if (indexY == 6 && cells[indexX, indexY - 2].Text == "") 
                cells[indexX, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
        }
       
        static public void attackDiagonally(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 1 >= 0)
            {
                if (chessman.ForeColor != cells[indexX - 1, indexY - 1].ForeColor && cells[indexX - 1, indexY - 1].Text != "")
                    cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY - 1 >= 0 && indexX + 1 < 8)
            {
                if (chessman.ForeColor != cells[indexX + 1, indexY - 1].ForeColor && cells[indexX + 1, indexY - 1].Text != "")
                    cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goUpforNeibor(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
                if (cells[indexX, indexY + 1].Text == "")
                    cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;

            //đi được 2 ô nếu chưa di chuyển.
            if (indexY == 1 && cells[indexX, indexY + 2].Text == "")
                cells[indexX, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
        }

        static public void attackDiagonallyforNeibor(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 1 >= 0)
            {
                if (chessman.ForeColor != cells[indexX - 1, indexY + 1].ForeColor && cells[indexX - 1, indexY + 1].Text != "")
                    cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY + 1 < 8 && indexX + 1 < 8)
            {
                if (chessman.ForeColor != cells[indexX + 1, indexY + 1].ForeColor && cells[indexX + 1, indexY + 1].Text != "")
                    cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

    }
}
