using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace CoVua
{
    public struct MovementInfo
    {
        internal Point Src;
        internal Point Dst;
        internal string srcText;
        internal string dstText;
    }

    public class ChessBoard : Panel
    {

        public bool vua_trang;
        public bool vua_den;
        public bool xe_trang_trai;
        public bool xe_trang_phai;
        public bool xe_den_trai;
        public bool xe_den_phai;
        /// <summary>
        /// vị trí tốt cần phong cấp (X)
        /// </summary>
        public int promotionPawn;  

        private Button cellIsActivating;
        private bool ReadytoAttack;
        internal Button assassin; // Quân cờ đang chiếu

        /// <summary>
        /// vua đang bị chiếu
        /// </summary>
        internal Button king;
        public bool checkMate;  // bàn cờ trong trạng thái chiếu
        public bool Active = true; // chesboard
        public bool MyTurn;
        internal int HinhThucChoi { get; set; }
        public Button[,] cells { get; }
        public List<MovementInfo> movementInfos { get; }
        public int widthCell { get; }
        public int heightCell { get; }
        public ChessBoard()
        {
            vua_trang = true;
            vua_den = true;
            xe_trang_trai = true;
            xe_trang_phai = true;
            xe_den_trai = true;
            xe_den_phai = true;
            promotionPawn = -1;

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
                    cells[i, j].MouseMove += ChessBoard_MouseMove;
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
                    Chesspiece_Move(cellIsActivating, sender, this);
                    MyTurn = !MyTurn;
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

        private void HinhThucChoi2test(Button sender, EventArgs e)
        {
            if (!MyTurn)
                return;

            if (((Button)sender).Text == "") // ko có quân Cờ
            {
                if (ReadytoAttack && ((Button)sender).FlatAppearance.BorderColor == Color.Blue)     //di chuyển quân cờ đi vị trí khác
                {
                    ReadytoAttack = false;
                    //   if (cellIsActivating != null)
                    Chesspiece_Move(cellIsActivating, (Button)sender, this);
                    cellIsActivating = null;
                    ResetBoderColor(this);
                    checkMate = CheckMate(this);
                    if (checkMate) showCheckMate(assassin, king);
                    MyTurn = !MyTurn;

                }
                else
                {
                    ResetBoderColor(this);
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
                    ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                    cellIsActivating = null;
                    // ResetBoderColor(this);
                    checkMate = CheckMate(this);
                    if (checkMate) showCheckMate(assassin, king);

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
            //xử lý nhập thành____________________________________________________________________
            if (chessBoard.MyTurn && chessBoard.vua_trang)
            {
                if (Source.Text == "king" && (Destination.Location.X / chessBoard.widthCell == 2 || Destination.Location.X / chessBoard.widthCell == 6))
                {
                    King.ExecuteCastling(chessBoard, Destination.Location.X / chessBoard.widthCell);
                    return;
                }
            }
            else if (!chessBoard.MyTurn && chessBoard.vua_den)
            {
                if (Source.Text == "king" && (Destination.Location.X / chessBoard.widthCell == 2 || Destination.Location.X / chessBoard.widthCell == 6))
                {
                    King.ExecuteCastling(chessBoard, Destination.Location.X / chessBoard.widthCell);
                    return;
                }
            }
            if (Source.Text == "rook" || Source.Text == "king")
                chessBoard.updateCastling(Source);
            //_______________________________________________________________________________________


            //thực hiện di chuyển
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.AliceBlue;

            chessBoard.movementInfos.Add(chessBoard.saveMovementInfor(Source, Destination));
            Destination.FlatAppearance.BorderColor = Color.Blue;



            //xử lý phong cấp tốt_________________________________________________________________________
            if (Destination.Text == "pawn")
            {
                if(chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn) // đánh với máy
                {
                    int indexY = Destination.Location.Y / Destination.Size.Height;
                    if (/*indexY == 0 ||*/ indexY == 7)
                    {
                        Destination.Text = "queen";
                    }                   
                } 
                else
                {
                    int indexY = Destination.Location.Y / Destination.Size.Height;
                    if (indexY == 0 || indexY == 7)
                    {
                        int indexX = Destination.Location.X / Destination.Size.Width;
                        chessBoard.promotionPawn = indexX;
                        new PromotionPawn(chessBoard).ShowDialog();
                        chessBoard.promotionPawn = -1;
                    }
                }         
            }
            //__________________________________________________________________________________________

            PictureInsert(Source);
            PictureInsert(Destination);

        }

        static public void Chesspiece_Move_forForwarding(Button Source, Button Destination, ChessBoard chessBoard)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.AliceBlue;
        }

        private void Chesspiece_Attack(Button Source, Button Destination, ChessBoard chessBoard)
        {
            Destination.Text = Source.Text;
            Destination.ForeColor = Source.ForeColor;
            Source.Text = "";
            Source.ForeColor = Color.AliceBlue;

            chessBoard.movementInfos.Add(saveMovementInfor(Source, Destination));
            Destination.FlatAppearance.BorderColor = Color.Blue;

            //xử lý phong cấp tốt_________________________________________________________________________
            if (Destination.Text == "pawn")
            {
                if (chessBoard.HinhThucChoi == 2 && !chessBoard.MyTurn) // đánh với máy
                {
                    int indexY = Destination.Location.Y / Destination.Size.Height;
                    if (/*indexY == 0 ||*/ indexY == 7)
                    {
                        Destination.Text = "queen";
                    }
                }
                else
                {
                    int indexY = Destination.Location.Y / Destination.Size.Height;
                    if (indexY == 0 || indexY == 7)
                    {
                        int indexX = Destination.Location.X / Destination.Size.Width;
                        chessBoard.promotionPawn = indexX;
                        new PromotionPawn(chessBoard).ShowDialog();
                        chessBoard.promotionPawn = -1;
                    }
                }
            }
            //__________________________________________________________________________________________

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
        /// Hiển thị tất cả các vị trí tấn công của quân cờ
        /// </summary>
        /// <param name="chessman"></param>
        /// <param name="chessBoard"></param>
        static public void ShowMovement(Button chessman, ChessBoard chessBoard)
        {
            if (chessman.Text == "pawn")
            {
                if (chessman.ForeColor == Color.Red)
                {
                    Pawn.Movecm(chessman, chessBoard);
                }
                else
                {
                    Pawn.MovefoNeiBorcm(chessman, chessBoard);
                }
            }
            else
                switch (chessman.Text)
                {
                    case "knight":
                        Knight.Movecm(chessman, chessBoard);
                        break;
                    case "bishop":
                        Bishop.Movecm(chessman, chessBoard);
                        break;
                    case "rook":
                        Rook.Movecm(chessman, chessBoard);
                        break;
                    case "queen":
                        Queen.Movecm(chessman, chessBoard);
                        break;
                    case "king":
                        King.Movecm(chessman, chessBoard);
                        break;
                    default:
                        break;
                }
        }

        /// <summary>
        /// hiển thị nước đi dành cho quân cờ đang chặn đường chiếu.
        /// </summary>
        /// <param name="chessman"></param>
        /// <param name="chessBoard"></param>
        static public void ShowGuardMovement(Button chessman, ChessBoard chessBoard)
        {
            if (chessman.Text == "pawn")
            {
                if (chessman.ForeColor == Color.Red)
                {
                    Pawn.MoveGuard(chessman, chessBoard);
                }
                else
                {
                    Pawn.MoveGuardfoNeiBor(chessman, chessBoard);
                }
            }
            else
                switch (chessman.Text)
                {
                    case "knight":
                        Knight.MoveGuard(chessman, chessBoard);
                        break;
                    case "bishop":
                        Bishop.MoveGuard(chessman, chessBoard);
                        break;
                    case "rook":
                        Rook.MoveGuard(chessman, chessBoard);
                        break;
                    case "queen":
                        Queen.MoveGuard(chessman, chessBoard);
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

            ChessBoard.Chesspiece_Move_forForwarding(SourceClone, DestinationClone, Board);
            ChessBoard.ResetBoderColor(Board);
            Color x;
            if (Source.ForeColor == Color.Black)     // Máy nhìn trước 
                x = Color.Red;
            else x = Color.Black;

            foreach (Button item in Board.cells)
            {
                if (item.ForeColor == x)
                    ChessBoard.ShowMovement(item, Board);
            }
            return Board;
        }

        internal MovementInfo saveMovementInfor(Button src, Button dst)
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
                if (item.Text != "" && item.ForeColor == Color.Black)  //Đối thủ(máy) chiếu. item là assassin, item2 là king.
                {
                    ResetBoderColor(x);
                    ShowMovement(item, x);

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
                    ShowMovement(item, x);

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

        /// <summary>
        /// Quân cờ đang chặn đường chiếu của đối thủ? 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="Dst"></param>
        /// <returns></returns>
        internal bool Guard(Button Chessman)
        {

            // lưu lại quân cờ xong xuôi thì xóa nó.
            Button saveChessman = new Button();
            saveChessman.Text = Chessman.Text;
            saveChessman.ForeColor = Chessman.ForeColor;
            Chessman.Text = "";
            Chessman.ForeColor = Color.AliceBlue;

            checkMate = CheckMate(this);
            if (checkMate)
            {
                if (assassin.ForeColor == saveChessman.ForeColor)
                {
                    Chessman.Text = saveChessman.Text;
                    Chessman.ForeColor = saveChessman.ForeColor;
                    checkMate = false;
                    assassin = null;
                    king = null;
                    return false;
                }
                else
                {
                    if (checkMate) showCheckMate(assassin, king);

                    Chessman.Text = saveChessman.Text;
                    Chessman.ForeColor = saveChessman.ForeColor;

                    ShowGuardMovement(Chessman, this);
                    checkMate = false;
                    assassin = null;
                    king = null;
                    return true;
                }

                
            }
            else
            {
                Chessman.Text = saveChessman.Text;
                Chessman.ForeColor = saveChessman.ForeColor;
                return false;
            }
        }

        /// <summary>
        /// hiển thị đường chiếu
        /// </summary>
        /// <param name="assassin"></param>
        /// <param name="king"></param>
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

        private void updateCastling(Button chesspiece)
        {
            if (chesspiece.Location.Y / chesspiece.Height == 0)
            {
                switch (chesspiece.Location.X / chesspiece.Width)
                {
                    case 0:
                        xe_den_trai = false;
                        break;
                    case 4:
                        vua_den = false;
                        break;
                    case 7:
                        xe_den_phai = false;
                        break;
                    default:
                        break;
                }
            }
            else if (chesspiece.Location.Y / chesspiece.Height == 7)
            {
                switch (chesspiece.Location.X / chesspiece.Width)
                {
                    case 0:
                        xe_trang_trai = false;
                        break;
                    case 4:
                        vua_trang = false;
                        break;
                    case 7:
                        xe_trang_phai = false;
                        break;
                    default:
                        break;
                }
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

            //movementInfo = new MovementInfo();
            movementInfo = saveMovementInfor(cells[SourceIndexX, SourceIndexY], cells[DestinationIndexX, DestinationIndexY]);
            movementInfos.RemoveAt(movementInfos.Count - 1);
            return movementInfo;
        }

        private void Cell_Click(object sender, EventArgs e)
        {

            if (!Active) return;

            if (HinhThucChoi == 1)
                HinhThucChoi1((Button)sender, e);
            else
            {
                if (MyTurn)
                {
                    HinhThucChoi2test((Button)sender, e);
                }

            }
        }

        private void ChessBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MyTurn && HinhThucChoi == 2)
            {
                Computer.Move(this);
                checkMate = CheckMate(this);
                if (checkMate) showCheckMate(assassin, king);
                MyTurn = !MyTurn;
            }
            //Promotion();
        }

        static internal void PictureInsert(Button sender)
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
            else b.Image = null;
        }

        //static private void Promotion(Button Pawn, ChessBoard chessBoard)
        //{
        //    int indexX = Pawn.Location.X / Pawn.Size.Width;
        //    int indexY = Pawn.Location.Y / Pawn.Size.Height;
        //    if (indexY == 1 || indexY == 1)
        //    {
        //        chessBoard.promotionPawn = indexX;
        //        new PromotionPawn(chessBoard).ShowDialog();
        //    }

        //    chessBoard.promotionPawn = -1;
        //}
    }
}
