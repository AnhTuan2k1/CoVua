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
            ShowCastling(chessBoard);
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

        static public void ShowCastling(ChessBoard chessBoard)
        {
            if (chessBoard.checkMate) //đk vua ko bị chiếu
                return;

            if (chessBoard.MyTurn)
            {
                if (chessBoard.vua_trang && chessBoard.xe_trang_trai)
                {
                    if (chessBoard.cells[1, 7].Text == "" && chessBoard.cells[2, 7].Text == "" && chessBoard.cells[3, 7].Text == "")
                    {
                        if (chessBoard.cells[2, 7].FlatAppearance.BorderColor != Color.Yellow)
                            chessBoard.cells[2, 7].FlatAppearance.BorderColor = Color.Blue;
                    }                
                }
                if (chessBoard.vua_trang && chessBoard.xe_trang_phai)
                {
                    if (chessBoard.cells[5, 7].Text == "" && chessBoard.cells[6, 7].Text == "") 
                    {
                        if (chessBoard.cells[6, 7].FlatAppearance.BorderColor != Color.Yellow)
                            chessBoard.cells[6, 7].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
            else
            {
                if (chessBoard.vua_den && chessBoard.xe_den_trai) //đk cả 2 chưa di chuyển
                {
                    //đk giữa xe và vua trống
                    if (chessBoard.cells[1, 0].Text == "" && chessBoard.cells[2, 0].Text == "" && chessBoard.cells[3, 0].Text == "") 
                    {
                        if (chessBoard.cells[2, 0].FlatAppearance.BorderColor != Color.Yellow) //đk vị trí chuyển tới ko bị chiếu
                            chessBoard.cells[2, 0].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
                if (chessBoard.vua_den && chessBoard.xe_den_phai)
                {
                    if (chessBoard.cells[5, 0].Text == "" && chessBoard.cells[6, 0].Text == "" )
                    {
                        if (chessBoard.cells[6, 0].FlatAppearance.BorderColor != Color.Yellow)
                            chessBoard.cells[6, 0].FlatAppearance.BorderColor = Color.Blue;
                    }
                }
            }
        }

        /// <summary>
        /// thực hiện nhập thành
        /// </summary>
        /// <param name="chessBoard"></param>
        static public void ExecuteCastling(ChessBoard chessBoard, int ViTri)
        {
            if (chessBoard.MyTurn)
            {              
                if (ViTri == 2)
                {
                    chessBoard.cells[0, 7].Text = "";
                    chessBoard.cells[0, 7].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[0, 7]);

                    chessBoard.cells[1, 7].Text = "";
                    chessBoard.cells[1, 7].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[1, 7]);

                    chessBoard.cells[2, 7].Text = "king";
                    chessBoard.cells[2, 7].ForeColor = Color.Red;
                    ChessBoard.PictureInsert(chessBoard.cells[2, 7]);

                    chessBoard.cells[3, 7].Text = "rook";
                    chessBoard.cells[3, 7].ForeColor = Color.Red;
                    ChessBoard.PictureInsert(chessBoard.cells[3, 7]);

                    chessBoard.cells[4, 7].Text = "";
                    chessBoard.cells[4, 7].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[4, 7]);
                }
                else if (ViTri == 6)
                {
                    chessBoard.cells[4, 7].Text = "";
                    chessBoard.cells[4, 7].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[4, 7]);

                    chessBoard.cells[5, 7].Text = "rook";
                    chessBoard.cells[5, 7].ForeColor = Color.Red;
                    ChessBoard.PictureInsert(chessBoard.cells[5, 7]);

                    chessBoard.cells[6, 7].Text = "king";
                    chessBoard.cells[6, 7].ForeColor = Color.Red;
                    ChessBoard.PictureInsert(chessBoard.cells[6, 7]);

                    chessBoard.cells[7, 7].Text = "";
                    chessBoard.cells[7, 7].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[7, 7]);
                }
                chessBoard.vua_trang = false; // đã nhập thành
            }                          
            else
            {
                if (ViTri == 2)
                {
                    chessBoard.cells[0, 0].Text = "";
                    chessBoard.cells[0, 0].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[0, 0]);

                    chessBoard.cells[1, 0].Text = "";
                    chessBoard.cells[1, 0].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[1, 0]);

                    chessBoard.cells[2, 0].Text = "king";
                    chessBoard.cells[2, 0].ForeColor = Color.Black;
                    ChessBoard.PictureInsert(chessBoard.cells[2, 0]);

                    chessBoard.cells[3, 0].Text = "rook";
                    chessBoard.cells[3, 0].ForeColor = Color.Black;
                    ChessBoard.PictureInsert(chessBoard.cells[3, 0]);

                    chessBoard.cells[4, 0].Text = "";
                    chessBoard.cells[4, 0].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[4, 0]);
                }
                else if (ViTri == 6)
                {
                    chessBoard.cells[4, 0].Text = "";
                    chessBoard.cells[4, 0].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[4, 0]);

                    chessBoard.cells[5, 0].Text = "rook";
                    chessBoard.cells[5, 0].ForeColor = Color.Black;
                    ChessBoard.PictureInsert(chessBoard.cells[5, 0]);

                    chessBoard.cells[6, 0].Text = "king";
                    chessBoard.cells[6, 0].ForeColor = Color.Black;
                    ChessBoard.PictureInsert(chessBoard.cells[6, 0]);

                    chessBoard.cells[7, 0].Text = "";
                    chessBoard.cells[7, 0].ForeColor = Color.AliceBlue;
                    ChessBoard.PictureInsert(chessBoard.cells[7, 0]);
                }
                chessBoard.vua_den = false; // đã nhập thành
            }
        }
    }
}
