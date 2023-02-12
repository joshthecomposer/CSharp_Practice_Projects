class Player : Actor
{

    public Player(string name) : base(name, 100)
    {
        this.Attacks = new List<Attack>{
            new Attack("Open Handed, full palm Smack", 20),
            new Attack("Bitch Slap", 15),
            new Attack("Poke in the eyes", 10)
        };
    }

    public void KickInTheGroin(Actor target, Actor player)
    {
        Random rand = new Random();
        if (rand.Next(1, 101) > 98)
        {
            Console.WriteLine($"{target.Name} was absolutely DUMPSTERD by a kick to the groin!");
            target.Health -= 1000;
        }
        else 
        {
            Console.WriteLine($"{player.Name} tried a dirty kick to the groin, but missed!");
        }
    }
}