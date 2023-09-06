
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
        player[i] += diceScore;
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