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
        private bool ReadytoAttack;
        public bool Active { get; set; } = true;
        public bool MyTurn { get; set; }
        public int HinhThucChoi { get; set; }
        public Button[,] cells { get; set; }
        public int widthCell { get; }
        public int heightCell { get; }
        public ChessBoard()
        {
            ReadytoAttack = false;
            MyTurn = true;
            HinhThucChoi = 2;

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
        }      
        
        /// <summary>
        /// 1 mình đánh 2 bên
        /// </summary>
        private void HinhThucChoi1(Button sender, EventArgs e)
        {
            if ((sender).Text == "") // ko có quân Cờ
            {
                if (ReadytoAttack && (sender).FlatAppearance.BorderColor == Color.Blue)     //di chuyển quân cờ đi vị trí khác
                {
                    ReadytoAttack = false;
                    MyTurn = !MyTurn;
                    Chesspiece_Move(cellPre, sender);
                    cellPre = null;
                    ResetBoderColor(cells);
                }
                else
                {
                    ReadytoAttack = false;
                    ResetBoderColor(cells);
                }
            }
            else
            {
                if (MyTurn)
                {
                    if ((sender).ForeColor == Color.Red) //nhấp vào quân cờ của mình
                    {
                        ReadytoAttack = true;
                        ResetBoderColor(cells);
                        ShowLegalMovement(sender, cells);
                        cellPre = sender;
                    }
                    else if (ReadytoAttack && (sender).FlatAppearance.BorderColor == Color.Blue)// ăn quân cờ đối thủ
                    {
                        Chesspiece_Attack(cellPre, sender);
                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        ResetBoderColor(cells);
                        (sender).FlatAppearance.BorderColor = Color.Blue;
                        cellPre = null;
                    }
                    else ResetBoderColor(cells);

                }
                else
                {
                    if ((sender).ForeColor == Color.Black)
                    {
                        ReadytoAttack = true;
                        ResetBoderColor(cells);
                        ShowLegalMovement(sender, cells);
                        cellPre = sender;
                    }
                    else if (ReadytoAttack && (sender).FlatAppearance.BorderColor == Color.Blue)
                    {
                        Chesspiece_Attack(cellPre, sender);
                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        ResetBoderColor(cells);
                        (sender).FlatAppearance.BorderColor = Color.Blue;
                        cellPre = null;
                    }
                    else ResetBoderColor(cells);
                }
            }
        }
        /// <summary>
        /// Đánh Với Máy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HinhThucChoi2(Button sender, EventArgs e)
        {
            if (((Button)sender).Text == "") // ko có quân Cờ
            {
                if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)     //di chuyển quân cờ đi vị trí khác
                {
                    ReadytoAttack = false;
                    MyTurn = !MyTurn;
                    //   if (cellPre != null)
                    Chesspiece_Move(cellPre, (Button)sender);
                    cellPre = null;

                    ResetBoderColor(cells);
                    Computer.Move(cells);
                    MyTurn = !MyTurn;
                }
                else
                {
                    ReadytoAttack = false;
                    ResetBoderColor(cells);
                }
            }
            else
            {
                if (((Button)sender).ForeColor == Color.Red) //nhấp vào quân cờ của mình
                {
                    ReadytoAttack = true;
                    ResetBoderColor(cells);
                    ShowLegalMovement((Button)sender, cells);
                    cellPre = (Button)sender;
                }
                else if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)// ăn quân cờ đối thủ
                {
                    //   if (cellPre != null)
                    Chesspiece_Attack(cellPre, (Button)sender);
                    ReadytoAttack = false;
                    MyTurn = !MyTurn;
                    ResetBoderColor(cells);
                    ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                    cellPre = null;

                    ResetBoderColor(cells);
                    Computer.Move(cells);
                    MyTurn = !MyTurn;
                }
                else ResetBoderColor(cells);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Xóa Các Nước đi Hợp Lệ Của Quân Cờ.
        /// </summary>
        static public void ResetBoderColor(Button[,] cells)
        {
            foreach (Button item in cells)
            {
                item.FlatAppearance.BorderColor = Color.Black;
            }
        }

        static public void Chesspiece_Move(Button Source, Button Destination)
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
        static public void ShowLegalMovement(Button chessman, Button[,] cells)
        {
            if (chessman.Text == "pawn")
            {
                if (chessman.ForeColor == Color.Red)
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
        }

        /// <summary>
        /// sao chép các ô cờ thành 1 mảng 2 chiều
        /// </summary>
        /// <param name="cells"></param>
        /// <returns></returns>
        static internal Button[,] CloneButtonsInfo(Button[,] cells)
        {
            Button[,] matrix = new Button[8, 8];
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    matrix[i, j] = new Button();
                    matrix[i, j].FlatAppearance.BorderColor = cells[i, j].FlatAppearance.BorderColor;
                    matrix[i, j].ForeColor = cells[i, j].ForeColor;
                    matrix[i, j].Text = cells[i, j].Text;
                }
            }
            return matrix;
        }

        /// <summary>
        /// nhìn trước các nước có thể đi của bên còn  lại Khi di chuyển 1 quân cờ
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        static internal Button[,] Forwarding(Button Source, Button Destination, Button[,] cells)
        {
            Button[,] matrix = ChessBoard.CloneButtonsInfo(cells);
            Button SourceClone = matrix[Source.Location.X / cells[0, 0].Width, Source.Location.Y / cells[0, 0].Height];
            Button DestinationClone = matrix[Destination.Location.X / cells[0, 0].Width, Destination.Location.Y / cells[0, 0].Height];

            ChessBoard.Chesspiece_Move(SourceClone, DestinationClone);
            ChessBoard.ResetBoderColor(matrix);
            Color x;
            if (Source.ForeColor == Color.Black)     // Máy nhìn trước 
                x = Color.Red;
            else x = Color.Black;

            foreach (Button item in matrix)
            {
                if (item.ForeColor == x)
                    ChessBoard.ShowLegalMovement(item, matrix);
            }
            return matrix;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (!Active) return;

            if (HinhThucChoi == 1)
                HinhThucChoi1((Button)sender, e);
            else HinhThucChoi2((Button)sender, e);
        }
    }
}
