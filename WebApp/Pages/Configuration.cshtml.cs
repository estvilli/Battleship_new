using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using GameUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class ConfigurationModel : PageModel
    {
        
        public string Message { get; set; }
        private int tableDimension;
        private bool isAutomatic;
        private string automatic;
        private bool continueAskingShipCoordinates = true;
        Random rnd = new Random();
        
        public bool AutomaticShipCoordinates1()
        {

            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 4;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk1(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Carrier))
            {
                ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player1ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer1Ship();
            }
            else
            {
                return false;
            }



            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 3;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk1(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Battleship))
            {
                ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player1ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer1Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 2;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk1(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Submarine))
            {
                ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player1ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer1Ship();
            }
            else
            {
                return false;
            }

            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 1;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk1(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Cruiser))
            {
                ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player1ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer1Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 0;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk1(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Patrol))
            {
                ObjectHolderForWebApp.GameBoard.Player1ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player1ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer1Ship();
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool AutomaticShipCoordinates2()
        {

            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 4;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk2(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Carrier))
            {
                ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player2ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer2Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 3;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk2(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Battleship))
            {
                ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player2ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer2Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 2;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk2(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Submarine))
            {
                ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player2ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer2Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 1;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk2(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Cruiser))
            {
                ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player2ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer2Ship();
            }
            else
            {
                return false;
            }


            ObjectHolderForWebApp.GameBoard.x_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.y_coord = rnd.Next(1, tableDimension + 1);
            ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
            ObjectHolderForWebApp.GameBoard.direction = ObjectHolderForWebApp.GameBoard.directionNumberToString[rnd.Next(0, 4)];
            ObjectHolderForWebApp.GameBoard.shipLength = 0;
            if (ObjectHolderForWebApp.GameBoard.CheckIfLocationIsOk2(ObjectHolderForWebApp.GameBoard.x_coord, ObjectHolderForWebApp.GameBoard.y_coord,
                ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction), Ships.Patrol))
            {
                ObjectHolderForWebApp.GameBoard.Player2ShipCoordinates.Add(ObjectHolderForWebApp.GameBoard.x_coord.ToString() + ObjectHolderForWebApp.GameBoard.y_coord.ToString());
                ObjectHolderForWebApp.GameBoard.Player2ShipDirections.Add(ObjectHolderForWebApp.GameBoard.StringToEnum(ObjectHolderForWebApp.GameBoard.direction));
                ObjectHolderForWebApp.GameBoard.placePlayer2Ship();
            }
            else
            {
                return false;
            }

            return true;
        }
        
        

        public IActionResult OnPost()
        {
            tableDimension = Int32.Parse(Request.Form["TableSize"]);
            automatic = Request.Form["GameMode"].ToString().ToUpper();         //!!!!!!!!!!!!!!!!
            switch (automatic)
            {    
                case "M":
                    isAutomatic = false;
                    break;
                case "A":
                    isAutomatic = true;
                    break;

                    
            }
            ObjectHolderForWebApp.CreateGameBoard(tableDimension, isAutomatic);
                
            if (!isAutomatic)
            {
                return RedirectToPage("/Player1PlaceShips");
            }

            else if(isAutomatic) {

                while (continueAskingShipCoordinates)
                {
                    if (AutomaticShipCoordinates1())
                    {
                        continueAskingShipCoordinates = false;
                        break;
                    }

                    ObjectHolderForWebApp.GameBoard.EmptyTable1();
                }

                continueAskingShipCoordinates = true;
                while (continueAskingShipCoordinates)
                {
                    if (AutomaticShipCoordinates2())
                    {
                        continueAskingShipCoordinates = false;
                        break;
                    }

                    ObjectHolderForWebApp.GameBoard.EmptyTable2();
                }
                
                ObjectHolderForWebApp.GameBoard.FillEnemyShipTables();
                return RedirectToPage("/Player1Attack");
            }
            else
            {
                return RedirectToPage("/Index");
            }


            
        }
    }
}