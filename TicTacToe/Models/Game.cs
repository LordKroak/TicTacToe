using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {
        public string CellID1 { get; set; }
        public string CellID2 { get; set; }
        public string CellID3 { get; set; }
        public string CellID4 { get; set; }
        public string CellID5 { get; set; }
        public string CellID6 { get; set; }
        public string CellID7 { get; set; }
        public string CellID8 { get; set; }
        public string CellID9 { get; set; }
        public Player PlayerX { get; set; }
        public Player PlayerO { get; set; }
        [TempData] 
        public string Message { get; set; }
        [TempData]
        public string turnMessage { get; set; }
        public string Xname = "X";
        public string Oname = "O";

        public Game()
        {
            NewGame();
        }

        public string CurrentPlayerName { get; set; }
        
        public void Place(int id)
        {
            //TODO
            //set up the placements of 'X' and 'O'
            //checks who current player is.

                switch (id)
            {
                case 1:
                    CellID1 = CurrentPlayerName;
                    break;
                case 2:
                    CellID2 = CurrentPlayerName;
                    break;
                case 3:
                    CellID3 = CurrentPlayerName;
                    break;
                case 4:
                    CellID4 = CurrentPlayerName;
                    break;
                case 5:
                    CellID5 = CurrentPlayerName;
                    break;
                case 6:
                    CellID6 = CurrentPlayerName;
                    break;
                case 7:
                    CellID7 = CurrentPlayerName;
                    break;
                case 8:
                    CellID8 = CurrentPlayerName;
                    break;
                case 9:
                    CellID9 = CurrentPlayerName;
                    break;
            }
            //[1] [2] [3]
            //[4] [5] [6]
            //[7] [8] [9]
            //123->win
            //456->win
            //789->win
            //159->win
            //357->win
            //147->win
            //258->win
            //369->win
            //id, current player, value of cell
            //last else if checks if all cells are not empty/null, it is a tie game.
            if (CellID1 == CellID2 && CellID2 == CellID3 && !string.IsNullOrEmpty(CellID1) )
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID4 == CellID5 && CellID5 == CellID6 && !string.IsNullOrEmpty(CellID4))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID7 == CellID8 && CellID8 == CellID9 && !string.IsNullOrEmpty(CellID7))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID1 == CellID5 && CellID5 == CellID9 && !string.IsNullOrEmpty(CellID1))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID3 == CellID5 && CellID5 == CellID7 && !string.IsNullOrEmpty(CellID3))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID1 == CellID4 && CellID4 == CellID7 && !string.IsNullOrEmpty(CellID1))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID2 == CellID5 && CellID5 == CellID8 && !string.IsNullOrEmpty(CellID2))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (CellID3 == CellID6 && CellID6 == CellID9 && !string.IsNullOrEmpty(CellID3))
            {
                Message = CurrentPlayerName + " Won!";
            }
            else if (!string.IsNullOrEmpty(CellID1) && !string.IsNullOrEmpty(CellID2) && !string.IsNullOrEmpty(CellID3) 
                && !string.IsNullOrEmpty(CellID4) && !string.IsNullOrEmpty(CellID5) && !string.IsNullOrEmpty(CellID6) 
                && !string.IsNullOrEmpty(CellID7) && !string.IsNullOrEmpty(CellID8) && !string.IsNullOrEmpty(CellID9))
            {
                Message = "It's a tie!";
            }
            //switch player
            SwitchPlayer();
        }
        public void SwitchPlayer()
        {
            //determine current player
            
            if (PlayerX.isTurn)
            {
                PlayerO.isTurn = true;
                PlayerX.isTurn = false;
            }
            else
            {
                PlayerX.isTurn = true;
                PlayerO.isTurn = false;
            }
            if (PlayerX.isTurn)
            {
                CurrentPlayerName = Xname;            
            }
            else
            {
                CurrentPlayerName = Oname;
            }
            turnMessage = CurrentPlayerName + "'s turn";
        }
        public void NewGame()
        {
            PlayerX = new Player();
            PlayerO = new Player();
            CurrentPlayerName = Xname;
            PlayerX.isTurn = true;
            PlayerO.isTurn = false;
            CellID1 = null;
            CellID2 = null;
            CellID3 = null;
            CellID4 = null;
            CellID5 = null;
            CellID6 = null;
            CellID7 = null;
            CellID8 = null;
            CellID9 = null;
            Message = null;
            turnMessage = CurrentPlayerName + "'s turn";
        }
    }
}
