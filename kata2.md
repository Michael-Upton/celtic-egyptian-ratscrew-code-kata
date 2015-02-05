# Second kata session for Celtic Egyptian Ratscrew game

## Problem: basic game workflow
For this kata your job is to implement the minimal set of actions for the game that will allow a *red route* game to be played.

## Learning objective: ensuring your code doesn't become more tightly coupled as the solution gets more complex
Write tests as you go (you might want to use TDD). Aim to direct your tests at small pieces of functionality; this will help you keep your classes loosely coupled. You may find yourself using the [Dependency Inversion Principle](http://www.codeproject.com/Articles/615139/An-Absolute-Beginners-Tutorial-on-Dependency-Inver) to achieve this.

## Tasks
You will use the `SnapValidator` created in the previous kata. You may either use the one you created previously or start with the solution provided in the repository on GitHub. The provided solution also contains Card, Cards, Dealer, and Shuffler classes.

Enable a game to commence by writing code that
* Allows players to be added to the game
* Shuffles a deck of 52 cards and deals them out (as fairly as possible) amoungst the players.

Enable a game to be played by writing code that
* Allows any player to lay the card from the top of their pile onto the stack (don't enforce the order of play)
* Allows any player to snap the stack (using the `SnapValidator` to validate the snap):
  * If the snap is valid, the cards in the stack should be put onto the bottom of the player's pile, without shuffling them.
  * If the snap isn't valid, do nothing.

Enable the progress of a game to be tracked by writing code that
* Allows us to query whether there is a winning player at any point, and, if there is, who it is.
