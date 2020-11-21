using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CoVua
{
    class Rook
    {
        static public void Move(Button chessman, Button[,] cells)
        {
            goDown(chessman, cells, chessman.ForeColor);
            goLeft(chessman, cells, chessman.ForeColor);
            goRight(chessman, cells, chessman.ForeColor);
            goUp(chessman, cells, chessman.ForeColor);
        }

        static public void goLeft(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0) 
            {
                if (cells[indexX - 1, indexY].Text == "")
                {
                    goLeft(cells[indexX - 1, indexY], cells, Source);
                    cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX - 1, indexY].ForeColor != Source)
                        cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

        static public void goRight(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8)
            {
                if (cells[indexX + 1, indexY].Text == "")
                {
                    goRight(cells[indexX + 1, indexY], cells, Source);
                    cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY].ForeColor != Source)
                        cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goUp(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if (cells[indexX, indexY - 1].Text == "")
                {
                    goUp(cells[indexX, indexY - 1], cells, Source);
                    cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX, indexY - 1].ForeColor != Source)
                        cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goDown(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if (cells[indexX, indexY + 1].Text == "")
                {
                    goDown(cells[indexX, indexY + 1], cells, Source);
                    cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX, indexY + 1].ForeColor != Source)
                        cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

    }
}
