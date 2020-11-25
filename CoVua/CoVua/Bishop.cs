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
        static public void Move(Button chessman, ChessBoard chessBoard)
        {
            goLeftDown(chessman, chessBoard, chessman.ForeColor);
            goLeftUp(chessman, chessBoard, chessman.ForeColor);
            goRightDown(chessman, chessBoard, chessman.ForeColor);
            goRightUp(chessman, chessBoard, chessman.ForeColor);
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
                    if (chessBoard.cells[indexX - 1, indexY - 1].ForeColor != Source)
                        chessBoard.cells[indexX - 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
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
                    if (chessBoard.cells[indexX - 1, indexY + 1].ForeColor != Source)
                        chessBoard.cells[indexX - 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
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
                    if (chessBoard.cells[indexX + 1, indexY - 1].ForeColor != Source)
                        chessBoard.cells[indexX + 1, indexY - 1].FlatAppearance.BorderColor = Color.Blue;
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
                    goRightDown(chessBoard.cells[indexX + 1, indexY + 1], chessBoard,Source);
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
                    if (chessBoard.cells[indexX + 1, indexY + 1].ForeColor != Source)
                        chessBoard.cells[indexX + 1, indexY + 1].FlatAppearance.BorderColor = Color.Blue;
                }
            }
        }
        /// <summary>
        /// hiển thị đường chiếu
        /// </summary>
        /// <param name="BishopSrc"></param>
        /// <param name="KingDst"></param>
        /// <param name="chessBoard"></param>
        static public void checkMate(Button BishopSrc, Button KingDst, ChessBoard chessBoard)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            int BishopSrcindexX = BishopSrc.Location.X / BishopSrc.Size.Width;
            int BishopSrcindexY = BishopSrc.Location.Y / BishopSrc.Size.Height;

            int KingDstindexX = KingDst.Location.X / KingDst.Size.Width;
            int KingDstindexY = KingDst.Location.Y / KingDst.Size.Height;

            BishopSrc.FlatAppearance.BorderColor = Color.Yellow;
            if (BishopSrcindexX - KingDstindexX > 0)
            {
                if(BishopSrcindexY - KingDstindexY > 0)
                {
                    goLeftUpcm(BishopSrc, chessBoard, BishopSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
                else
                {
                    goLeftDowncm(BishopSrc, chessBoard, BishopSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
            } 
            else
            {
                if (BishopSrcindexY - KingDstindexY > 0)
                {
                    goRightUpcm(BishopSrc, chessBoard, BishopSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
                }
                else
                {
                    goRightDowncm(BishopSrc, chessBoard, BishopSrc.ForeColor);
                    foreach (Button item in chessBoard.cells)
                    {
                        if (item.FlatAppearance.BorderColor == Color.Blue)
                            item.FlatAppearance.BorderColor = Color.Yellow;
                    }
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
