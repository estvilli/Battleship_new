using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;


namespace Domain
{
    public class GameBoard
    {
        public int TableDimension;
        private int counter1 = 0;
        public int x_coord = 0;
        public int y_coord = 0;
        public BoardSquareState hitOrMiss;
        public int shipSquareCount = 0;
        private int rowCounter = 1;
        public string direction;
        private bool isAutomatic = false;
        public int shipLength;
        public bool isRerun = false;


        public List<List<BoardSquareState>> Player1Board1 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player1Board2 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player2Board1 { get; set; } = new List<List<BoardSquareState>>();
        public List<List<BoardSquareState>> Player2Board2 { get; set; } = new List<List<BoardSquareState>>();


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

        public Dictionary<int, string> directionNumberToString = new Dictionary<int, string>
        {
            {0, "W"}, {1, "N"}, {2, "E"}, {3, "S"}
        };

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



            TableDimension = tableDimension;
            this.isAutomatic = isAutomatic;

            //player 1 own ships table

            for (int i = 0; i < TableDimension; i++)
            {
                Player1Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player1Board1[i].Add(BoardSquareState.Empty);
                }
            }



            //player 2 own ships table
  
            for (int i = 0; i < TableDimension; i++)
            {
                Player2Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player2Board1[i].Add(BoardSquareState.Empty);
                }
            }


        }

        

        public void placePlayer1Ship()
        {
            //place player 1 single ship on table
            Player1Board1[x_coord - 1][y_coord] =
                BoardSquareState.Ship;

            if (StringToEnum(direction) == Directions.W)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player1Board1[x_coord - 1][y_coord - i] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.N)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player1Board1[x_coord - 1 - i][y_coord] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.E)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player1Board1[x_coord - 1][y_coord + i] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.S)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player1Board1[x_coord - 1 + i][y_coord] = BoardSquareState.Ship;
                }
            }


        }

        public void placePlayer2Ship()
        {
            //place player 2 single ship ship on table

            Player2Board1[x_coord - 1][y_coord] =
                BoardSquareState.Ship;

            if (StringToEnum(direction) == Directions.W)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player2Board1[x_coord - 1][y_coord - i] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.N)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player2Board1[x_coord - 1 - i][y_coord] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.E)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player2Board1[x_coord - 1][y_coord + i] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.S)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    Player2Board1[x_coord - 1 + i][y_coord] = BoardSquareState.Ship;
                }
            }
        }

        public void FillEnemyShipTables()
        {
            //player 1 enemy ships table

            for (int i = 0; i < TableDimension; i++)
            {
                Player1Board2.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player1Board2[i].Add(BoardSquareState.Unknown);
                }
            }

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

        public void EmptyTable1()
        {
            Player1Board1 = new List<List<BoardSquareState>>();
            for (int i = 0; i < TableDimension; i++)
            {
                Player1Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player1Board1[i].Add(BoardSquareState.Empty);
                }
            }
        }
        
        public void EmptyTable2()
        {
            Player2Board1 = new List<List<BoardSquareState>>();
            for (int i = 0; i < TableDimension; i++)
            {
                Player2Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < TableDimension; j++)
                {
                    Player2Board1[i].Add(BoardSquareState.Empty);
                }
            }
        }

        public void Player1Turn()
        {

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




        public bool CheckIfLocationIsOk1(int x_coordinate, int y_coordinate, Domain.Directions direction, Ships shipType)
        {
            if (shipType == Ships.Carrier)
            {
                counter1 = 4;
            }
            else if (shipType == Ships.Battleship)
            {
                counter1 = 3;
            }
            else if (shipType == Ships.Submarine)
            {
                counter1 = 2;
            }
            else if (shipType == Ships.Cruiser)
            {
                counter1 = 1;
            }
            else if (shipType == Ships.Patrol)
            {
                counter1 = 0;
            }


            if (x_coordinate - 1 >= TableDimension || y_coordinate >= TableDimension || x_coordinate - 1 < 0 ||
                y_coordinate < 0)
            {
                counter1 = 0;
                return false;
            }
            else if (Player1Board1[x_coordinate - 1][y_coordinate] ==
                     BoardSquareState.Ship)
            {
                counter1 = 0;
                return false;
            }

            if (direction == Directions.W)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate - i >= TableDimension || y_coordinate - i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1][y_coordinate - i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.N)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 - i >= TableDimension || x_coordinate - 1 - i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1 - i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }

            else if (direction == Directions.E)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate + i >= TableDimension || y_coordinate + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1][y_coordinate + i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.S)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 + i >= TableDimension || x_coordinate - 1 + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1 + i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }

            
            
            
            counter1 = 0;
            return true;
        }
        
        public bool CheckIfLocationIsOk2(int x_coordinate, int y_coordinate, Domain.Directions direction, Ships shipType)
        {
            if (shipType == Ships.Carrier)
            {
                counter1 = 4;
            }
            else if (shipType == Ships.Battleship)
            {
                counter1 = 3;
            }
            else if (shipType == Ships.Submarine)
            {
                counter1 = 2;
            }
            else if (shipType == Ships.Cruiser)
            {
                counter1 = 1;
            }
            else if (shipType == Ships.Patrol)
            {
                counter1 = 0;
            }


            if (x_coordinate - 1 >= TableDimension || y_coordinate >= TableDimension || x_coordinate - 1 < 0 ||
                y_coordinate < 0)
            {
                counter1 = 0;
                return false;
            }
            else if (Player2Board1[x_coordinate - 1][y_coordinate] ==
                     BoardSquareState.Ship)
            {
                counter1 = 0;
                return false;
            }

            if (direction == Directions.W)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate - i >= TableDimension || y_coordinate - i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1][y_coordinate - i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.N)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 - i >= TableDimension || x_coordinate - 1 - i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1 - i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }

            else if (direction == Directions.E)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate + i >= TableDimension || y_coordinate + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1][y_coordinate + i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.S)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 + i >= TableDimension || x_coordinate - 1 + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1 + i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
           
            counter1 = 0;
            return true;
        }
    }
}