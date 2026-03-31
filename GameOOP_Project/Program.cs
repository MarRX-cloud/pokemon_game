class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public List<
    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }
    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.Health -= AttackPower;
        if (target.Health <= 0)
        {
            Console.WriteLine($"{target.Name} has been defeated!");
        }
        else
        {
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
        }
    }
}
