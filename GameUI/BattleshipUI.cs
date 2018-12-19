using System;
using Domain;

namespace GameUI
{
    public class BattleshipUI
    {
        public GameBoard GameBoard { get; set; } = null;
        private int tableDimension;
        private string automatic;
        private bool isAutomatic;
        private bool ContinuePlaying = true;
        private string userInput = null;

        public BattleshipUI()
        {
            Console.WriteLine("Welcome to the game Battleship! To start playing, press any key!\n");
            Console.ReadLine();
            Console.WriteLine("Please enter the size (width/height) of the table you want to play on:\n");
            tableDimension = Int32.Parse(Console.ReadLine());
            Console.WriteLine(
                "If you want to place the ships manually, enter \"M\" and press \"Enter\"; if you want them placed by the computer, enter \"A\" and press \"Enter\":\n");
            automatic = Console.ReadLine().ToUpper();
            switch (automatic)
            {
                case "M":
                    isAutomatic = false;
                    break;
                case "A":
                    isAutomatic = true;
                    break;
                default:
                    Console.WriteLine("You entered an unrecognized character. Please try again.");
                    break;
            }

            GameBoard = new GameBoard(tableDimension, isAutomatic);
            if (!isAutomatic)
            {
                ManualShipCoordinates1();
                ManualShipCoordinates2();
            }
            GameBoard.placePlayer1Ships();
            GameBoard.placePlayer2Ships();
            gamePlay1();


            
        }
        public void gamePlay1()
        {
            while (ContinuePlaying == true)
            {
                Console.WriteLine(
                    "If you want to exit the game, enter \"X\" and press \"Enter\"! If you want to continue playing, press \"Enter\": \n");
                userInput = Console.ReadLine();
                if (userInput == "X")
                {
                    ContinuePlaying = false;
                    break;
                }

                Console.WriteLine("Player 1 own ships table");
                Console.WriteLine(GameBoard.GetBoardString11());
                Console.WriteLine("Player 1 enemy ships table");
                Console.WriteLine(GameBoard.GetBoardString12());

                Console.WriteLine(
                    "Please enter the vertical coordinate of the enemy square you want to strike (1-...): \n");
                GameBoard.x_coord = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(
                    "Please enter the horizontal coordinate of the enemy square you want to strike (a-...): \n");
                GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
                GameBoard.Player1Turn();

                Console.WriteLine("Player 1 enemy ships table");
                Console.WriteLine(GameBoard.GetBoardString12());
                if (GameBoard.hitOrMiss == BoardSquareState.Hit)
                {
                    Console.WriteLine("Hit!");
                }
                else
                {
                    Console.WriteLine("Miss!");
                }

                
                for (int i = 0; i < GameBoard.TableDimension; i++)
                {
                    for (int j = 0; j < GameBoard.TableDimension; j++)
                    {
                        if (GameBoard.Player2Board1[i][j] == BoardSquareState.Ship)
                        {
                            GameBoard.shipSquareCount++;
                        }
                    }
                }

                if (GameBoard.shipSquareCount == 0)
                {
                    Console.WriteLine("Congratulations! Player 1 won!");
                    break;
                }

                GameBoard.shipSquareCount = 0;


                Console.WriteLine(
                    "If you want to exit the game, enter \"X\" and press \"Enter\"! If you want to continue playing, press \"Enter\": \n");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == "X")
                {
                    ContinuePlaying = false;
                    break;
                }

                Console.WriteLine("Player 2 own ships table");
                Console.WriteLine(GameBoard.GetBoardString21());
                Console.WriteLine("Player 2 enemy ships table");
                Console.WriteLine(GameBoard.GetBoardString22());

                Console.WriteLine(
                    "Please enter the vertical coordinate of the enemy square you want to strike (1-...): \n");
                GameBoard.x_coord = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(
                    "Please enter the horizontal coordinate of the enemy square you want to strike (a-...): \n");
                GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
                GameBoard.Player2Turn();

                Console.WriteLine("Player 2 enemy ships table");
                Console.WriteLine(GameBoard.GetBoardString22());
                if (GameBoard.hitOrMiss == BoardSquareState.Hit)
                {
                    Console.WriteLine("Hit!");
                }
                else
                {
                    Console.WriteLine("Miss!");
                }


                for (int i = 0; i < GameBoard.TableDimension; i++)
                {
                    for (int j = 0; j < GameBoard.TableDimension; j++)
                    {
                        if (GameBoard.Player1Board1[i][j] == BoardSquareState.Ship)
                        {
                            GameBoard.shipSquareCount++;
                        }
                    }
                }

                if (GameBoard.shipSquareCount == 0)
                {
                    Console.WriteLine("Congratulations! Player 2 won!");
                    break;
                }

                GameBoard.shipSquareCount = 0;
            }
        }
        
        public void ManualShipCoordinates1()
        {
            //ask player 1 for ship coordinates
            Console.WriteLine(GameBoard.GetBoardString11());
            Console.WriteLine("Please enter the vertical coordinate of your carrier (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your carrier (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));


            Console.WriteLine(GameBoard.GetBoardString11());
            Console.WriteLine("Please enter the vertical coordinate of your battleship (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your battleship (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString11());
            Console.WriteLine("Please enter the vertical coordinate of your submarine (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your submarine (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString11());
            Console.WriteLine("Please enter the vertical coordinate of your cruiser (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your cruiser (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString11());
            Console.WriteLine("Please enter the vertical coordinate of your patrol (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your patrol (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
        }

        public void ManualShipCoordinates2()
        {
            //ask player 2 for ship coordinates
            Console.WriteLine(GameBoard.GetBoardString21());
            Console.WriteLine("Please enter the vertical coordinate of your carrier (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your carrier (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString21());
            Console.WriteLine("Please enter the vertical coordinate of your battleship (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your battleship (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString21());
            Console.WriteLine("Please enter the vertical coordinate of your submarine (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your submarine (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString21());
            Console.WriteLine("Please enter the vertical coordinate of your cruiser (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your cruiser (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));

            Console.WriteLine(GameBoard.GetBoardString21());
            Console.WriteLine("Please enter the vertical coordinate of your patrol (1-...)");
            GameBoard.x_coord = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the horizontal coordinate of your patrol (a-...)");
            GameBoard.y_coord = GameBoard.letterToNumber[Console.ReadLine()];
            GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
            Console.WriteLine(
                "Please enter the direction of the ship: \"W\" - west, \"N\" - north, \"E\" - east, \"S\" - south");
            GameBoard.direction = Console.ReadLine().ToUpper();
            GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
        }
    }

    /*public string RunGame(string command)
    {
        Console.Clear();
        Console.WriteLine(GameBoard.GameBoard.GetBoardString());
    }*/
}