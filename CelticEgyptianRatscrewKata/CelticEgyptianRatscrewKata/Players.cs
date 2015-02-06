using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public class Players
    {
        private readonly Dictionary<string, Player> _players;

        public Players(Dictionary<string, Player> players)
        {
            _players = players;
        }

        public Player this[string playerId]
        {
            get { return _players[playerId] ;}
        }
    }
}