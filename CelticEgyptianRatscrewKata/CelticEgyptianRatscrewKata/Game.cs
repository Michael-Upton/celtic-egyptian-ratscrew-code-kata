namespace CelticEgyptianRatscrewKata
{
    public class Game
    {
        private readonly Players _players;

        public Game(Players players)
        {
            _players = players;
        }

        public Players Players
        {
            get { return _players; }
        }

        public Maybe<Player> GetWinner()
        {
            return null;
        }
    }
}