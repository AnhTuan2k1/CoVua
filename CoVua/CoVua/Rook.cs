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
        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            if (chessBoard.Guard(chessman))
                return;
            goDown(chessman, chessBoard, chessman.ForeColor);
            goLeft(chessman, chessBoard, chessman.ForeColor);
            goRight(chessman, chessBoard, chessman.ForeColor);
            goUp(chessman, chessBoard, chessman.ForeColor);
        }

        static public void Movecm(Button chessman, ChessBoard chessBoard)
        {
            goDowncm(chessman, chessBoard, chessman.ForeColor);
            goLeftcm(chessman, chessBoard, chessman.ForeColor);
            goRightcm(chessman, chessBoard, chessman.ForeColor);
            goUpcm(chessman, chessBoard, chessman.ForeColor);
        }
        static public void MoveGuard(Button chessman, ChessBoard chessBoard)
        {
            goDown(chessman, chessBoard, chessman.ForeColor);
            goLeft(chessman, chessBoard, chessman.ForeColor);
            goRight(chessman, chessBoard, chessman.ForeColor);
            goUp(chessman, chessBoard, chessman.ForeColor);
        }

        static public void goLeft(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0) 
            {
                if (chessBoard.cells[indexX - 1, indexY].Text == "")
                {
                    goLeft(chessBoard.cells[indexX - 1, indexY], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY].ForeColor != Source &&
                            chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY].ForeColor != Source)
                            chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                        
                }
            }
        }

        static public void goRight(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY].Text == "")
                {
                    goRight(chessBoard.cells[indexX + 1, indexY], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY].ForeColor != Source &&
                            chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY].ForeColor != Source)
                            chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goUp(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX, indexY - 1].Text == "")
                {
                    goUp(chessBoard.cells[indexX, indexY - 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX, indexY - 1].ForeColor != Source &&
                            chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX, indexY - 1].ForeColor != Source)
                            chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goDown(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX, indexY + 1].Text == "")
                {
                    goDown(chessBoard.cells[indexX, indexY + 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX, indexY + 1].ForeColor != Source &&
                            chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX, indexY + 1].ForeColor != Source)
                            chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        /// <summary>
        /// hiển thị đường chiếu 
        /// </summary>
        /// <param name="RookSrc"></param>
        /// <param name="KingDst"></param>
        /// <param name="chessBoard"></param>
        static public void checkMate(Button RookSrc, Button KingDst, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            int RookSrcindexX = RookSrc.Location.X / RookSrc.Size.Width;
            int RookSrcindexY = RookSrc.Location.Y / RookSrc.Size.Height;

            int KingDstindexX = KingDst.Location.X / KingDst.Size.Width;
            int KingDstindexY = KingDst.Location.Y / KingDst.Size.Height;

            RookSrc.FlatAppearance.BorderColor = Color.Yellow;
            if (RookSrcindexX - KingDstindexX > 0 && RookSrcindexY == KingDstindexY)
            {
                goLeftcm(RookSrc, chessBoard, RookSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }

            }
            else if(RookSrcindexX - KingDstindexX < 0 && RookSrcindexY == KingDstindexY)
            {
                goRightcm(RookSrc, chessBoard, RookSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
            else if (RookSrcindexY - KingDstindexY < 0 && RookSrcindexX == KingDstindexX)
            {
                goDowncm(RookSrc, chessBoard, RookSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
            else if (RookSrcindexY - KingDstindexY > 0 && RookSrcindexX == KingDstindexX)
            {
                goUpcm(RookSrc, chessBoard, RookSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }

        }       

        static public void goLeftcm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0)
            {
                if (chessBoard.cells[indexX - 1, indexY].Text == "")
                {
                    goLeftcm(chessBoard.cells[indexX - 1, indexY], chessBoard, Source);
                    chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                        chessBoard.cells[indexX - 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

        static public void goRightcm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY].Text == "")
                {
                    goRightcm(chessBoard.cells[indexX + 1, indexY], chessBoard, Source);
                    chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                        chessBoard.cells[indexX + 1, indexY].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goUpcm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX, indexY - 1].Text == "")
                {
                    goUpcm(chessBoard.cells[indexX, indexY - 1], chessBoard, Source);
                    chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                        chessBoard.cells[indexX, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goDowncm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX, indexY + 1].Text == "")
                {
                    goDowncm(chessBoard.cells[indexX, indexY + 1], chessBoard, Source);
                    chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
    }
}
