using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoVua
{
    class Bishop
    {
        static public void Move(Button chessman, Button[,] cells)
        {
            goLeftDown(chessman, cells, chessman.ForeColor);
            goLeftUp(chessman, cells, chessman.ForeColor);
            goRightDown(chessman, cells, chessman.ForeColor);
            goRightUp(chessman, cells, chessman.ForeColor);
        }


        static public void goLeftUp(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY - 1 >= 0)
            {
                if (cells[indexX - 1, indexY - 1].Text == "")
                {
                    goLeftUp(cells[indexX - 1, indexY - 1], cells, Source);
                    cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }                   
                else
                {
                    if (cells[indexX - 1, indexY - 1].ForeColor != Source)
                        cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goLeftDown(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY + 1 < 8)
            {
                if (cells[indexX - 1, indexY + 1].Text == "")
                {
                    goLeftDown(cells[indexX - 1, indexY + 1], cells, Source);
                    cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX - 1, indexY + 1].ForeColor != Source)
                        cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightUp(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY - 1 >= 0)
            {
                if (cells[indexX + 1, indexY - 1].Text == "")
                {
                    goRightUp(cells[indexX + 1, indexY - 1], cells, Source);
                    cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY - 1].ForeColor != Source)
                        cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightDown(Button chessman, Button[,] cells, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY + 1 < 8)
            {
                if (cells[indexX + 1, indexY + 1].Text == "")
                {
                    goRightDown(cells[indexX + 1, indexY + 1], cells,Source);
                    cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY + 1].ForeColor != Source)
                        cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

    }
}
