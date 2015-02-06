using System;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class GameBuilderTests
    {
        [Test]
        public void CantStartAGameWithoutPlayers()
        {
            var gameBuilder = new GameBuilder();
            Assert.Throws<InvalidOperationException>(() => gameBuilder.Start());
        }

        [Test]
        public void CanStartAGameWithOnePlayer()
        {
            var gameBuilder = new GameBuilder();
            
            gameBuilder.AddPlayer("Michael");
            var game = gameBuilder.Start();

            Assert.That(game.Players["Michael"], Is.Not.Null);
        }

    }
}
