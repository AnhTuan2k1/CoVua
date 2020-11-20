using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVua
{
    class Knight
    {
        static public void Move(Button chessman, Button[,] cells)
        {
            goLeftDown1(chessman, cells);
            goLeftUp1(chessman, cells);
            goRightDown1(chessman, cells);
            goRightUp1(chessman, cells);
            goLeftDown2(chessman, cells);
            goLeftUp2(chessman, cells);
            goRightDown2(chessman, cells);
            goRightUp2(chessman, cells);
        }

        static public void goRightUp1(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X /chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX + 1 < 8) 
            {
                if (cells[indexX + 1, indexY - 2].Text == "")                           // ko có quân cờ. -> có thể đi.
                    cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX + 1, indexY - 2].ForeColor)     // có quân đối thủ. -> có thể ăn.
                    cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;   
            }                                            
        }

        static public void goRightUp2(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX + 2 < 8)
            {
                if (cells[indexX + 2, indexY - 1].Text == "")                           
                    cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX + 2, indexY - 1].ForeColor)     
                    cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goRightDown1(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 2 < 8 && indexX + 1 < 8) 
            {
                if (cells[indexX + 1, indexY + 2].Text == "")                           
                    cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX + 1, indexY + 2].ForeColor)     
                    cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goRightDown2(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX + 2 < 8)
            {
                if (cells[indexX + 2, indexY + 1].Text == "")
                    cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX + 2, indexY + 1].ForeColor)
                    cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goLeftUp1(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX - 1 >= 0) 
            {
                if (cells[indexX - 1, indexY - 2].Text == "")
                    cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX - 1, indexY - 2].ForeColor)
                    cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goLeftUp2(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 2 >= 0)
            {
                if (cells[indexX - 2, indexY - 1].Text == "")
                    cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX - 2, indexY - 1].ForeColor)
                    cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goLeftDown1(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 2 < 8 && indexX - 1 >= 0)
            {
                if (cells[indexX - 1, indexY + 2].Text == "")
                    cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX - 1, indexY + 2].ForeColor)
                    cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goLeftDown2(Button chessman, Button[,] cells)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 2 >= 0)
            {
                if (cells[indexX - 2, indexY + 1].Text == "")
                    cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                else if (chessman.ForeColor != cells[indexX - 2, indexY + 1].ForeColor)
                    cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }
    }
}
