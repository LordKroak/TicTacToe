using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using TicTacToe.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Place(int id)
        {
            var session = new GameSession(HttpContext.Session);
            var tictactoe = session.GetGame();
            tictactoe.Place(id);
            session.SetGame(tictactoe);
            return RedirectToAction("Index");
        }
        public IActionResult NewGame()
        {
            var session = new GameSession(HttpContext.Session);
            var tictactoe = session.GetGame();
            tictactoe.NewGame();
            session.SetGame(tictactoe);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            //create session
            var session = new GameSession(HttpContext.Session);
            var tictactoe = session.GetGame();
            session.SetGame(tictactoe);
            return View(tictactoe);
        }
    }
}
