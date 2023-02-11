MeleeFighter melee = new MeleeFighter("Some Stanky Orc");
RangedFighter ranged = new RangedFighter("Legolas");
MagicCaster magic = new MagicCaster("Gandalf");

// melee.PerformAttack(magic, melee.Attacks[2]);

// magic.PerformAttack(ranged, magic.RandomAttack());

magic.PerformAttack(melee, magic.RandomAttack());
Console.WriteLine(melee.Health);
magic.Heal(melee);
Console.WriteLine(melee.Health);


ranged.PerformAttack(melee, ranged.RandomAttack());

ranged.Dash();

ranged.PerformAttack(melee, ranged.RandomAttack());