using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class SomeModel : PageModel
    {
        public GameBoard GameBoard { get; set; } = null;
        public string Message { get; set; }
        private int tableDimension { get; set; }
        private bool isAutomatic;

        public IActionResult OnPost()
        {
            //tableDimension = Int32.Parse(sisestusväljalt);
            /*switch (automatic)
                {    
                case "M":
                isAutomatic = false;
                break;
                case "A":
                isAutomatic = true;
                break;
                default:
                Console.WriteLine("You entered an unrecognized character. Please try again.");
                break; }
                
                GameBoard = new GameBoard(tableDimension, isAutomatic);
                if (!isAutomatic)
                {
                    return RedirectToPage("/SomeFile");
                }
                else {
                    return RedirectToPage("/Index");
                }
                GameBoard.placePlayer1Ships();
                GameBoard.placePlayer2Ships();
                gamePlay1();*/

            
        }
    }
}