
int monster_health = 10;
int hero_health = 10;
Random dice = new Random();


do
{
    int hero_attack = dice.Next(1, 11);
    monster_health = monster_health - hero_attack;
    Console.WriteLine("The hero strikes for + " + hero_attack+" monster health is " +monster_health);
    if (monster_health > 0)
    {
        int monster_attack = dice.Next(1, 11);
        hero_health -= monster_attack;
        Console.WriteLine("the monster attacks for  " + monster_attack + " hero health is " + hero_health);
    }
    if (monster_health <= 0) Console.WriteLine("the hero wins");
    else if (hero_health <= 0) Console.WriteLine("the monster wins");

} while (monster_health > 0 && hero_health >0 );
