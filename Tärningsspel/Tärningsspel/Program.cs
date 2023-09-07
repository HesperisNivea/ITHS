 using System.Reflection;


void FirstAttempt()
{

    int[] players = new int[4] { 0, 0, 0, 0 }; // 
    int turn = 6;
    Turn(players);
    //while (turn > 0)
    //{

    //}
    static void Turn(int[] player)
    {
        Random dice = new Random();

        int[] playerDiceScore = new int[player.Length];

        for (int i = 0; i < player.Length; i++)
        {
            int diceScore = dice.Next(7);
            playerDiceScore[i] = diceScore;
        }

        Calculate(playerDiceScore);

    }

    static void Calculate(int[] diceScore)
    {
        int[] winner = new int[4] { diceScore[0], diceScore[1], diceScore[2], diceScore[3] };

        for (int i = 0; i < winner.Length - 1; i++)
        {

            for (int j = 0; j < winner.Length - 1; j++)
            {


                if (winner[j] > winner[j + 1])
                {
                    int potentialWinner = winner[j + 1];
                    winner[j + 1] = winner[j];
                    winner[j] = potentialWinner;
                }


            }

        }

        foreach (int element in winner)
        { Console.WriteLine(element); }

        Console.WriteLine(diceScore[3]);
    }
}

void SecoundAttempt()  
{
   

    (string playerID, int gameScore, int diceScore)[] players = new (string playerID, int gameScore, int diceScore)[4]
    {
    ("Mikael", 0, 0),
    ("Izabela", 0, 0),
    ("Tiina", 0, 0),
    ("Joseph", 0, 0),
    };

    for (int i = 0; i < 6; i++)
    {
        PlayTurn(players);

    }
    DeclareWinner(players);

    Console.ReadKey();

    void PlayTurn((string pI, int gS, int dS)[] players)
    {
        Random dice = new Random();

        for (int i = 0; i < players.Length; i++)
        {
            players[i].dS = dice.Next(1, 7);

        }
        CalculateScore(players);
    }

    void CalculateScore((string pI, int gS, int dS)[] players)
    {

        for (int i = 0; i < players.Length - 1; i++)
        {

            for (int j = 0; j < players.Length - 1; j++)
            {

                if (players[j].dS > players[j + 1].dS)
                {
                    (string, int, int) potentialWinner = players[j + 1];
                    players[j + 1] = players[j];
                    players[j] = potentialWinner;
                }
            }
        }

        Console.WriteLine($"{players[3].pI} won this round");


        int score = 5;

        for (int i = players.Length - 1; i > -1; i--)
        {
            if (i > 0)
            {
                if (players[i - 1].dS == players[i].dS)
                {
                    players[i].gS += score;
                    players[i - 1].gS += score;
                    score -= 2;
                    i--;
                }
                else
                {
                    if (score <= 0)
                    {
                        players[i].gS += 0;
                    }
                    else
                    {
                        players[i].gS += score;
                        score -= 2;
                    }
                }

            }
            else if (score <= 0)
            {
                players[i].gS += 0;
            }
            else
            {
                players[i].gS += score;
                score -= 2;
            }

        }

    }

    void DeclareWinner((string pI, int gS, int dS)[] players)
    {
        for (int i = 0; i < players.Length - 1; i++)
        {

            for (int j = 0; j < players.Length - 1; j++)
            {

                if (players[j].gS > players[j + 1].gS)
                {
                    (string, int, int) potentialWinner = players[j + 1];
                    players[j + 1] = players[j];
                    players[j] = potentialWinner;
                }
            }
        }
        Console.WriteLine("-----");
        Console.WriteLine($"Winner: {players[3].pI} with a score of {players[3].gS} points.");

    }

}  // done
