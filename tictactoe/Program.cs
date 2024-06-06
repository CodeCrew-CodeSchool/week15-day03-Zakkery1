namespace tictactoe;

class Player{
    public string marker;
    public string id;
}

class Program


{
    static void Main(string[] args)
    {

        string[][] gameBoard = [
                ["1", "2", "3"],
                ["4", "5", "6"],
                ["7", "8", "9"]
            ];
        
        Player player1 = new Player();
        player1.id = "1";
        player1.marker = "X";

        Player player2 = new Player();
        player2.id = "2";
        player2.marker = "O";

        Player currentPlayer = player1;

        bool gameOver = false;

        Console.WriteLine("Welcome to the TicTacToe game!");
        Console.WriteLine("Press any key to continue...\n"); 
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("You are player 1 / X");
        Console.WriteLine("Press any key to continue...\n"); 
        Console.ReadLine();

        Console.Clear();

        while(gameOver != true){
            DisplayBoard(gameBoard);
            

            Console.WriteLine($"{currentPlayer.id}: Make a move!");
            string playerChoice = Console.ReadLine();
            Console.Clear();

            GameBoard(gameBoard, currentPlayer, playerChoice);

            if(gameBoard[0][0] == gameBoard[0][1] && gameBoard[0][1] == gameBoard[0][2]){
                gameOver = true;
            Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[1][0] == gameBoard[1][1] && gameBoard[1][1] == gameBoard[1][2]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[2][0] == gameBoard[2][1] && gameBoard[2][1] == gameBoard[2][2]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[0][0] == gameBoard[1][0] && gameBoard[1][0] == gameBoard[2][0]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[0][1] == gameBoard[1][1] && gameBoard[1][1] == gameBoard[2][1]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[0][2] == gameBoard[1][2] && gameBoard[1][2] == gameBoard[2][2]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[0][2] == gameBoard[1][1] && gameBoard[1][1] == gameBoard[2][0]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            } else if (gameBoard[0][0] == gameBoard[1][1] && gameBoard[1][1] == gameBoard[2][2]){
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer.id} won!");
            }

            // WinCondition(gameBoard, currentPlayer);

            if(currentPlayer.id == "1"){
                currentPlayer = player2;
            } else if(currentPlayer.id == "2"){
                currentPlayer = player1;
            }
        }
    }
    static void DisplayBoard(string[][] board){
        for(int i = 0; i<board.Length; i++){
            string[] row = board[i];
            for(int j = 0; j<row.Length; j++){
                string value = row[j];
                Console.Write($"| {value} |");
            }
            Console.WriteLine();
        }
    }

    static void GameBoard(string[][] gameBoard, Player currentPlayer, string playerChoice){
        for(int i = 0; i < gameBoard.Length; i++)  {
                for(int j = 0; j < gameBoard.Length; j++) {
                    if(playerChoice == gameBoard[i][j]){
                        gameBoard[i][j] = currentPlayer.marker;
                    }
                }
            }
    }
}

