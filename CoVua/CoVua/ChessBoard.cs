using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoVua
{
    class ChessBoard : Panel
    {
        private Button cellPre;
        private bool ReadytoAttack = false;
        private bool MyTurn = true;

        public Button[,] cells { get; set; }
        public int widthCell { get; }
        public int heightCell { get; }
        public ChessBoard()
        {
            cells = new Button[8, 8];
            widthCell = 65;
            heightCell = 65;

            Size = new Size(widthCell * 8, Height * 8);
            Location = new Point(90,24);                             

           //------------Tạo 64 ô cờ----------------------
            for (int i = 0; i < cells.GetLength(0); i++) 
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Button();
                    cells[i, j].Width = widthCell;
                    cells[i, j].Height = heightCell;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].Location = new Point(i * widthCell, j * heightCell);
                    if ((i + j) % 2 == 1)
                        cells[i, j].BackColor = Color.FromArgb(169, 169, 169);
                    
                    cells[i, j].Click += Cell_Click;
                                       
                    this.Controls.Add(cells[i, j]);
                }
            }

           //---------------Thêm Các Quân Cờ------------------
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (j == 0 || j == 7) 
                    {
                        switch (i)
                        {
                            case 0:
                                cells[i, j].Text = "rook";
                                break;
                            case 1:
                                cells[i, j].Text = "knight";
                                break;
                            case 2:
                                cells[i, j].Text = "bishop";
                                break;
                            case 3:
                                cells[i, j].Text = "queen";
                                break;
                            case 4:
                                cells[i, j].Text = "king";
                                break;
                            case 5:
                                cells[i, j].Text = "bishop";
                                break;
                            case 6:
                                cells[i, j].Text = "knight";
                                break;
                            case 7:
                                cells[i, j].Text = "rook";
                                break;
                        }

                        if (j == 0)
                            cells[i, j].ForeColor = Color.Black;
                        else
                            cells[i, j].ForeColor = Color.Red;
                    }
                    else if (j == 1 || j == 6) 
                    {
                        cells[i, j].Text = "pawn";
                        if (j == 1)
                            cells[i, j].ForeColor = Color.Black;
                        else
                            cells[i, j].ForeColor = Color.Red;

                    }                                          
                }
            }

  //          cellPre = cells[4, 4];
        }


/////////////////Xử lý sự kiện khi click vào 1 ô cờ trên bàn cờ//////////////////////////////////////////////////////////////////
        private void Cell_Click(object sender, EventArgs e)
        {

            if(((Button)sender).Text == "") // ko có quân Cờ
            {
                if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)     //di chuyển quân cờ đi vị trí khác
                {
                    ReadytoAttack = false;
                    MyTurn = !MyTurn;
                 //   if (cellPre != null)
                        Chesspiece_Move(cellPre, (Button)sender);                                       
                    cellPre = null;
                    ResetBoderColor();
                }
                else                                                                                 //kick vào ô ko có gì
                {
                    ReadytoAttack = false;
                    ResetBoderColor();               
                }               
            } 
            else
            {
                if (MyTurn)
                {
                    if (((Button)sender).ForeColor == Color.Red) //nhấp vào quân cờ của mình
                    {
                        ReadytoAttack = true;
                        ResetBoderColor();
                        ShowLegalMovement((Button)sender);
                        cellPre = (Button)sender;
                    }
                    else if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)// ăn quân cờ đối thủ
                    {
                        //   if (cellPre != null)
                        Chesspiece_Attack(cellPre, (Button)sender);
                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        ResetBoderColor();
                        ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                        cellPre = null;
                    }
                    else ResetBoderColor();

                } 
                else
                {
                    if(((Button)sender).ForeColor == Color.Black) 
                    {
                        ReadytoAttack = true;
                        ResetBoderColor();
                        ShowLegalMovement((Button)sender);
                        cellPre = (Button)sender;
                    }
                    else if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)
                    {
                        //   if (cellPre != null)
                        Chesspiece_Attack(cellPre, (Button)sender);
                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        ResetBoderColor();
                        ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                        cellPre = null;
                    }
                    else ResetBoderColor();
                }    
                
            }

        }
        //////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Xóa Các Nước đi Hợp Lệ Của Quân Cờ.
        /// </summary>
        private void ResetBoderColor()
        {
            foreach (Button item in cells)
            {
                item.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void Chesspiece_Move(Button Source, Button Destination)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.Black;

            Destination.FlatAppearance.BorderColor = Color.Blue;
        }

        private void Chesspiece_Attack(Button Source, Button Destination)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.Black;

            Destination.FlatAppearance.BorderColor = Color.Blue;
        }

        /// <summary>
        /// Hiển thị các nước đi hợp lệ của quân cờ.
        /// </summary>
        /// <param name="btn"></param>
        private void ShowLegalMovement(Button chessman)
        {
            if (chessman.Text == "pawn")
            {
                if (MyTurn)
                {
                    Pawn.goUp(chessman, cells);
                    Pawn.attackDiagonally(chessman, cells);
                }
                else
                {
                    Pawn.goUpforNeibor(chessman, cells);
                    Pawn.attackDiagonallyforNeibor(chessman, cells);
                }
            }
            else
                switch (chessman.Text)
                {
                    case "knight":
                        Knight.Move(chessman, cells);
                        break;
                    case "bishop":
                        Bishop.Move(chessman, cells);
                        break;
                    case "rook":
                        Rook.Move(chessman, cells);
                        break;
                    case "queen":
                        Queen.Move(chessman, cells);
                        break;
                    case "king":
                        King.Move(chessman, cells);
                        break;
                    default:
                        break;
                }

            //if (MyTurn)
            //    switch (chessman.Text)
            //    {
            //        case "pawn":
            //            Pawn.goUp(chessman, cells);
            //            Pawn.attackDiagonally(chessman, cells);
            //            break;
            //        case "knight":
            //            Knight.Move(chessman, cells);
            //            break;
            //        default:
            //            break;
            //    }
            //else
            //    switch (chessman.Text)
            //    {
            //        case "pawn":
            //            Pawn.goUpforNeibor(chessman, cells);
            //            Pawn.attackDiagonallyforNeibor(chessman, cells);
            //            break;
            //        case "knight":
            //            Knight.Move(chessman, cells);
            //            break;
            //        default:
            //            break;
            //    }

        }
    }
}
