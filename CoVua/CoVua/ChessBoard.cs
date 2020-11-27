using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoVua
{
    struct MovementInfo
    {
        internal Point Src;
        internal Point Dst;
        internal string srcText;
        internal string dstText;
    }

    class ChessBoard : Panel
    {
        private Button cellIsActivating;
        private bool ReadytoAttack;
        internal Button assassin; // Quân cờ đang chiếu

        /// <summary>
        /// vua đang bị chiếu
        /// </summary>
        internal Button king;
        public bool checkMate;  // bàn cờ trong trạng thái chiếu
        public bool Active { get; set; } = true; // chesboard
        public bool MyTurn { get; set; }
        public int HinhThucChoi { get; set; }
        public Button[,] cells { get; set; }
        public List<MovementInfo> movementInfos;
        public int widthCell { get; }
        public int heightCell { get; }
        public ChessBoard()
        {
            ReadytoAttack = false;
            assassin = null;
            king = null;
            checkMate = false;
            MyTurn = true;
            HinhThucChoi = 2; // đánh với máy

            movementInfos = new List<MovementInfo>();
            cells = new Button[8, 8];
            widthCell = 65;
            heightCell = 65;

            Size = new Size(widthCell * 8, Height * 8);
            Location = new Point(90, 24);

            //------------Tạo 64 ô cờ----------------------
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    Button x = new Button();
                    cells[i, j] = new Button();
                    cells[i, j].Width = widthCell;
                    cells[i, j].Height = heightCell;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].Location = new Point(i * widthCell, j * heightCell);
                    if ((i + j) % 2 == 1)
                        cells[i, j].BackColor = Color.FromArgb(169, 169, 169);

                    cells[i, j].Click += Cell_Click;
                    //cells[i, j].TextImageRelation = TextImageRelation.Overlay;
                    cells[i, j].Font = new Font("Arial", 1);
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
                    PictureInsert(cells[i, j]);

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
                    Chesspiece_Move(cellIsActivating, sender, this);
                    ResetBoderColor(this);

                    checkMate = CheckMate(this);
                    if (checkMate) showCheckMate(assassin, king);

                    cellIsActivating = null;

                }
                else
                {
                    ReadytoAttack = false;
                    ResetBoderColor(this);

                    if (checkMate) showCheckMate(assassin, king);
                }
            }
            else
            {
                if (MyTurn)
                {
                    if ((sender).ForeColor == Color.Red) //nhấp vào quân cờ của mình
                    {
                        ReadytoAttack = true;
                        ResetBoderColor(this);
                        if (checkMate) showCheckMate(assassin, king);

                        ShowLegalMovement(sender, this);
                        cellIsActivating = sender;
                    }
                    else if (ReadytoAttack && (sender).FlatAppearance.BorderColor == Color.Blue)// ăn quân cờ đối thủ
                    {
                        Chesspiece_Attack(cellIsActivating, sender, this);
                        ResetBoderColor(this);
                        checkMate = CheckMate(this);
                        if (checkMate) showCheckMate(assassin, king);

                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        (sender).FlatAppearance.BorderColor = Color.Blue;
                        cellIsActivating = null;
                    }
                    else
                    {
                        if (checkMate) showCheckMate(assassin, king);
                    }


                }
                else
                {
                    if ((sender).ForeColor == Color.Black)
                    {
                        ReadytoAttack = true;
                        ResetBoderColor(this);
                        if (checkMate) showCheckMate(assassin, king);

                        ShowLegalMovement(sender, this);
                        cellIsActivating = sender;
                    }
                    else if (ReadytoAttack && (sender).FlatAppearance.BorderColor == Color.Blue)
                    {
                        Chesspiece_Attack(cellIsActivating, sender, this);
                        ResetBoderColor(this);
                        checkMate = CheckMate(this);
                        if (checkMate) showCheckMate(assassin, king);

                        ReadytoAttack = false;
                        MyTurn = !MyTurn;
                        (sender).FlatAppearance.BorderColor = Color.Blue;
                        cellIsActivating = null;
                    }
                    else ResetBoderColor(this);
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
                    //   if (cellIsActivating != null)
                    Chesspiece_Move(cellIsActivating, (Button)sender, this);
                    cellIsActivating = null;

                    ResetBoderColor(this);
                    Computer.Move(this);
                    checkMate = CheckMate(this);
                    if (checkMate) showCheckMate(assassin, king);

                    MyTurn = !MyTurn;
                }
                else
                {
                    ReadytoAttack = false;
                    if (checkMate) showCheckMate(assassin, king);
                }
            }
            else
            {
                if (((Button)sender).ForeColor == Color.Red) //nhấp vào quân cờ của mình
                {
                    ReadytoAttack = true;
                    ResetBoderColor(this);
                    if (checkMate) showCheckMate(assassin, king);
                    ShowLegalMovement((Button)sender, this);
                    cellIsActivating = (Button)sender;
                }
                else if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)// ăn quân cờ đối thủ
                {
                    //   if (cellIsActivating != null)
                    Chesspiece_Attack(cellIsActivating, (Button)sender, this);

                    ReadytoAttack = false;
                    MyTurn = !MyTurn;
                    ResetBoderColor(this);
                    ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                    cellIsActivating = null;

                    ResetBoderColor(this);
                    Computer.Move(this);
                    checkMate = CheckMate(this);
                    if (checkMate) showCheckMate(assassin, king);

                    MyTurn = !MyTurn;
                }
                else ResetBoderColor(this);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Xóa Các Nước đi Hợp Lệ Của Quân Cờ.
        /// </summary>
        static public void ResetBoderColor(ChessBoard chessBoard)
        {
            foreach (Button item in chessBoard.cells)
            {
                item.FlatAppearance.BorderColor = Color.Black;
            }
        }

        static public void Chesspiece_Move(Button Source, Button Destination, ChessBoard chessBoard)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.Black;

            chessBoard.movementInfos.Add(chessBoard.save(Source, Destination));
            Destination.FlatAppearance.BorderColor = Color.Blue;

            PictureInsert(Source);
            PictureInsert(Destination);
        }

        private void Chesspiece_Attack(Button Source, Button Destination, ChessBoard chessBoard)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.Black;

            chessBoard.movementInfos.Add(save(Source, Destination));
            Destination.FlatAppearance.BorderColor = Color.Blue;

            PictureInsert(Source);
            PictureInsert(Destination);
        }

        /// <summary>
        /// Hiển thị các nước đi hợp lệ của quân cờ.
        /// </summary>
        /// <param name="btn"></param>
        static public void ShowLegalMovement(Button chessman, ChessBoard chessBoard)
        {
            if (chessman.Text == "pawn")
            {
                if (chessman.ForeColor == Color.Red)
                {
                    Pawn.Move(chessman, chessBoard);
                }
                else
                {
                    Pawn.MovefoNeiBor(chessman, chessBoard);
                }
            }
            else
                switch (chessman.Text)
                {
                    case "knight":
                        Knight.Move(chessman, chessBoard);
                        break;
                    case "bishop":
                        Bishop.Move(chessman, chessBoard);
                        break;
                    case "rook":
                        Rook.Move(chessman, chessBoard);
                        break;
                    case "queen":
                        Queen.Move(chessman, chessBoard);
                        break;
                    case "king":
                        King.Move(chessman, chessBoard);
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
        static internal ChessBoard CloneButtonsInfo(ChessBoard chessBoard)
        {
            ChessBoard Board = new ChessBoard();
            for (int i = 0; i < chessBoard.cells.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.cells.GetLength(1); j++)
                {
                    Board.cells[i, j] = new Button();
                    Board.cells[i, j].FlatAppearance.BorderColor = chessBoard.cells[i, j].FlatAppearance.BorderColor;
                    Board.cells[i, j].ForeColor = chessBoard.cells[i, j].ForeColor;
                    Board.cells[i, j].Text = chessBoard.cells[i, j].Text;
                    Board.cells[i, j].Location = new Point(i * chessBoard.cells[0, 0].Width, j * chessBoard.cells[0, 0].Width);
                    Board.cells[i, j].Width = chessBoard.cells[i, j].Size.Width;
                    Board.cells[i, j].Height = chessBoard.cells[i, j].Height;
                }
            }
            return Board;
        }

        /// <summary>
        /// nhìn trước các nước có thể đi của bên còn lại Khi di chuyển 1 quân cờ
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        static internal ChessBoard Forwarding(Button Source, Button Destination, ChessBoard chessBoard)
        {
            ChessBoard Board = ChessBoard.CloneButtonsInfo(chessBoard);
            Button SourceClone = Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height];
            Button DestinationClone = Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height];

            ChessBoard.Chesspiece_Move(SourceClone, DestinationClone, Board);
            ChessBoard.ResetBoderColor(Board);
            Color x;
            if (Source.ForeColor == Color.Black)     // Máy nhìn trước 
                x = Color.Red;
            else x = Color.Black;

            foreach (Button item in Board.cells)
            {
                if (item.ForeColor == x)
                    ChessBoard.ShowLegalMovement(item, Board);
            }
            return Board;
        }

        internal MovementInfo save(Button src, Button dst)
        {
            MovementInfo x = new MovementInfo();
            x.Dst = dst.Location;
            x.dstText = dst.Text;
            x.srcText = src.Text;
            x.Src = src.Location;

            return x;
        }

        /// <summary>
        /// mình hoặc đối thủ đang bị chiếu ?
        /// </summary>
        /// <param name="chessBoard"></param>
        /// <returns></returns>
        internal bool CheckMate(ChessBoard chessBoard)
        {
            ChessBoard x = CloneButtonsInfo(chessBoard);
            foreach (Button item in x.cells)
            {
                if (item.Text != "" && item.ForeColor == Color.Black)  //Đối thủ chiếu. item là assassin, item2 là king.
                {
                    ResetBoderColor(x);
                    ShowLegalMovement(item, x);

                    foreach (Button item2 in x.cells)
                    {
                        if (item2.Text == "king" && item2.ForeColor == Color.Red && item2.FlatAppearance.BorderColor == Color.Blue)
                        {
                            chessBoard.assassin = chessBoard.cells[item.Location.X / chessBoard.widthCell, item.Location.Y / chessBoard.heightCell];
                            chessBoard.king = chessBoard.cells[item2.Location.X / chessBoard.widthCell, item2.Location.Y / chessBoard.heightCell];

                            return true;
                        }
                    }
                }

                else if (item.Text != "" && item.ForeColor == Color.Red)
                {
                    ResetBoderColor(x);
                    ShowLegalMovement(item, x);

                    foreach (Button item2 in x.cells)
                    {
                        if (item2.Text == "king" && item2.ForeColor == Color.Black && item2.FlatAppearance.BorderColor == Color.Blue)
                        {
                            chessBoard.assassin = chessBoard.cells[item.Location.X / chessBoard.widthCell, item.Location.Y / chessBoard.heightCell];
                            chessBoard.king = chessBoard.cells[item2.Location.X / chessBoard.widthCell, item2.Location.Y / chessBoard.heightCell];

                            return true;
                        }
                    }
                }
            }

            chessBoard.assassin = null;
            chessBoard.king = null;
            return false;
        }

        public void showCheckMate(Button assassin, Button king)
        {
            switch (assassin.Text)
            {
                case "knight":
                    Knight.checkMate(assassin, king, this);
                    break;
                case "bishop":
                    Bishop.checkMate(assassin, king, this);
                    break;
                case "rook":
                    Rook.checkMate(assassin, king, this);
                    break;
                case "queen":
                    Queen.checkMate(assassin, king, this);
                    break;
                case "pawn":
                    Pawn.checkMate(assassin, king, this);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// chưa chạy được!
        /// </summary>
        /// <returns></returns>
        public MovementInfo undo()
        {
            MovementInfo movementInfo = this.movementInfos[this.movementInfos.Count - 1];
            int SourceIndexX = movementInfo.Src.X / this.cells[0, 0].Size.Width;
            int SourceIndexY = movementInfo.Src.Y / this.cells[0, 0].Size.Height;
            int DestinationIndexX = movementInfo.Dst.X / this.cells[0, 0].Size.Width;
            int DestinationIndexY = movementInfo.Dst.Y / this.cells[0, 0].Size.Height;

            this.cells[SourceIndexX, SourceIndexY].Text = movementInfo.dstText;
            this.cells[DestinationIndexX, DestinationIndexY].Text = movementInfo.srcText;
            if (this.movementInfos.Count % 2 == 1) // nếu đây là nước cờ do máy đánh
            {
                this.cells[SourceIndexX, SourceIndexY].ForeColor = Color.Black;
                this.cells[DestinationIndexX, DestinationIndexY].ForeColor = Color.Red;
            }
            else
            {
                this.cells[SourceIndexX, SourceIndexY].ForeColor = Color.Red;
                this.cells[DestinationIndexX, DestinationIndexY].ForeColor = Color.Black;
            }

            movementInfo = new MovementInfo();
            movementInfo = save(cells[SourceIndexX, SourceIndexY], cells[DestinationIndexX, DestinationIndexY]);
            movementInfos.RemoveAt(movementInfos.Count - 1);
            return movementInfo;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (!Active) return;

            if (HinhThucChoi == 1)
                HinhThucChoi1((Button)sender, e);
            else HinhThucChoi2((Button)sender, e);


            //checkMate = CheckMate(this);
            //if (checkMate) showCheckMate(assassin, king);
        }


        static private void PictureInsert(Button sender)
        {


            Button b = (Button)sender;
            if (b.ForeColor == Color.Black)
            {
                switch (b.Text)
                {
                    case "":
                        b.Image = null;
                        break;
                    case "knight":
                        b.Image = Properties.Resources.ngua_den;
                        break;
                    case "pawn":
                        b.Image = Properties.Resources.tot_den;
                        break;
                    case "bishop":
                        b.Image = Properties.Resources.tuong_den;
                        break;
                    case "queen":
                        b.Image = Properties.Resources.hau_den;
                        break;
                    case "king":
                        b.Image = Properties.Resources.vua_den;
                        break;
                    case "rook":
                        b.Image = Properties.Resources.xe_den;
                        break;
                }
            }
            else if (b.ForeColor == Color.Red)
            {
                switch (b.Text)
                {
                    case "":
                        b.Image = null;
                        break;
                    case "knight":
                        b.Image = Properties.Resources.ngua_trang;
                        break;
                    case "pawn":
                        b.Image = Properties.Resources.tot_trang;
                        break;
                    case "bishop":
                        b.Image = Properties.Resources.tuong_trang_ne;
                        break;
                    case "queen":
                        b.Image = Properties.Resources.hau_trang;
                        break;
                    case "king":
                        b.Image = Properties.Resources.vua_trang;
                        break;
                    case "rook":
                        b.Image = Properties.Resources.xe_trang;
                        break;
                }
            }
        }
    }
}
