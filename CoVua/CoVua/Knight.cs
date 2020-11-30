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
        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            if (chessBoard.Guard(chessman))
                return;
            goLeftDown1(chessman, chessBoard);
            goLeftUp1(chessman, chessBoard);
            goRightDown1(chessman, chessBoard);
            goRightUp1(chessman, chessBoard);
            goLeftDown2(chessman, chessBoard);
            goLeftUp2(chessman, chessBoard);
            goRightDown2(chessman, chessBoard);
            goRightUp2(chessman, chessBoard);
        }
        static public void Movecm(Button chessman, ChessBoard chessBoard)
        {
            goLeftDown1cm(chessman, chessBoard);
            goLeftUp1cm(chessman, chessBoard);
            goRightDown1cm(chessman, chessBoard);
            goRightUp1cm(chessman, chessBoard);
            goLeftDown2cm(chessman, chessBoard);
            goLeftUp2cm(chessman, chessBoard);
            goRightDown2cm(chessman, chessBoard);
            goRightUp2cm(chessman, chessBoard);
        }

        static public void MoveGuard(Button chessman, ChessBoard chessBoard)
        {
            goLeftDown1(chessman, chessBoard);
            goLeftUp1(chessman, chessBoard);
            goRightDown1(chessman, chessBoard);
            goRightUp1(chessman, chessBoard);
            goLeftDown2(chessman, chessBoard);
            goLeftUp2(chessman, chessBoard);
            goRightDown2(chessman, chessBoard);
            goRightUp2(chessman, chessBoard);
        }
        static public void goRightUp1(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X /chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX + 1 < 8) 
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX + 1, indexY - 2].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 1, indexY - 2].Text == "")                           // ko có quân cờ. -> có thể đi.
                        chessBoard.cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY - 2].ForeColor)     // có quân đối thủ. -> có thể ăn.
                        chessBoard.cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                }
   
            }                                            
        }

        static public void goRightUp2(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX + 2 < 8)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX + 2, indexY - 1].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 2, indexY - 1].Text == "")
                        chessBoard.cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX + 2, indexY - 1].ForeColor)
                        chessBoard.cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }                
            }
        }

        static public void goRightDown1(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 2 < 8 && indexX + 1 < 8) 
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX + 1, indexY + 2].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 1, indexY + 2].Text == "")
                        chessBoard.cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY + 2].ForeColor)
                        chessBoard.cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                }                
            }
        }

        static public void goRightDown2(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX + 2 < 8)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX + 2, indexY + 1].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 2, indexY + 1].Text == "")
                        chessBoard.cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX + 2, indexY + 1].ForeColor)
                        chessBoard.cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }             
            }
        }

        static public void goLeftUp1(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX - 1 >= 0) 
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX - 1, indexY - 2].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 1, indexY - 2].Text == "")
                        chessBoard.cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY - 2].ForeColor)
                        chessBoard.cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
                }               
            }
        }

        static public void goLeftUp2(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 2 >= 0)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX - 2, indexY - 1].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 2, indexY - 1].Text == "")
                        chessBoard.cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX - 2, indexY - 1].ForeColor)
                        chessBoard.cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }               
            }
        }

        static public void goLeftDown1(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;
            

            if (indexY + 2 < 8 && indexX - 1 >= 0)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX - 1, indexY + 2].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 1, indexY + 2].Text == "")
                        chessBoard.cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY + 2].ForeColor)
                        chessBoard.cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
                }              
            }
        }

        static public void goLeftDown2(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 2 >= 0)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessBoard.cells[indexX - 2, indexY + 1].ForeColor != chessman.ForeColor)
                        chessBoard.cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 2, indexY + 1].Text == "")
                        chessBoard.cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    else if (chessman.ForeColor != chessBoard.cells[indexX - 2, indexY + 1].ForeColor)
                        chessBoard.cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
               
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="KnightSrc"></param>
        /// <param name="KingDst"></param>
        /// <param name="chessBoard"></param>
        static public void checkMate(Button KnightSrc, Button KingDst, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            KnightSrc.FlatAppearance.BorderColor = Color.Yellow;
            KingDst.FlatAppearance.BorderColor = Color.Yellow;
        }



        static public void goRightUp1cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX + 1 < 8)
            {
                chessBoard.cells[indexX + 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;             
            }
        }

        static public void goRightUp2cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX + 2 < 8)
            {
                chessBoard.cells[indexX + 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;                
            }
        }

        static public void goRightDown1cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 2 < 8 && indexX + 1 < 8)
            {
                chessBoard.cells[indexX + 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;                
            }
        }

        static public void goRightDown2cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX + 2 < 8)
            {
                chessBoard.cells[indexX + 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;               
            }
        }

        static public void goLeftUp1cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 2 >= 0 && indexX - 1 >= 0)
            {
                chessBoard.cells[indexX - 1, indexY - 2].FlatAppearance.BorderColor = Color.Blue;               
            }
        }

        static public void goLeftUp2cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 2 >= 0)
            {
                chessBoard.cells[indexX - 2, indexY - 1].FlatAppearance.BorderColor = Color.Blue;               
            }
        }

        static public void goLeftDown1cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;


            if (indexY + 2 < 8 && indexX - 1 >= 0)
            {
                chessBoard.cells[indexX - 1, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goLeftDown2cm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 2 >= 0)
            {
                chessBoard.cells[indexX - 2, indexY + 1].FlatAppearance.BorderColor = Color.Blue;               
            }
        }
    }
}
