using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVua
{
    struct WorthMovement
    {
        internal Point Source { get; set; }
        internal Point  Destination { get; set; }
        internal double value { get; set; }

    }


    class Computer
    {
        static public void Move(ChessBoard chessBoard)
        {

            WorthMovement ComputerMovement = Computer.MovementInfo(chessBoard);
            int SourceIndexX = ComputerMovement.Source.X / chessBoard.cells[0, 0].Size.Width;
            int SourceIndexY = ComputerMovement.Source.Y / chessBoard.cells[0, 0].Size.Height;
            int DestinationIndexX = ComputerMovement.Destination.X / chessBoard.cells[0, 0].Size.Width;
            int DestinationIndexY = ComputerMovement.Destination.Y / chessBoard.cells[0, 0].Size.Height;

            chessBoard.movementInfos.Add(chessBoard.save(chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard.cells[DestinationIndexX, DestinationIndexY]));
            ChessBoard.Chesspiece_Move(chessBoard.cells[SourceIndexX, SourceIndexY], chessBoard.cells[DestinationIndexX, DestinationIndexY], chessBoard);
        }

        static public WorthMovement MovementInfo(ChessBoard chessBoard)
        {
            chessBoard.checkMate = chessBoard.CheckMate(chessBoard);
            List<WorthMovement> list = new List<WorthMovement>();
            WorthMovement movement;
            foreach (Button item in chessBoard.cells)
            {
                WorthMovement move = new WorthMovement();
                move.value = -9999;
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
                            double value = ValuablePosition(item2.Location.X / chessBoard.cells[0, 0].Size.Width, item2.Location.Y / chessBoard.cells[0, 0].Size.Height) 
                                           + WorthChessman(item2.Text) + hazii(item, item2, chessBoard);
                            if (move.value < value)
                            {
                                move.value = value;
                                move.Destination = item2.Location;
                            }
                        }
                            
                    }
                    ChessBoard.ResetBoderColor(chessBoard);
                    if (move.value != -9999)
                        list.Add(move);
                }
            }

            if (list.Count == 0)
            {
                MessageBox.Show("you win");   
                
            }

            movement = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].value > movement.value)
                    movement = list[i];
            }

            return movement;
        }

        static private double ValuablePosition(int x, int y)
        {
            return 2 - Math.Pow(x - 3.5, 2) - Math.Pow(y - 3.5, 2);
        }

        /// <summary>
        /// trả về giá trị của một quân cờ.
        /// </summary>
        /// <param name="chessman"></param>
        /// <returns></returns>
        static private int WorthChessman(string chessman)
        {
            switch (chessman)
            {
                case "king":
                    return 990;
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

        static  private int hazii(Button Source, Button Destination, ChessBoard chessBoard)
        {
            ChessBoard Board = ChessBoard.Forwarding(Source, Destination, chessBoard);

            int value = 0;
            //if (Source.Text == "king")
            //    return -9999;

            if (Source.Text == "king"
                && Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                return -99999;   /////
            else if(Board.cells[Source.Location.X / chessBoard.cells[0, 0].Width, Source.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                value += WorthChessman(Source.Text) * 4 / 5;

            if (Board.cells[Destination.Location.X / chessBoard.cells[0, 0].Width, Destination.Location.Y / chessBoard.cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                value -= WorthChessman(Source.Text);
            

            return value;
        }

        //private Button[,] Forwarding(Button Source, Button Destination, Button[,] cells)
        //{
        //    Button[,] matrix = ChessBoard.CloneButtonsInfo(cells);

        //    ChessBoard.Chesspiece_Move(Source, Destination);
        //    foreach (Button item in matrix)
        //    {
        //        if (item.ForeColor == Color.Red)
        //            ChessBoard.ShowLegalMovement(item, matrix);
        //    }
        //    return matrix;
        //}
    }

}
