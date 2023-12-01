using System.Security.Cryptography.X509Certificates;

public class Character
{

    public string Name {get; set;}
    public int HealthPoints {get; set;}
    public int Power {get; set;}
    public string Weapon {get; set;}
    public int MaxHealthPoints {get; set;}
    public int Mana {get; set;}
    public int MaxMana {get; set;}

    public Character(string name, int healthPoints, int maxHealthPoints, int power, string weapon, int mana, int maxMana)
    {
        Name = name;
        MaxHealthPoints = maxHealthPoints;
        HealthPoints = healthPoints;
        Power = power; 
        Weapon = weapon;
        Mana = mana;
        MaxMana = maxMana;
    }
    public virtual void AttackSound() // exempel på polymorfism och overriding, tanken finns att lägga in "animationer" säg en pil i ascii art, metoden Archer.AttackSound/Move(); kan vara en enkel pil
    {
        System.Console.WriteLine("Thunk");
    }
}
public class Archer : Character
{
    public override void AttackSound()
    {
        System.Console.WriteLine("Swoosh");
    }
    public Archer(string name, int healthPoints, int maxHealthPoints, int power, string weapon, int mana, int maxMana ) : base (name, healthPoints, maxHealthPoints, power, weapon, mana, maxMana)
    {
        
    }
  
}
public class Knight : Character
{
    public override void AttackSound()
    {
        System.Console.WriteLine("Swingg");
    }
    public Knight(string name, int healthPoints, int maxHealthPoints, int power, string weapon, int mana, int maxMana ) : base (name, healthPoints, maxHealthPoints, power, weapon, mana, maxMana)
    {

    }
}



//klassarv polyformism 