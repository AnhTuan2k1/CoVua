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
        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            ShowillegalAreas(chessBoard);
            goDown(chessman, chessBoard);
            goLeft(chessman, chessBoard);
            goRight(chessman, chessBoard);
            goUp(chessman, chessBoard);
            goLeftDown(chessman, chessBoard);
            goLeftUp(chessman, chessBoard);
            goRightDown(chessman, chessBoard);
            goRightUp(chessman, chessBoard);
            HiddenillegalAreas(chessBoard);
        }

        static public void Movecm(Button chessman, ChessBoard chessBoard)
        {
            goDown(chessman, chessBoard);
            goLeft(chessman, chessBoard);
            goRight(chessman, chessBoard);
            goUp(chessman, chessBoard);
            goLeftDown(chessman, chessBoard);
            goLeftUp(chessman, chessBoard);
            goRightDown(chessman, chessBoard);
            goRightUp(chessman, chessBoard);
        }

        static public void goLeft(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0)
            {
                if(chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX - 1, indexY].Text == "")
                    {
                        chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                }             
            }
        }

        static public void goRight(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX + 1, indexY].Text == "")
                    {
                        chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goUp(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX, indexY - 1].Text == "")
                    {
                        chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX, indexY - 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
                    
            }
        }
        static public void goDown(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX, indexY + 1].Text == "")
                    {
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX, indexY + 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goLeftUp(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX - 1, indexY - 1].Text == "")
                    {
                        chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY - 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goLeftDown(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX - 1, indexY + 1].Text == "")
                    {
                        chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY + 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goRightUp(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX + 1, indexY - 1].Text == "")
                    {
                        chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY - 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goRightDown(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor != Color.Yellow)
                {
                    if (chessBoard.cells[indexX + 1, indexY + 1].Text == "")
                    {
                        chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY + 1].ForeColor != chessman.ForeColor)
                            chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }

        static private void ShowillegalAreas(ChessBoard chessBoard)
        {
            if(chessBoard.MyTurn)
            {
                foreach (Button item in chessBoard.cells)
                {
                    if (item.ForeColor == Color.Black)
                        ChessBoard.ShowMovement(item, chessBoard);
                }
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
            else
            {
                foreach (Button item in chessBoard.cells)
                {
                    if (item.ForeColor == Color.Red)
                        ChessBoard.ShowMovement(item, chessBoard);
                }
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }                
                

        }

        static private void HiddenillegalAreas(ChessBoard chessBoard)
        {           
            foreach (Button item in chessBoard.cells)
            {
                if (item.FlatAppearance.BorderColor == Color.Yellow)
                    item.FlatAppearance.BorderColor = Color.Black;
            }
        }
    }
}
