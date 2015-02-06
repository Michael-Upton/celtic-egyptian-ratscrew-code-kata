using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelticEgyptianRatscrewKata;
using NUnit.Framework;

namespace CelticEgyptianRatscrewAcceptanceTests
{
    [TestFixture]
    public class AcceptanceTests
    {
        [Test]
        public void GameThatEndsWithTheDarkQueen()
        {
            var testDeck = DeckEndingWithDarkQueen();

            const string tobyId = "Toby";
            const string michaelId = "Michael";

            var game = new GameBuilder()
                .WithStackedDeck(testDeck)
                .AddPlayer(tobyId)
                .AddPlayer(michaelId)
                .Start();

            var toby = game.Players[tobyId];
            var michael = game.Players[michaelId];

            while (michael.HasCards())
            {
                toby.PlayCard();
                michael.PlayCard();
                Assert.That(game.GetWinner(), Is.EqualTo(Maybe<Player>.Nothing));
            }
            toby.Snap();
            Assert.That(game.GetWinner(), Is.EqualTo((Maybe<Player>)toby));
        }

        private static Cards DeckEndingWithDarkQueen()
        {
            var queenOfSpades = Rank.Queen.Of(Suit.Spades);
            var testDeck = new Cards(Cards.Deck().Where(card => !card.Equals(queenOfSpades)).Concat(new[] {queenOfSpades}));
            return testDeck;
        }
    }
}
