using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelticEgyptianRatscrewKata
{
    public class GameBuilder
    {
        private readonly IList<string> _players = new List<string>();

        public GameBuilder WithStackedDeck(Cards testDeck)
        {
            return null;
        }

        public GameBuilder AddPlayer(string playerId)
        {
            _players.Add(playerId);
            return this;
        }

        public Game Start()
        {
            if (!_players.Any())
            {
                throw new InvalidOperationException();
            }

            var players = _players.ToDictionary(pid => pid, _ => new Player());
            
            return new Game(new Players(players));
        }
    }
}
