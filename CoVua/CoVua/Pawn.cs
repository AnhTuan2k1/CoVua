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
        static public void MovefoNeiBor(Button chessman, ChessBoard chessBoard)
        {
            goUpforNeibor(chessman, chessBoard);
            attackDiagonallyforNeibor(chessman, chessBoard);
        }

        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            goUp(chessman, chessBoard);
            attackDiagonally(chessman, chessBoard);
        }

        static public void MovefoNeiBorcm(Button chessman, ChessBoard chessBoard)
        {
            goUpforNeiborcm(chessman, chessBoard);
            attackDiagonallyforNeiborcm(chessman, chessBoard);
        }

        static public void Movecm(Button chessman, ChessBoard chessBoard)
        {
            goUpcm(chessman, chessBoard);
            attackDiagonallycm(chessman, chessBoard);
        }

        static public void goUp(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X /chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if(chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX, indexY - 1].Text == "" 
                        && chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor == Color.Yellow) 
                        chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                    if (chessBoard.cells[indexX, indexY - 1].Text == "")
                    chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
                

            //đi được 2 ô nếu chưa di chuyển.
            if(chessBoard.checkMate)
            {
                if (indexY == 6 && chessBoard.cells[indexX, indexY - 2].Text == "" && chessBoard.cells[indexX, indexY - 1].Text == ""
                    && chessBoard.cells[indexX, indexY - 2].FlatAppearance.BorderColor == Color.Yellow)
                    chessBoard.cells[indexX, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (indexY == 6 && chessBoard.cells[indexX, indexY - 2].Text == "" && chessBoard.cells[indexX, indexY - 1].Text == "")
                    chessBoard.cells[indexX, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
            }
            
        }
       
        static public void attackDiagonally(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 1 >= 0)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessman.ForeColor != chessBoard.cells[indexX - 1, indexY - 1].ForeColor && chessBoard.cells[indexX - 1, indexY - 1].Text != "")
                        chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }                    
                else if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY - 1].ForeColor && chessBoard.cells[indexX - 1, indexY - 1].Text != "")
                    chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY - 1 >= 0 && indexX + 1 < 8)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessman.ForeColor != chessBoard.cells[indexX + 1, indexY - 1].ForeColor && chessBoard.cells[indexX + 1, indexY - 1].Text != "")
                        chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY - 1].ForeColor && chessBoard.cells[indexX + 1, indexY - 1].Text != "")
                    chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goUpforNeibor(Button chessman, ChessBoard chessBoard)
        {           
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if(chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX, indexY + 1].Text == ""
                        && chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX, indexY + 1].Text == "")
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }


            //đi được 2 ô nếu chưa di chuyển.
            if (chessBoard.checkMate)
            {
                if (indexY == 1 && chessBoard.cells[indexX, indexY + 2].Text == "" && chessBoard.cells[indexX, indexY + 1].Text == ""
                    && chessBoard.cells[indexX, indexY + 2].FlatAppearance.BorderColor == Color.Yellow)
                    chessBoard.cells[indexX, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (indexY == 1 && chessBoard.cells[indexX, indexY + 2].Text == "" && chessBoard.cells[indexX, indexY + 1].Text == "")
                    chessBoard.cells[indexX, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
            }
            
        }

        static public void attackDiagonallyforNeibor(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 1 >= 0)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessman.ForeColor != chessBoard.cells[indexX - 1, indexY + 1].ForeColor && chessBoard.cells[indexX - 1, indexY + 1].Text != "")
                        chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY + 1].ForeColor && chessBoard.cells[indexX - 1, indexY + 1].Text != "")
                    chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY + 1 < 8 && indexX + 1 < 8)
            {
                if (chessBoard.checkMate)
                {
                    if (chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow
                        && chessman.ForeColor != chessBoard.cells[indexX + 1, indexY + 1].ForeColor && chessBoard.cells[indexX + 1, indexY + 1].Text != "")
                        chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY + 1].ForeColor && chessBoard.cells[indexX + 1, indexY + 1].Text != "")
                    chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PawnSrc"></param>
        /// <param name="KingDst"></param>
        /// <param name="chessBoard"></param>
        static public void checkMate(Button PawnSrc, Button KingDst, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            PawnSrc.FlatAppearance.BorderColor = Color.Yellow;
            KingDst.FlatAppearance.BorderColor = Color.Yellow;

        }


        static public void goUpcm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
                if (chessBoard.cells[indexX, indexY - 1].Text == "")
                    chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;

            //đi được 2 ô nếu chưa di chuyển.
            if (indexY == 6 && chessBoard.cells[indexX, indexY - 2].Text == "" && chessBoard.cells[indexX, indexY - 1].Text == "")
                chessBoard.cells[indexX, indexY - 2].FlatAppearance.BorderColor = Color.Blue;
        }

        static public void attackDiagonallycm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0 && indexX - 1 >= 0)
            {
                if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY - 1].ForeColor && chessBoard.cells[indexX - 1, indexY - 1].Text != "")
                    chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY - 1 >= 0 && indexX + 1 < 8)
            {
                if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY - 1].ForeColor && chessBoard.cells[indexX + 1, indexY - 1].Text != "")
                    chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }

        static public void goUpforNeiborcm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
                if (chessBoard.cells[indexX, indexY + 1].Text == "")
                    chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;

            //đi được 2 ô nếu chưa di chuyển.
            if (indexY == 1 && chessBoard.cells[indexX, indexY + 2].Text == "" && chessBoard.cells[indexX, indexY + 1].Text == "")
                chessBoard.cells[indexX, indexY + 2].FlatAppearance.BorderColor = Color.Blue;
        }
        static public void attackDiagonallyforNeiborcm(Button chessman, ChessBoard chessBoard)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8 && indexX - 1 >= 0)
            {
                if (chessman.ForeColor != chessBoard.cells[indexX - 1, indexY + 1].ForeColor && chessBoard.cells[indexX - 1, indexY + 1].Text != "")
                    chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }

            if (indexY + 1 < 8 && indexX + 1 < 8)
            {
                if (chessman.ForeColor != chessBoard.cells[indexX + 1, indexY + 1].ForeColor && chessBoard.cells[indexX + 1, indexY + 1].Text != "")
                    chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
            }
        }
    }
}
