using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoVua
{
    class King
    {
        static public void Move(Button chessman, Button[,] cells)
        {
            goDown(chessman, cells);
            goLeft(chessman, cells);
            goRight(chessman, cells);
            goUp(chessman, cells);
            goLeftDown(chessman, cells);
            goLeftUp(chessman, cells);
            goRightDown(chessman, cells);
            goRightUp(chessman, cells);
        }

        static public void goLeft(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0)
            {
                if (cells[indexX - 1, indexY].Text == "")
                {
                    cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX - 1, indexY].ForeColor != chessman.ForeColor)
                        cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

        static public void goRight(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8)
            {
                if (cells[indexX + 1, indexY].Text == "")
                {
                    cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY].ForeColor != chessman.ForeColor)
                        cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goUp(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if (cells[indexX, indexY - 1].Text == "")
                {
                    cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX, indexY - 1].ForeColor != chessman.ForeColor)
                        cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goDown(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if (cells[indexX, indexY + 1].Text == "")
                {
                    cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX, indexY + 1].ForeColor != chessman.ForeColor)
                        cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goLeftUp(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY - 1 >= 0)
            {
                if (cells[indexX - 1, indexY - 1].Text == "")
                {
                    cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX - 1, indexY - 1].ForeColor != chessman.ForeColor)
                        cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goLeftDown(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY + 1 < 8)
            {
                if (cells[indexX - 1, indexY + 1].Text == "")
                {
                    cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX - 1, indexY + 1].ForeColor != chessman.ForeColor)
                        cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightUp(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY - 1 >= 0)
            {
                if (cells[indexX + 1, indexY - 1].Text == "")
                {
                    cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY - 1].ForeColor != chessman.ForeColor)
                        cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightDown(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY + 1 < 8)
            {
                if (cells[indexX + 1, indexY + 1].Text == "")
                {
                    cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (cells[indexX + 1, indexY + 1].ForeColor != chessman.ForeColor)
                        cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
    }
}
