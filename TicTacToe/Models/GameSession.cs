using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TicTacToe.Models
{
    public class GameSession
    {
        private const string GameKey = "tictactoe";
        private ISession session { get; set; }
        public GameSession(ISession session)
        {
            this.session = session;
        }
        public void SetGame(Game game)
        {
            session.SetObject(GameKey, game);
        }
        public Game GetGame() =>
            session.GetObject<Game>(GameKey) ?? new Game();
    }
}
