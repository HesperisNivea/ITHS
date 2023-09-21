using Snake;
using SnakeGame;

GameBoard gameBoard = new GameBoard();
SnakeBody snake = new SnakeBody();
Fruit apple = new Fruit();

gameBoard.BoardSetUp(gameBoard.Board);
gameBoard.UpdateScreen();


Console.ReadKey();