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
        static public void Move(Button[,] cells)
        {
            WorthMovement ComputerMovement = Computer.MovementInfo(cells);
            int SourceIndexX = ComputerMovement.Source.X / cells[0, 0].Size.Width;
            int SourceIndexY = ComputerMovement.Source.Y / cells[0, 0].Size.Height;
            int DestinationIndexX = ComputerMovement.Destination.X / cells[0, 0].Size.Width;
            int DestinationIndexY = ComputerMovement.Destination.Y / cells[0, 0].Size.Height;

            ChessBoard.Chesspiece_Move(cells[SourceIndexX, SourceIndexY], cells[DestinationIndexX, DestinationIndexY]);
        }

        static public WorthMovement MovementInfo(Button[,] cells)
        {
            List<WorthMovement> list = new List<WorthMovement>();
            WorthMovement movement;
            foreach (Button item in cells)
            {
                WorthMovement move = new WorthMovement();
                move.value = -9999;
                if (item.ForeColor == Color.Black && item.Text != "")
                {
                    move.Source = item.Location;
                    ChessBoard.ShowLegalMovement(item, cells);
                    foreach (Button item2 in cells)       //tìm nước đi ngon của quân cờ.
                    {
                        if (item2.FlatAppearance.BorderColor == Color.Blue)
                            if (move.value < ValuablePosition(item2.Location.X / cells[0, 0].Size.Width, item2.Location.Y / cells[0, 0].Size.Height) + WorthChessman(item2.Text))
                            {
                                move.value = ValuablePosition(item2.Location.X / cells[0, 0].Size.Width, item2.Location.Y / cells[0, 0].Size.Height) + WorthChessman(item2.Text);
                                move.Destination = item2.Location;
                            }
                    }
                    ChessBoard.ResetBoderColor(cells);
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
                    return 99999;
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

        static  private int hazii(Button Source, Button Destination, Button[,] cells)
        {
            Button[,] matrix = ChessBoard.Forwarding(Source, Destination, cells);

            if (matrix[Destination.Location.X / cells[0, 0].Width, Destination.Location.Y / cells[0, 0].Height].FlatAppearance.BorderColor == Color.Blue)
                return WorthChessman(Source.Text);
            else return 0;
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
