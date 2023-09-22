using System.Transactions;
using Snake;
using SnakeGame;
using System.Drawing;

GameBoard gameBoard = new GameBoard();
SnakeBody snake = new SnakeBody();
Fruit apple = new Fruit();

gameBoard.BoardSetUp(gameBoard.Board);
GameMechanics.StartPositions(gameBoard,snake);
Console.ReadLine();
//gameBoard.UpdateScreen();
Console.ReadKey();

