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
    public class Player1PlaceShipsModel : PageModel
    {    
        private string CarrierVertCoord;
        private string CarrierHorizCoord;
        private string CarrierDirection;
        
        private string BattleshipVertCoord;
        private string BattleshipHorizCoord;
        private string BattleshipDirection;
        
        private string SubVertCoord;
        private string SubHorizCoord;
        private string SubDirection;
        
        private string CruiserVertCoord;
        private string CruiserHorizCoord;
        private string CruiserDirection;
        
        private string PatrolVertCoord;
        private string PatrolHorizCoord;
        private string PatrolDirection;
        

        public IActionResult OnPost()
        {
            CarrierVertCoord = Request.Form["CarrierVertCoord"];
            CarrierHorizCoord = Request.Form["CarrierHorizCoord"];
            CarrierDirection = Request.Form["CarrierDirection"];
            
            BattleshipVertCoord = Request.Form["BattleshipVertCoord"];
            BattleshipHorizCoord = Request.Form["BattleshipHorizCoord"];
            BattleshipDirection = Request.Form["BattleshipDirection"];
                
            SubVertCoord = Request.Form["SubVertCoord"];
            SubHorizCoord = Request.Form["SubHorizCoord"];
            SubDirection = Request.Form["SubDirection"];
            
            CruiserVertCoord = Request.Form["CruiserVertCoord"];
            CruiserHorizCoord = Request.Form["CruiserHorizCoord"];
            CruiserDirection = Request.Form["CruiserDirection"];
                
            PatrolVertCoord = Request.Form["PatrolVertCoord"];
            PatrolHorizCoord = Request.Form["PatrolHorizCoord"];
            PatrolDirection = Request.Form["PatrolDirection"];
            
            ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(CarrierVertCoord);
            ObjectHolderForWebApp.GameBoard.y_coord = ObjectHolderForWebApp.GameBoard.letterToNumber[CarrierHorizCoord];
            ObjectHolderForWebApp.GameBoard.direction = CarrierDirection.ToUpper();
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
                ObjectHolderForWebApp.GameBoard.EmptyTable1();
                ObjectHolderForWebApp.GameBoard.isRerun = true;
                return RedirectToPage("/Player1PlaceShips");
            }
            
            ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(BattleshipVertCoord);
            ObjectHolderForWebApp.GameBoard.y_coord = ObjectHolderForWebApp.GameBoard.letterToNumber[BattleshipHorizCoord];
            ObjectHolderForWebApp.GameBoard.direction = BattleshipDirection.ToUpper();
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
                ObjectHolderForWebApp.GameBoard.EmptyTable1();
                ObjectHolderForWebApp.GameBoard.isRerun = true;
                return RedirectToPage("/Player1PlaceShips");
            }

            ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(SubVertCoord);
            ObjectHolderForWebApp.GameBoard.y_coord = ObjectHolderForWebApp.GameBoard.letterToNumber[SubHorizCoord];
            ObjectHolderForWebApp.GameBoard.direction = SubDirection.ToUpper();
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
                ObjectHolderForWebApp.GameBoard.EmptyTable1();
                ObjectHolderForWebApp.GameBoard.isRerun = true;
                return RedirectToPage("/Player1PlaceShips");
            }

            ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(CruiserVertCoord);
            ObjectHolderForWebApp.GameBoard.y_coord = ObjectHolderForWebApp.GameBoard.letterToNumber[CruiserHorizCoord];
            ObjectHolderForWebApp.GameBoard.direction = CruiserDirection.ToUpper();
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
                ObjectHolderForWebApp.GameBoard.EmptyTable1();
                ObjectHolderForWebApp.GameBoard.isRerun = true;
                return RedirectToPage("/Player1PlaceShips");
            }

            ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(PatrolVertCoord);
            ObjectHolderForWebApp.GameBoard.y_coord = ObjectHolderForWebApp.GameBoard.letterToNumber[PatrolHorizCoord];
            ObjectHolderForWebApp.GameBoard.direction = PatrolDirection.ToUpper();
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
                ObjectHolderForWebApp.GameBoard.EmptyTable1();
                ObjectHolderForWebApp.GameBoard.isRerun = true;
                return RedirectToPage("/Player1PlaceShips");
            }
            
            ObjectHolderForWebApp.GameBoard.isRerun = false;
            return RedirectToPage("/Player2PlaceShips");
        }
    }
}