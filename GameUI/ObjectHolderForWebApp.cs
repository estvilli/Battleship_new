using Domain;

namespace GameUI
{
    public static class ObjectHolderForWebApp
    {
        public static GameBoard GameBoard { get; set; } = null;
        public static bool ContinuePlaying = true;
        
        public static void CreateGameBoard(int tableDimension, bool isAutomatic)
        {
            GameBoard = new GameBoard(tableDimension, isAutomatic);
            
        }
    }
}