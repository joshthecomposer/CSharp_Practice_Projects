Enemy e1 = new Enemy("Orc");

Attack a1 = new Attack("Heavy Overhead", 10);
Attack a2 = new Attack("Light Side Swipe", 5);
Attack a3 = new Attack("Boop on the nose", 1);

List<Attack> attacks = new List<Attack>{a1, a2, a3};
e1.Attacks = attacks;

e1.RandomAttack();
