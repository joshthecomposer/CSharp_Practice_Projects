MeleeFighter melee = new MeleeFighter("Some Stanky Orc");
RangedFighter ranged = new RangedFighter("A Dirty, Filthy Archer");
MagicCaster magic = new MagicCaster("A Dang Ol' Wizard");

Actor enemy = melee;

Console.WriteLine("Welcome, brave warrior, to one on one pound town. Please, tell me your name. ");
string name = Console.ReadLine()!;
Player player = new Player(name);
Console.WriteLine($"Ok, {player.Name}. The attacks you have available are:");
for(int i = 0; i < player.Attacks.Count; i++)
{
    Console.WriteLine($"{i} - {player.Attacks[i].Name} - {player.Attacks[i].Damage} damage");
}
Console.WriteLine($"3 - Attempt to kick in the groin, instantly killing your target.");
Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine($"Your chosen enemy is {enemy.Name}. Are you ready to fight? (y),(n)");
string ready = Console.ReadLine()!;
if (ready.ToLower() == "y")
{
    Console.WriteLine($"Good luck, you're going to need it...");
    FightLoop();
}
else if (ready.ToLower() == "n")
{
    Console.WriteLine($"LOL too bad, you have to fight.");
    FightLoop();
}
else
{
    Console.WriteLine($"Uhhh... I'll take that as a yes.");
    FightLoop();
}
void FightLoop()
{
    
    int turn = 0;
    Console.WriteLine($"The fight begins. You and {enemy.Name} are readying up when {enemy.Name} suddenly charges at full speed, surprising you with a Rage attack.");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    melee.RageAttack(player);
    while (true) {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        switch (turn)
        {
            case 0:
                Console.WriteLine($"{player.Name}, it is your turn to attack. Select your move with 0-2");
                int playerAttackChoice = Convert.ToInt32(Console.ReadLine());
                switch (playerAttackChoice)
                {
                    case 0:
                        player.PerformAttack(enemy, player.Attacks[0]);
                        turn = 1;
                        break;
                    case 1:
                        player.PerformAttack(enemy, player.Attacks[1]);
                        turn = 1;
                        break;
                    case 2:
                        player.PerformAttack(enemy, player.Attacks[2]);
                        turn = 1;
                        break;
                    case 3:
                        player.KickInTheGroin(enemy, player);
                        turn = 1;
                        break;
                    default:
                        Console.WriteLine($"That's not an attack, you forfeit your turn.");
                        turn = 1;
                        break;
                }
                break;
            case 1:
                Console.WriteLine($"Alright, {enemy.Name}'s turn to attack.");
                enemy.PerformAttack(player, enemy.RandomAttack());
                turn = 0;
                break;
        }
        if (enemy.Health <= 0)
        {
            Console.WriteLine($"{enemy.Name} has died, you are victorious!");
            return;
        }
        if (player.Health <= 0)
        {
            Console.WriteLine($"{player.Name} was defeated... {enemy.Name} has won and will now marry {player.Name}'s mom.");
            return;
        }
    }
}