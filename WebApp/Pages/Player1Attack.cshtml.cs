using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using GameUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{

    public class Player1AttackModel : PageModel
    {
        private string VertCoord;
        private string HorizCoord;

        public IActionResult OnPost()
        {
            VertCoord = Request.Form["VertCoord"];
            HorizCoord = Request.Form["HorizCoord"];

            
            GameUI.ObjectHolderForWebApp.GameBoard.x_coord = Int32.Parse(VertCoord) - 1;
            GameUI.ObjectHolderForWebApp.GameBoard.y_coord = GameUI.ObjectHolderForWebApp.GameBoard.letterToNumber[HorizCoord];
            GameUI.ObjectHolderForWebApp.GameBoard.Player1Turn();
            
            for (int i = 0; i < ObjectHolderForWebApp.GameBoard.TableDimension; i++)
            {
                for (int j = 0; j < ObjectHolderForWebApp.GameBoard.TableDimension; j++)
                {
                    if (ObjectHolderForWebApp.GameBoard.Player2Board1[i][j] == BoardSquareState.Ship)
                    {
                        ObjectHolderForWebApp.GameBoard.shipSquareCount++;
                    }
                }
            }
            
            return RedirectToPage("/Player1AttackResult");

            ;
        }
    }
}