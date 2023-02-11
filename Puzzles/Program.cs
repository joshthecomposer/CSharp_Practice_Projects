internal class Program
{
    private static void Main(string[] args)
    {
        // Coin Flip
        // We've likely all flipped a coin at least once in our lives when 
        // trying to decide on this or that. Flipping a coin in person is easy. 
        // But how would you write your own coin flip function? Write a function that returns 
        // "heads" or "tails" depending on the result you get.
        var watch = System.Diagnostics.Stopwatch.StartNew();
        // the code that you want to measure comes here

        Random r = new Random();

        string CoinFlip()
        {
            switch (r.Next(0, 2))
            {
                case 0: return "heads";
                case 1: return "tails";
            }
            return "";
        }

        Console.WriteLine("Coinflip is : " + CoinFlip());

        // Dice Roll
        // Once you have figured out coin flip, take your learning to the next level by creating a dice roller. Once again, think about what it is like to roll a die in real life. How could you replicate those actions in code?

        // Consider the following:

        // How many sides is your die? (We recommend you start with a standard 6-sided die but feel free to start wherever you like!)
        // How many results can we get based on how many sides there are? Write down all possible results if needed.
        // Tip: Make sure to return the value rolled at the end.

        // Bonus: Can you rewrite your function to accept a parameter for the number of sides so you can roll any number-sided die?

        int DiceRoll(int sides)
        {
            return r.Next(0, sides + 1);
        }

        Console.WriteLine("dice roll is : " + DiceRoll(20));

        List<int> StatRoll(int numRolls, int sidedDie)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numRolls; i++)
            {
                result.Add(DiceRoll(sidedDie));
            }
            return result;
        }

        StatRoll(5, 10).ForEach(x => Console.Write(" | Stat roll result : " + x));

        // Roll Until...
        // Write a new function that will roll your 6-sided die until you land on a certain result and tracks how many rolls occurred until it lands on the given number. For example, you could tell your code to keep rolling until your 6-sided die rolls the number 2. When you land on the number, return a string that says "Rolled a {number} after {count} tries". Tip: Do not hard-code the number you're looking for. Be able to accept any number.

        // Consider the following:

        // Do we know how many times our die will roll before it lands on the number we asked for? If not, how will this influence the logical options we have?
        // What would happen if we ask for a number that is not on our die? (i.e. What happens if we tell our die to roll until it lands on 8 on a 6-sided die?) How can we prevent or handle unwanted inputs?



        string RollUntil(long expectedRoll, int sides)
        {
            if (expectedRoll > sides)
            {
                return "Invalid input";
            }
            long count = 0;
            long currentRoll = 0;
            while (currentRoll != expectedRoll)
            {
                currentRoll = DiceRoll(sides);
                count++;
            }
            return $"Rolled {count} times to get {expectedRoll}";
        }


        Console.WriteLine("\n" + RollUntil(1, 20));

        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine("Completed in " + elapsedMs + " ms");

        Console.WriteLine("Enter size dice do you want to roll: ");
        object userInput = Console.ReadLine()!;
        if (Int32.TryParse((string)userInput, out int i))
        {
            Console.WriteLine("You rolled a "+DiceRoll(i));
        }
        else
        {
            Console.WriteLine("YOU DINGUS!!!!!");
        }
    }
}