class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name, 120)
    {
        this.Attacks = new List<Attack>{
            new Attack("Punch", 20), 
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public void RageAttack(Enemy target)
    {
        Attack attack = RandomAttack();
        attack.Damage += 10;
        this.PerformAttack(target, attack);
    }
}