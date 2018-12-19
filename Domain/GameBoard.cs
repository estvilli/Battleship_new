using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;



namespace Domain
{
    public static class GameBoard
    {
        public int TableDimension;
        private int counter = 0;
        private int counter1 = 0;
        public int x_coord = 0;
        public int y_coord = 0;
        public BoardSquareState hitOrMiss;
        public int shipSquareCount = 0;
        private int rowCounter = 1;
        public string direction;
        private bool isAutomatic = false;



        public List<List<BoardSquareState>> Player1Board1 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player1Board2 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player2Board1 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player2Board2 { get; set; } = new List<List<BoardSquareState>>();

        //[position(x-koord, y-koord), ship, direction]
        //public List<string> Player1Ships { get; set; } = new List<string>();
        //public List<string> Player2Ships { get; set; } = new List<string>();

        //0 - carrier, 1 - battlehip, 3 - submarine, 4 - cruiser, 5 - patrol
        public List<Ships> ShipTypes { get; set; } = new List<Ships>();
        public List<int> ShipLengths { get; set; } = new List<int>();

        public List<string> Player1ShipCoordinates { get; set; } = new List<string>();
        public List<Directions> Player1ShipDirections { get; set; } = new List<Directions>();

        public List<string> Player2ShipCoordinates { get; set; } = new List<string>();
        public List<Directions> Player2ShipDirections { get; set; } = new List<Directions>();

        public List<string> Alphabet { get; set; } = new List<string>
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z"
        };

        public Dictionary<string, int> letterToNumber = new Dictionary<string, int>
        {
            {"a", 0}, {"b", 1}, {"c", 2}, {"d", 3}, {"e", 4}, {"f", 5}, {"g", 6}, {"h", 7}, {"i", 8}, {"j", 9},
            {"k", 10}, {"l", 11}, {"m", 12}, {"n", 13}, {"o", 14},
            {"p", 15}, {"q", 16}, {"r", 17}, {"s", 18}, {"t", 19}, {"u", 20}, {"v", 21}, {"w", 22}, {"x", 23},
            {"y", 24}, {"z", 25}
        };

        /*public Dictionary<int, Directions> numberToEnum = new Dictionary<int, Directions>
        {
            {0, Directions.W}, {1, Directions.N}, {2, Directions.E}, {3, Directions.S}
        };*/

        Random random = new Random();


        //Player1Board1

        public GameBoard(int tableDimension, bool isAutomatic)

        {
            ShipTypes.Add(Ships.Carrier);
            ShipTypes.Add(Ships.Battleship);
            ShipTypes.Add(Ships.Submarine);
            ShipTypes.Add(Ships.Cruiser);
            ShipTypes.Add(Ships.Patrol);

            ShipLengths.Add(4);
            ShipLengths.Add(3);
            ShipLengths.Add(2);
            ShipLengths.Add(1);
            ShipLengths.Add(0);

            /*Player1ShipCoordinates.Add("11");
            Player1ShipCoordinates.Add("22");
            Player1ShipCoordinates.Add("47");
            Player1ShipCoordinates.Add("33");
            Player1ShipCoordinates.Add("64");
            Player1ShipDirections.Add(Directions.E);
            Player1ShipDirections.Add(Directions.S);
            Player1ShipDirections.Add(Directions.W);
            Player1ShipDirections.Add(Directions.E);
            Player1ShipDirections.Add(Directions.E);

            Player2ShipCoordinates.Add("11");
            Player2ShipCoordinates.Add("22");
            Player2ShipCoordinates.Add("47");
            Player2ShipCoordinates.Add("33");
            Player2ShipCoordinates.Add("64");
            Player2ShipDirections.Add(Directions.E);
            Player2ShipDirections.Add(Directions.S);
            Player2ShipDirections.Add(Directions.W);
            Player2ShipDirections.Add(Directions.E);
            Player2ShipDirections.Add(Directions.E);*/


            TableDimension = tableDimension;
            this.isAutomatic = isAutomatic;

            //player 1 own ships table
            //Console.WriteLine("PLAYER 1");
            for (int i = 0; i < TableDimension; i++)
            {
                Player1Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player1Board1[i].Add(BoardSquareState.Empty);
                }
            }

            if (this.isAutomatic)
            {
                AutomaticShipCoordinates1();
            }
            else
            {
                
            }

            

            //player 2 own ships table
            //Console.WriteLine("PLAYER 2");
            for (int i = 0; i < TableDimension; i++)
            {
                Player2Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player2Board1[i].Add(BoardSquareState.Empty);
                }
            }

            if (this.isAutomatic)
            {
                AutomaticShipCoordinates2();
            }
            else
            {
                
                
            }

            
        }

        public void placePlayer1Ships()
        {
            //place player 1 ships on table
            foreach (var coordinate in Player1ShipCoordinates)
            {
                x_coord = Int32.Parse(coordinate.Substring(0, 1));
                y_coord = Int32.Parse(coordinate.Substring(1, 1));
                Player1Board1[x_coord - 1][y_coord] =
                    BoardSquareState.Ship;

                counter1 = ShipLengths[counter];
                if (Player1ShipDirections[counter] == Directions.W)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player1Board1[x_coord - 1][y_coord - i] = BoardSquareState.Ship;
                    }
                }
                else if (Player1ShipDirections[counter] == Directions.N)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player1Board1[x_coord - 1 - i][y_coord] = BoardSquareState.Ship;
                    }
                }
                else if (Player1ShipDirections[counter] == Directions.E)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player1Board1[x_coord - 1][y_coord + i] = BoardSquareState.Ship;
                    }
                }
                else if (Player1ShipDirections[counter] == Directions.S)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player1Board1[x_coord - 1 + i][y_coord] = BoardSquareState.Ship;
                    }
                }

                counter1 = 0;
                counter++;
            }

            //player 1 enemy ships table

            for (int i = 0; i < TableDimension; i++)
            {
                Player1Board2.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player1Board2[i].Add(BoardSquareState.Unknown);
                }
            }

            counter = 0;
        }
        
        public void placePlayer2Ships()
        {
            //place player 2 ships on table
            foreach (var coordinate in Player1ShipCoordinates)
            {
                x_coord = Int32.Parse(coordinate.Substring(0, 1));
                y_coord = Int32.Parse(coordinate.Substring(1, 1));
                Player2Board1[x_coord][y_coord] =
                    BoardSquareState.Ship;

                counter1 = ShipLengths[counter];
                if (Player2ShipDirections[counter] == Directions.W)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player2Board1[x_coord - 1][y_coord - i] = BoardSquareState.Ship;
                    }
                }
                else if (Player2ShipDirections[counter] == Directions.N)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player2Board1[x_coord - 1 - i][y_coord] = BoardSquareState.Ship;
                    }
                }
                else if (Player2ShipDirections[counter] == Directions.E)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player2Board1[x_coord - 1][y_coord + i] = BoardSquareState.Ship;
                    }
                }
                else if (Player2ShipDirections[counter] == Directions.S)
                {
                    for (int i = counter1; i >= 0; i--)
                    {
                        Player2Board1[x_coord - 1 + i][y_coord] = BoardSquareState.Ship;
                    }
                }

                counter1 = 0;
                counter++;
            }

            counter = 0;

            //player 2 enemy ships table

            for (int i = 0; i < TableDimension; i++)
            {
                Player2Board2.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player2Board2[i].Add(BoardSquareState.Unknown);
                }
            }
        }

        /*public void gamePlay()
        {
            
        }*/

        public void Player1Turn()
        {
            //x_coord = Int32.Parse(hitCoordinates.Substring(0, 1));
            //y_coord = Int32.Parse(hitCoordinates.Substring(1, 1));
            if (Player2Board1[x_coord][y_coord] == BoardSquareState.Ship)
            {
                Player1Board2[x_coord][y_coord] = BoardSquareState.Hit;
                Player2Board1[x_coord][y_coord] = BoardSquareState.Hit;
                hitOrMiss = BoardSquareState.Hit;
            }
            else if (Player2Board1[x_coord][y_coord] == BoardSquareState.Empty)
            {
                Player1Board2[x_coord][y_coord] = BoardSquareState.Miss;
                Player2Board1[x_coord][y_coord] = BoardSquareState.Miss;
                hitOrMiss = BoardSquareState.Miss;
            }
        }

        public void Player2Turn()
        {
            //x_coord = Int32.Parse(hitCoordinates.Substring(0, 1));
            //y_coord = Int32.Parse(hitCoordinates.Substring(1, 1));
            if (Player1Board1[x_coord][y_coord] == BoardSquareState.Ship)
            {
                Player2Board2[x_coord][y_coord] = BoardSquareState.Hit;
                Player1Board1[x_coord][y_coord] = BoardSquareState.Hit;
                hitOrMiss = BoardSquareState.Hit;
            }
            else if (Player1Board1[x_coord][y_coord] == BoardSquareState.Empty)
            {
                Player2Board2[x_coord][y_coord] = BoardSquareState.Miss;
                Player1Board1[x_coord][y_coord] = BoardSquareState.Miss;
                hitOrMiss = BoardSquareState.Miss;
            }
        }

        public string GetBoardString11()
        {
            var sb = new StringBuilder();
            sb.Append(GetHorizontalCoordinates(TableDimension) + "\n");
            foreach (var boardRow in Player1Board1)
            {
                sb.Append(GetRowSeparator(TableDimension) + "\n");
                sb.Append(GetRowWithData(boardRow) + "\n");
            }

            sb.Append(GetRowSeparator(TableDimension));
            rowCounter = 1;
            return sb.ToString();
        }

        public string GetBoardString12()
        {
            var sb = new StringBuilder();
            sb.Append(GetHorizontalCoordinates(TableDimension) + "\n");
            foreach (var boardRow in Player1Board2)
            {
                sb.Append(GetRowSeparator(TableDimension) + "\n");
                sb.Append(GetRowWithData(boardRow) + "\n");
            }

            sb.Append(GetRowSeparator(TableDimension));
            rowCounter = 1;
            return sb.ToString();
        }

        public string GetBoardString21()
        {
            var sb = new StringBuilder();
            sb.Append(GetHorizontalCoordinates(TableDimension) + "\n");
            foreach (var boardRow in Player2Board1)
            {
                sb.Append(GetRowSeparator(TableDimension) + "\n");
                sb.Append(GetRowWithData(boardRow) + "\n");
            }

            sb.Append(GetRowSeparator(TableDimension));
            rowCounter = 1;
            return sb.ToString();
        }


        public string GetBoardString22()
        {
            var sb = new StringBuilder();
            sb.Append(GetHorizontalCoordinates(TableDimension) + "\n");
            foreach (var boardRow in Player2Board2)
            {
                sb.Append(GetRowSeparator(TableDimension) + "\n");
                sb.Append(GetRowWithData(boardRow) + "\n");
            }

            sb.Append(GetRowSeparator(TableDimension));
            rowCounter = 1;
            return sb.ToString();
        }

        public string GetHorizontalCoordinates(int elemCountInRow)
        {
            var sb = new StringBuilder();
            sb.Append("     a");
            for (int i = 1; i < elemCountInRow; i++)
            {
                sb.Append("   " + Alphabet[i]);
            }

            return sb.ToString();
        }

        //general use
        public string GetRowSeparator(int elemCountInRow)
        {
            var sb = new StringBuilder();
            sb.Append("   ");
            for (int i = 0; i < elemCountInRow; i++)
            {
                sb.Append("+---");
            }

            sb.Append("+");
            return sb.ToString();
        }

        public string GetRowWithData(List<BoardSquareState> boardRow)
        {
            var sb = new StringBuilder();
            if (rowCounter >= 10)
            {
                sb.Append(rowCounter + ".");
            }
            else
            {
                sb.Append(rowCounter + ". ");
            }

            foreach (var boardSquareState in boardRow)
            {
                sb.Append("| " + GetBoardSquareStateSymbol(boardSquareState) + " ");
            }

            sb.Append("|");
            rowCounter++;
            return sb.ToString();
        }

        public string GetBoardSquareStateSymbol(BoardSquareState state)
        {
            switch (state)
            {
                case BoardSquareState.Empty: return " ";
                case BoardSquareState.Unknown: return "-";
                case BoardSquareState.Ship: return "+";
                case BoardSquareState.Hit: return "X";
                case BoardSquareState.Miss: return "0";


                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        public Directions StringToEnum(string direction)
        {
            switch (direction)
            {
                case "W":
                    return Directions.W;
                case "N":
                    return Directions.N;
                case "E":
                    return Directions.E;
                case "S":
                    return Directions.S;
                default:
                    return Directions.error;
            }
        }

        public Directions NumberToEnum(int randomNumber)
        {
            switch (randomNumber)
            {
                case 0:
                    return Directions.W;
                case 1:
                    return Directions.N;
                case 2:
                    return Directions.E;
                case 3:
                    return Directions.S;
                default:
                    return Directions.error;
            }
        }

        

        public void AutomaticShipCoordinates1()
        {
            for (int i = 0; i < 5; i++)
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append(random.Next(0, 10).ToString());
                sb1.Append(random.Next(0, 10).ToString());
                Player1ShipCoordinates.Add(sb1.ToString());

                Player1ShipDirections.Add(NumberToEnum(random.Next(0, 4)));
            }
        }

        public void AutomaticShipCoordinates2()
        {
            for (int i = 0; i < 5; i++)
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append(random.Next(0, 10).ToString());
                sb1.Append(random.Next(0, 10).ToString());
                Player2ShipCoordinates.Add(sb1.ToString());

                Player2ShipDirections.Add(NumberToEnum(random.Next(0, 4)));
            }
        }

        
    }
}