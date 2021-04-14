using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVua
{
    struct WorthMovement
    {
        internal Point Source { get; set; }
        internal Point Destination { get; set; }
        internal double value { get; set; }

    }


    class Computer
    {
        static public void Move(ChessBoard chessBoard)
        {

            WorthMovement ComputerMovement = Computer.MovementInfo(chessBoard);
            if (ComputerMovement.Source == null)
                return;

            int SourceIndexX = ComputerMovement.Source.X / chessBoard.cells[0, 0].Size.Width;
            int SourceIndexY = ComputerMovement.Source.Y / chessBoard.cells[0, 0].Size.Height;
            int DestinationIndexX = ComputerMovement.Destination.X / chessBoard.cells[0, 0].Size.Width;
            int DestinationIndexY = ComputerMovement.Destination.Y / chessBoard.cells[0, 0].Size.Height;

            ChessBoard.Chesspiece_Move(chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard.cells[DestinationIndexX, DestinationIndexY], chessBoard);
            chessBoard.checkMate = chessBoard.CheckMate(chessBoard);
            if (chessBoard.checkMate) chessBoard.showCheckMate(chessBoard.assassin, chessBoard.king);
            chessBoard.MyTurn = !chessBoard.MyTurn;
            if (chessBoard.endGame()) { return; }

            chessBoard.cells[SourceIndexX, SourceIndexY].FlatAppearance.BorderColor = Color.Blue;
            chessBoard.cells[DestinationIndexX, DestinationIndexY].FlatAppearance.BorderColor = Color.Blue;
            //chessBoard.movementInfos.Add(chessBoard.saveMovementInfor(chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard.cells[DestinationIndexX, DestinationIndexY]));
        }

        static public WorthMovement MovementInfo(ChessBoard chessBoard)
        {
            chessBoard.checkMate = chessBoard.CheckMate(chessBoard);
            List<WorthMovement> list = new List<WorthMovement>();
            foreach (Button item in chessBoard.cells)
            {
                WorthMovement move = new WorthMovement();
                move.value = -99999;
                if (item.ForeColor == Color.Black && item.Text != "")
                {
                    move.Source = item.Location;

                    ChessBoard.ResetBoderColor(chessBoard);

                    if (chessBoard.checkMate) chessBoard.showCheckMate(chessBoard.assassin, chessBoard.king);
                    ChessBoard.ShowLegalMovement(item, chessBoard);
                    foreach (Button item2 in chessBoard.cells)       //tìm nước đi ngon của quân cờ.
                    {
                        if (item2.FlatAppearance.BorderColor == Color.Blue)
                        {
                            double value = ValuablePosition(item2, chessBoard, item, item.ForeColor)
                                           + WorthChessman2(item2.Text, item) + hazii(item, item2, chessBoard);
                            //if (move.value < value)
                            //{
                                move.value = value;
                                move.Destination = item2.Location;
                            //}
                        }
                    }
                    ChessBoard.ResetBoderColor(chessBoard);
                    if (move.value != -99999)
                        list.Add(move);
                }
            }

            if (list.Count == 0)
            {
                //MessageBox.Show("you win");
                new EndGame(chessBoard).ShowDialog();
                return new WorthMovement();
            }
            WorthMovement movement, movement2;
            movement = movement2 = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].value > movement.value)
                {
                    movement2 = movement;
                    movement = list[i];
                }
            }
            if (movement.value - movement2.value < 5)
            {
                Random rd = new Random();
                int x = rd.Next(1, 3);
                if (x == 1)
                    return movement2;
                else
                    return movement;
            }
            else
                return movement;

        }

        //static public bool Moveok(ChessBoard chessBoard, Button Source, Button Destination)
        //{
        //    List<WorthMovement> Movement = Computer.MovementInfo2(chessBoard, Source, Destination);
        //    foreach (var item in Movement)
        //    {
        //        int SourceIndexX = item.Source.X / chessBoard.cells[0, 0].Size.Width;
        //        int SourceIndexY = item.Source.Y / chessBoard.cells[0, 0].Size.Height;
        //        int DestinationIndexX = item.Destination.X / chessBoard.cells[0, 0].Size.Width;
        //        int DestinationIndexY = item.Destination.Y / chessBoard.cells[0, 0].Size.Height;

        //        Button button = new Button();
        //        button.Text = chessBoard.cells[DestinationIndexX, DestinationIndexY].Text;
        //        button.ForeColor = chessBoard.cells[DestinationIndexX, DestinationIndexY].ForeColor;

        //        ChessBoard.Chesspiece_Move_forForwarding(chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard.cells[DestinationIndexX, DestinationIndexY], chessBoard);
        //        if (endGame(chessBoard))
        //            return true;

        //        ChessBoard.Chesspiece_Move_forForwarding(button, chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard);
        //    }

        //    return false;
        //}

        ///// <summary>
        ///// lưu tất cả nước đi có thể lại
        ///// </summary>
        ///// <param name="chessBoard"></param>
        ///// <returns></returns>
        //static public List<WorthMovement> MovementInfo2(ChessBoard chessBoard, Button source, Button destination)
        //{
        //    Button sourceClone = new Button();
        //    Button destinationClone = new Button();

        //    sourceClone.FlatAppearance.BorderColor = source.FlatAppearance.BorderColor;
        //    sourceClone.ForeColor = source.ForeColor;
        //    sourceClone.Text = source.Text;
        //    sourceClone.Location = new Point(source.Location.X, source.Location.Y);
        //    sourceClone.Width = source.Size.Width;
        //    sourceClone.Height = source.Height;

        //    destinationClone.FlatAppearance.BorderColor = destination.FlatAppearance.BorderColor;
        //    destinationClone.ForeColor = destination.ForeColor;
        //    destinationClone.Text = destination.Text;
        //    destinationClone.Location = new Point(destination.Location.X, destination.Location.Y);
        //    destinationClone.Width = destination.Size.Width;
        //    destinationClone.Height = destination.Height;
        //    ChessBoard.Chesspiece_Move_forForwarding(sourceClone, destination, chessBoard);

        //    chessBoard.checkMate = chessBoard.CheckMate(chessBoard);
        //    List<WorthMovement> list = new List<WorthMovement>();

        //    foreach (Button item in chessBoard.cells)
        //    {
        //        WorthMovement move = new WorthMovement();
        //        move.value = -99999;
        //        if (item.ForeColor == Color.Red && item.Text != "")
        //        {
        //            move.Source = item.Location;

        //            ChessBoard.ResetBoderColor(chessBoard);

        //            if (chessBoard.checkMate) chessBoard.showCheckMate(chessBoard.assassin, chessBoard.king);
        //            ChessBoard.ShowLegalMovement(item, chessBoard);
        //            foreach (Button item2 in chessBoard.cells)      
        //            {
        //                if (item2.FlatAppearance.BorderColor == Color.Blue)
        //                {
        //                    list.Add(move);
        //                }

        //            }
        //            ChessBoard.ResetBoderColor(chessBoard);
        //        }
        //    }

        //    return list;
        //}
        //static private bool endGame(ChessBoard chessBoard)
        // {
        //     foreach (Button item in chessBoard.cells)
        //     {
        //         if (chessBoard.MyTurn)
        //         {
        //             if (item.ForeColor == Color.Red && item.Text != "")
        //             {
        //                 ChessBoard.ShowLegalMovement(item, chessBoard);
        //             }
        //         }
        //         else
        //         {
        //             if (item.ForeColor == Color.Black && item.Text != "")
        //                 ChessBoard.ShowLegalMovement(item, chessBoard);
        //         }

        //         foreach (Button item2 in chessBoard.cells)
        //         {
        //             if (item2.FlatAppearance.BorderColor == Color.Blue)
        //             {
        //                 ChessBoard.ResetBoderColor(chessBoard);
        //                 return false;
        //             }

        //         }
        //     }
        //     return true;
        // }

        static private double area(ChessBoard chessBoard, Color color)
        {
            ChessBoard.ResetBoderColor(chessBoard);
            double value = 0;
            foreach (Button item in chessBoard.cells)
            {
                if (item.ForeColor == Color.Black)
                    ChessBoard.ShowMovement(item, chessBoard);
            }

            foreach (Button item in chessBoard.cells)
            {
                if (item.FlatAppearance.BorderColor == Color.Blue)
                {
                    value += 0.3 + WorthChessman(item.Text) / 150.0;
                }
            }
            ChessBoard.ResetBoderColor(chessBoard);

            return value;
        }

        static private double ValuablePosition(Button item2, ChessBoard chessBoard, Button item, Color color)
        {
            int x2 = item2.Location.X / chessBoard.widthCell;
            int y2 = item2.Location.Y / chessBoard.heightCell;

            //int x = item.Location.X / chessBoard.cells[0, 0].Size.Width;
            //int y = item.Location.Y / chessBoard.cells[0, 0].Size.Height;
            if (color == Color.Black)
            {
                x2 = 7 - x2;
                y2 = 7 - y2;

                //x = 7 - x;
                //y = 7 - y;
            }
            switch (item.Text)
            {
                case "king":
                    return /*-Computer.kingPosition[x, y] + */Computer.kingPosition[y2, x2];
                case "pawn":
                    return /*-Computer.pawnPosition[x, y] +*/ Computer.pawnPosition[y2, x2];
                case "knight":
                    return /*-Computer.knightPosition[x, y] +*/ Computer.knightPosition[y2, x2];
                case "bishop":
                    return /*-Computer.bishopPosition[x, y] + */Computer.bishopPosition[y2, x2];
                case "rook":
                    return /*-Computer.rookPosition[x, y] +*/ Computer.rookPosition[y2, x2];
                case "queen":
                    return /*-Computer.queenPosition[x, y] +*/ Computer.queenPosition[y2, x2];
                default:
                    return 0;
            }
        }

        /// <summary>
        /// trả về giá trị của một quân cờ.
        /// </summary>
        /// <param name="chessman"></param>
        /// <returns></returns>
        static private int WorthChessman2(string chessman, Button source)
        {
            if (source.Text == "king")
                switch (chessman)
                {
                    case "king":
                        return 200;
                    case "pawn":
                        return 9;
                    case "knight":
                        return 25;
                    case "bishop":
                        return 25;
                    case "rook":
                        return 42;
                    case "queen":
                        return 80;
                    default:
                        return 0;
                }

            switch (chessman)
            {
                case "king":
                    return 200;
                case "pawn":
                    return 10;
                case "knight":
                    return 30;
                case "bishop":
                    return 30;
                case "rook":
                    return 50;
                case "queen":
                    return 90;
                default:
                    return 0;
            }
        }

        static private int WorthChessman(string chessman)
        {
            switch (chessman)
            {
                case "king":
                    return 200;
                case "pawn":
                    return 10;
                case "knight":
                    return 30;
                case "bishop":
                    return 30;
                case "rook":
                    return 50;
                case "queen":
                    return 90;
                default:
                    return 0;
            }
        }

        static private double hazii(Button Source, Button Destination, ChessBoard chessBoard)
        {
            //ChessBoard Board = CloneButtonsInfo(chessBoard);
            //Button SourceClone = Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height];
            //Button DestinationClone = Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height];
            ChessBoard Board = Forwarding(Source, Destination, chessBoard);
            ChessBoard Board2 = Forwarding2(Source, Destination, chessBoard);

            double value = 0;
            //if (Source.Text == "king")
            //    return -9999;

            if (Source.Text == "king"
                && Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                return value += -888;   /////
            else
            if (Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
            {
                //if (Board2.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                //{
                //    switch (Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].Text)
                //    {
                //        case "king":
                //            value = 900;
                //            break;
                //        case "pawn":
                //            value = 0.5;
                //            break;
                //        case "knight":
                //            value = 22;
                //            break;
                //        case "bishop":
                //            value = 22;
                //            break;
                //        case "rook":
                //            value = 35;
                //            break;
                //        case "queen":
                //            value = 70;
                //            break;
                //    }
                //}
                //else
                value += WorthChessman(Source.Text) * 4.0 / 5;
            }


            //_________________________________________
            if (Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
            {
                if (Board2.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                {
                    switch (Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].Text)
                    {
                        case "king":
                            value -= 900;
                            break;
                        case "pawn":
                            break;
                        case "knight":
                            value -= 22;
                            break;
                        case "bishop":
                            value -= 22;
                            break;
                        case "rook":
                            value -= 35;
                            break;
                        case "queen":
                            value -= 70;
                            break;
                    }
                }
                else
                    value -= WorthChessman(Source.Text);
            }

            value += area(Board, Color.Black) - area(Board2, Color.Red);

            return value;
        }

        //static private int hazii2(Button Source, Button Destination, ChessBoard chessBoard)
        //{
        //    ChessBoard Board = ChessBoard.Forwarding(Source, Destination, chessBoard);

        //    int value = 0;
        //    //if (Source.Text == "king")
        //    //    return -9999;

        //    //if (Source.Text == "king"
        //    //    && Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
        //    //    return -99999;   /////
        //    //else
        //    if (Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
        //        value += WorthChessman(Source.Text) * 4 / 5;

        //    if (Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
        //        value -= WorthChessman(Source.Text);


        //    return value;
        //}

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
            ChessBoard Board = CloneButtonsInfo(chessBoard);
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
        static internal ChessBoard Forwarding3(Button SourceClone, Button DestinationClone, ChessBoard chessBoardClone, Color color)
        {

            ChessBoard.Chesspiece_Move_forForwarding(SourceClone, DestinationClone, chessBoardClone);
            ChessBoard.ResetBoderColor(chessBoardClone);

            foreach (Button item in chessBoardClone.cells)
            {
                if (item.ForeColor == color)
                    ChessBoard.ShowMovement(item, chessBoardClone);
            }
            return chessBoardClone;
        }

        static internal ChessBoard Forwarding2(Button Source, Button Destination, ChessBoard chessBoard)
        {
            ChessBoard Board = CloneButtonsInfo(chessBoard);
            Button SourceClone = Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height];
            Button DestinationClone = Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height];

            ChessBoard.Chesspiece_Move_forForwarding(SourceClone, DestinationClone, Board);
            ChessBoard.ResetBoderColor(Board);
            foreach (Button item in Board.cells)
            {
                if (item.ForeColor == Color.Black)
                    ChessBoard.ShowMovement(item, Board);
            }
            return Board;
        }

        static double[,] kingPosition =
        {
            {-3, -4, -4, -5, -5, -4, -4, -3 },
            {-3, -4, -4, -5, -5, -4, -4, -3 },
            {-3, -4, -4, -5, -5, -4, -4, -3 },
            {-3, -4, -4, -5, -5, -4, -4, -3 },
            {-2, -3, -3, -4, -4, -3, -3, -2 },
            {-1, -2, -2, -4, -4, -3, -2, -1 },
            { 2,  2,  0,  0,  0,  0,  0,  0 },
            { 0,  3,  0,  0,  0,  0,  3,  0 }
        };

        static double[,] queenPosition =
        {
            {  -2,  -1,  -1, -0.5, -0.5,  -1, -1,   -2 },
            {  -1,   0,   0,    0,    0,   0,  0,   -1 },
            {  -1,   0, 0.5,  0.5,  0.5, 0.5,  0,   -1 },
            {-0.5,   0, 0.5,  0.5,  0.5, 0.5,  0, -0.5 },
            {   0,   0, 0.5,  0.5,  0.5, 0.5,  0, -0.5 },
            {  -1, 0.5, 0.5,  0.5,  0.5, 0.5,  0,   -1 },
            {  -1,   0, 0.5,    0,    0,   0,  0,   -1 },
            {  -2,  -1,  -1, -0.5, -0.5,  -1, -1,   -2 }
        };

        static double[,] rookPosition =
        {
            {   0,   0,   0,    0,    0,   0,  0,    0 },
            { 0.5,   1,   1,    1,    1,   1,  1,  0.5 },
            {-0.5,   0,   0,    0,    0,   0,  0, -0.5 },
            {-0.5,   0,   0,    0,    0,   0,  0, -0.5 },
            {-0.5,   0,   0,    0,    0,   0,  0, -0.5 },
            {-0.5,   0,   0,    0,    0,   0,  0, -0.5 },
            {-0.5,   0,   0,    0,    0,   0,  0, -0.5 },
            {   0,   0,   0,  0.5,  0.5,   0,  0,    0 }
        };

        static double[,] bishopPosition =
        {
            {-2,  -1,  -1, -1, -1,  -1,  -1, -2 },
            {-1,   0,   0,  0,  0,   0,   0, -1 },
            {-1,   0, 0.5,  1,  1, 0.5,   0, -1 },
            {-1, 0.5, 0.5,  1,  1, 0.5, 0.5, -1 },
            {-1,   0,   1,  1,  1.5,   1,   0, -1 },
            {-1,   1,   1,  0.5,  1,   1,   1, -1 },
            {-1, 0.5,   0, 1.5,  0,   0, 0.5, -1 },
            {-2,  -1,  -1, -1, -1,  -1,  -1, -2 }
        };

        static double[,] knightPosition =
        {
            {-5,  -4,  -3,  -3,  -3,  -3,  -4, -5 },
            {-4,  -2,   0,   0,   0,   0,  -2, -4 },
            {-3,   0,   1, 1.5, 1.5,   1,   0, -3 },
            {-3, 0.5, 1.5,   2,   0.5, 1.5, 0.5, -3 },
            {-3,   0, 1.5,   0.5,   2, 1.5,   0, -3 },
            {-3, 0.5,   2, 1.5, 1.5,   1, 0.5, -3 },
            {-4,  -2,   0, 0.5, 0.5,   0,  -2, -4 },
            {-5,  -4,  -3,  -3,  -3,  -3,  -4, -5 },
        };

        static double[,] pawnPosition =
        {
            {  6,    6,   6,   6,   6,   6,    6,   6 },
            {  5,    5,   5,   5,   5,   5,    5,   5 },
            {  1,    1,   2,   3,   3,   2,    1,   1 },
            {0.5,  0.5, 1.5, 2.5, 2.5,   1,  0.5, 0.5 },
            {  0,    0,   0,   2.5,   2,   0,    0,   0 },
            {  1, -0.5, 0.5,    0,   1,  -1, -0.5, 0.5 },
            {0.5,    1,   1,  -2,  -2,   1,    1, 0.5 },
            {  0,    0,   0,   0,   0,   0,    0,    0},
        };

    }

}