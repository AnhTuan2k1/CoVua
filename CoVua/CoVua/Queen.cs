using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CoVua
{
    class Queen
    {
        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            goDown(chessman, chessBoard, chessman.ForeColor);
            goLeft(chessman, chessBoard, chessman.ForeColor);
            goRight(chessman, chessBoard, chessman.ForeColor);
            goUp(chessman, chessBoard, chessman.ForeColor);
            goLeftDown(chessman, chessBoard, chessman.ForeColor);
            goLeftUp(chessman, chessBoard, chessman.ForeColor);
            goRightDown(chessman, chessBoard, chessman.ForeColor);
            goRightUp(chessman, chessBoard, chessman.ForeColor);
        }
        static public void Movecm(Button chessman, ChessBoard chessBoard)
        {
            goDowncm(chessman, chessBoard, chessman.ForeColor);
            goLeftcm(chessman, chessBoard, chessman.ForeColor);
            goRightcm(chessman, chessBoard, chessman.ForeColor);
            goUpcm(chessman, chessBoard, chessman.ForeColor);
            goLeftDowncm(chessman, chessBoard, chessman.ForeColor);
            goLeftUpcm(chessman, chessBoard, chessman.ForeColor);
            goRightDowncm(chessman, chessBoard, chessman.ForeColor);
            goRightUpcm(chessman, chessBoard, chessman.ForeColor);
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
        static public void goLeftUp(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX - 1, indexY - 1].Text == "")
                {
                    goLeftUp(chessBoard.cells[indexX - 1, indexY - 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY - 1].ForeColor != Source &&
                            chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY - 1].ForeColor != Source)
                            chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goLeftDown(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX - 1, indexY + 1].Text == "")
                {
                    goLeftDown(chessBoard.cells[indexX - 1, indexY + 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX - 1, indexY + 1].ForeColor != Source &&
                            chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX - 1, indexY + 1].ForeColor != Source)
                            chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goRightUp(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX + 1, indexY - 1].Text == "")
                {
                    goRightUp(chessBoard.cells[indexX + 1, indexY - 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY - 1].ForeColor != Source &&
                            chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY - 1].ForeColor != Source)
                            chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        static public void goRightDown(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY + 1].Text == "")
                {
                    goRightDown(chessBoard.cells[indexX + 1, indexY + 1], chessBoard, Source);
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                        chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.checkMate)
                    {
                        if (chessBoard.cells[indexX + 1, indexY + 1].ForeColor != Source &&
                            chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor == Color.Yellow)
                            chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                    else
                    {
                        if (chessBoard.cells[indexX + 1, indexY + 1].ForeColor != Source)
                            chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }
        /// <summary>
        /// Hiển thị đường Chiếu
        /// </summary>
        /// <param name="RookSrc"></param>
        /// <param name="KingDst"></param>
        /// <param name="chessBoard"></param>
        static public void checkMate(Button QueenSrc, Button KingDst, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            int QueenSrcindexX = QueenSrc.Location.X / QueenSrc.Size.Width;
            int QueenSrcindexY = QueenSrc.Location.Y / QueenSrc.Size.Height;

            int KingDstindexX = KingDst.Location.X / KingDst.Size.Width;
            int KingDstindexY = KingDst.Location.Y / KingDst.Size.Height;

            QueenSrc.FlatAppearance.BorderColor = Color.Yellow;
            if (QueenSrcindexX - KingDstindexX > 0 && QueenSrcindexY == KingDstindexY)
            {
                goLeftcm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }

            }
            else if (QueenSrcindexX - KingDstindexX < 0 && QueenSrcindexY == KingDstindexY)
            {
                goRightcm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
            else if (QueenSrcindexY - KingDstindexY < 0 && QueenSrcindexX == KingDstindexX)
            {
                goDowncm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
            else if (QueenSrcindexY - KingDstindexY > 0 && QueenSrcindexX == KingDstindexX)
            {
                goUpcm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                foreach (Button item in chessBoard.cells)
                {
                    if (item.FlatAppearance.BorderColor == Color.Blue)
                        item.FlatAppearance.BorderColor = Color.Yellow;
                }
            }

            else if (QueenSrcindexX - KingDstindexX > 0)
            {
                if (QueenSrcindexY - KingDstindexY > 0)
                {
                    goLeftUpcm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
                else
                {
                    goLeftDowncm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
            }
            else
            {
                if (QueenSrcindexY - KingDstindexY > 0)
                {
                    goRightUpcm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
                else
                {
                    goRightDowncm(QueenSrc, chessBoard, QueenSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
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
                    if (chessBoard.cells[indexX - 1, indexY].ForeColor != Source)
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
                    if (chessBoard.cells[indexX + 1, indexY].ForeColor != Source)
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
                    if (chessBoard.cells[indexX, indexY - 1].ForeColor != Source)
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
                    if (chessBoard.cells[indexX, indexY + 1].ForeColor != Source)
                        chessBoard.cells[indexX, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }

        static public void goLeftUpcm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX - 1, indexY - 1].Text == "")
                {
                    goLeftUpcm(chessBoard.cells[indexX - 1, indexY - 1], chessBoard, Source);
                    chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 1, indexY - 1].ForeColor != Source)
                        chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goLeftDowncm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX - 1 >= 0 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX - 1, indexY + 1].Text == "")
                {
                    goLeftDowncm(chessBoard.cells[indexX - 1, indexY + 1], chessBoard, Source);
                    chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX - 1, indexY + 1].ForeColor != Source)
                        chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightUpcm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY - 1 >= 0)
            {
                if (chessBoard.cells[indexX + 1, indexY - 1].Text == "")
                {
                    goRightUpcm(chessBoard.cells[indexX + 1, indexY - 1], chessBoard, Source);
                    chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 1, indexY - 1].ForeColor != Source)
                        chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        static public void goRightDowncm(Button chessman, ChessBoard chessBoard, Color Source)
        {
            int indexX = chessman.Location.X / chessman.Size.Width;
            int indexY = chessman.Location.Y / chessman.Size.Height;

            if (indexX + 1 < 8 && indexY + 1 < 8)
            {
                if (chessBoard.cells[indexX + 1, indexY + 1].Text == "")
                {
                    goRightDowncm(chessBoard.cells[indexX + 1, indexY + 1], chessBoard, Source);
                    chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    if (chessBoard.cells[indexX + 1, indexY + 1].ForeColor != Source)
                        chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }



    }
}
