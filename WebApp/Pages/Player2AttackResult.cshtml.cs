using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{

    public class Player2AttackResultModel : PageModel
    {
        public IActionResult OnPost()
        {

            if (GameUI.ObjectHolderForWebApp.ContinuePlaying)
            {
                GameUI.ObjectHolderForWebApp.GameBoard.shipSquareCount = 0;
                return RedirectToPage("/Player1Attack");
            }

            return RedirectToPage("/Index");            
        }
    }
}