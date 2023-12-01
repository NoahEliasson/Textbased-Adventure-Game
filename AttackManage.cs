using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class AttackManager
{
    public static void StartBattle(Character player, Character enemy)
    {
        Console.WriteLine($"You encounter a {enemy.Name} with {enemy.HealthPoints} HP!");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);

            while (enemy.HealthPoints > 0 && player.HealthPoints > 0)
            {
                Console.ReadKey(true);
                string prompt = $@"
╔══════════════════════════════════════════════╗                                                      ╔══════════════════════════════════════════════╗                                   
║                                              ║                                                      ║                                              ║
   [{HealthBar.GetHealthBar(player)} ]                                                                        [{HealthBar.GetHealthBar(enemy)} ]          
   POWER:      [ {player.Power} ]                                                                                     POWER:       [ {enemy.Power} ]                   
║                                              ║                                                      ║                                              ║
╚══════════════════════════════════════════════╝                                                      ╚══════════════════════════════════════════════╝
What will you do?";
                string[] options = { "Attack", "Inventory", "Run!" };
                Menu battleMenu = new Menu(prompt, options);
                int selectedIndex = battleMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Attack(player, enemy);
                    break;

                    case 1:
                    Game Inv = new Game(); 
                    Inv.RunInventory(); 
                    StartBattle(player, enemy);
                    break;

                    case 2:
                        Game mygame = new Game();
                        Console.Clear();
                        System.Console.WriteLine("You run back to the safety of the woods... You think to yourself... i am a coward");
                        mygame.RunMainPlayingMenu();
                        
                        break;
                }

                if (player.HealthPoints <= 0)
                {
                    Console.WriteLine("You were defeated!");
                }
                else if(enemy.HealthPoints <= 0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");

                }   
        }
        

    }
    public static void Attack(Character player, Character enemy)

    {
        
        Console.WriteLine($"You attack! You deal {player.Power} damage to the {enemy.Name}!");
        enemy.HealthPoints -= player.Power;

        if (enemy.HealthPoints > 0)
        {
            Console.WriteLine($"The {enemy.Name} retaliates and deals {enemy.Power} damage to you!");
            player.HealthPoints -= enemy.Power;
        }
    }

}
public class AttackManagerMain
{
    public static void StartBattle(Character player, Character enemy)
    {
        Console.WriteLine($"You encounter a {enemy.Name} with {enemy.HealthPoints} HP!");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);

            while (enemy.HealthPoints > 0 && player.HealthPoints > 0)
            {
                Console.ReadKey(true);
                string prompt = $@" Your fight has begun with {enemy.Name} 
╔══════════════════════════════════════════════╗                                                      ╔══════════════════════════════════════════════╗                                   
║                                              ║                                                      ║                                              ║
    [{HealthBar.GetHealthBar(player)} HP                                                                  [{HealthBar.GetHealthBar(enemy)} HP         
    POWER:      [  {player.Power} ]                                                                                  POWER:       [  {enemy.Power}   ]       
    MANA:       [  {player.Mana}/{player.MaxMana}  ]                                                                             MANA:     [  {enemy.Mana}/{enemy.MaxMana}  ]
║                                              ║                                                      ║                                              ║
╚══════════════════════════════════════════════╝                                                      ╚══════════════════════════════════════════════╝
What will you do?";
                string[] options = { "Attack", "Heal", "Special Attack",  "Inventory", "Run!" };
                Menu battleMenu = new Menu(prompt, options);
                int selectedIndex = battleMenu.Run();
                bool manaChecker = player.Mana <= 0;

                switch (selectedIndex)
                {
                    case 0:
                        Attack(player, enemy);
                            if(player.Mana < player.MaxMana)
                            {
                                player.Mana += 5;

                            }
                            if(player.Mana >= player.MaxMana)
                            {
                                player.Mana = player.MaxMana;
                            }
                                
                    break;

                    case 1:
                        if (player.HealthPoints < player.MaxHealthPoints)
                        { 

                            if(manaChecker)
                            {
                                Random random = new Random();
                                int healAmount = random.Next(10, 30);
                                player.HealthPoints += healAmount;
                                player.Mana -= 5;
                                System.Console.WriteLine($"You used a heal spell, you gained {healAmount} HP ");
                                System.Console.WriteLine("Press enter to continue");
                            }
                            else
                            {
                                System.Console.WriteLine("You dont have enough mana to heal! requierd mana is 5");
                            }

                            
                        }

                        if (player.HealthPoints >= player.MaxHealthPoints )
                        {
                            player.HealthPoints = player.MaxHealthPoints;
                            System.Console.WriteLine("You now have max HP");
                            System.Console.WriteLine("Press enter to continue");
                        }

                    break
                    ;
                    case 2:
                        if(player.Mana == player.MaxMana)
                        {
                            System.Console.WriteLine($"{player.Name} used his special attack, unique for the {player.Weapon} and it deals {player.Power * 2} damage! This drains your mana to 0");
                            enemy.HealthPoints -= player.Power *= 2;
                            player.Power /= 2;
                            player.Mana = 0;    
                        }
                        else
                        {
                            System.Console.WriteLine($"You dont have enough mana, mana requierd is {player.MaxMana}");
                        }
                    break; 

                    case 3:
                        Game mygame = new Game();
                        Console.Clear();
                        System.Console.WriteLine("You run back to the safety of the woods... You think to yourself... i am a coward");
                        mygame.RunMainPlayingMenu();
                    break;
                }

                if (player.HealthPoints <= 0)
                {
                    Console.WriteLine("You were defeated!");
                }
                else if(enemy.HealthPoints <= -0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");
                }   
        }   

    }
    public static void Attack(Character player, Character enemy)

    {
        Console.WriteLine($"You attack! You deal {player.Power} damage to the {enemy.Name}!");
        enemy.HealthPoints -= player.Power;

        if (enemy.HealthPoints > 0)
        {
            Console.WriteLine($"The {enemy.Name} retaliates and deals {enemy.Power} damage to you!");
            player.HealthPoints -= enemy.Power;
        }
    }
    
}



public class AttackManagerMainMabel
{
    public static void StartBattle(Character player, Character enemy)
    {
        Console.WriteLine($"You encounter a {enemy.Name} with {enemy.HealthPoints} HP!");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
            while (enemy.HealthPoints > 0 && player.HealthPoints > 0)
            {
                Console.ReadKey(true);
                string prompt = $@"Let´s begin {player.Name} as you can see with magic there is a limit in the form of Mana, if you heal you use up a bit of mana and only heal 10-30 Hp depending on your focus!\nYou can also preform a more powerful attack using a great deal of mana, try it!  
╔══════════════════════════════════════════════╗                                                      ╔══════════════════════════════════════════════╗                                   
║                                              ║                                                      ║                                              ║
    [[{HealthBar.GetHealthBar(player)} HP                                                                    [[{HealthBar.GetHealthBar(player)} HP         
    POWER:      [  {player.Power} ]                                                                                  POWER:       [  {enemy.Power}   ]       
    MANA:       [  {player.Mana}/{player.MaxMana}  ]                                                                               MANA:     [  {enemy.Mana}/{enemy.MaxMana}  ]
║                                              ║                                                      ║                                              ║
╚══════════════════════════════════════════════╝                                                      ╚══════════════════════════════════════════════╝
What will you do?";
                string[] options = { "Attack", "Heal", "Special Attack",  "Inventory", "Run!" };
                Menu battleMenu = new Menu(prompt, options);
                int selectedIndex = battleMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Attack(player, enemy);
                        if(player.Mana < player.MaxMana)
                        {
                            player.Mana += 5;
                        }

                        if(player.Mana >= player.MaxMana)
                        {
                            player.Mana = player.MaxMana;
                        }
                        break;

                    case 1:
                        if (player.HealthPoints < player.MaxHealthPoints)
                        {
                            Random random = new Random();
                            int healAmount = random.Next(10, 30);
                            player.HealthPoints += healAmount;
                            player.Mana -= 5;
                            System.Console.WriteLine($"You used a heal spell, you gained {healAmount} HP ");
                            System.Console.WriteLine("Press enter to continue");
                        }

                        if (player.HealthPoints >= player.MaxHealthPoints )
                        {
                            player.HealthPoints = player.MaxHealthPoints;
                            System.Console.WriteLine("You now have max HP");
                            System.Console.WriteLine("Press enter to continue");
                        }
                    break;

                    case 2:
                        System.Console.WriteLine($"{player.Name} used his special attack, unique for the {player.Weapon} and it deals {player.Power * 2} damage! This drains your mana to 0");
                        enemy.HealthPoints -= player.Power *= 2;
                        player.Power /= 2;
                        player.Mana = 0;
                    break; 

                    case 3:
                        Game mygame = new Game();
                        Console.Clear();
                        System.Console.WriteLine("You run back to the safety of the woods... You think to yourself... i am a coward");
                        mygame.RunMainPlayingMenu();
                        
                        break;
                }

                if (player.HealthPoints <= 0)
                {
                    Console.WriteLine("You were defeated!");
                }
                else if(enemy.HealthPoints < 0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");
                }   
        }

    }
    public static void Attack(Character player, Character enemy)

    {
        Console.WriteLine($"You attack! You deal {player.Power} damage to the {enemy.Name}!");
        enemy.HealthPoints -= player.Power;

        if (enemy.HealthPoints > 0)
        {
            Console.WriteLine($"The {enemy.Name} retaliates and deals {enemy.Power} damage to you!");
            player.HealthPoints -= enemy.Power;
        }
    }

} 
class HealthBar
{
    public static string GetHealthBar(Character player)
{   
    StringBuilder healthBar = new StringBuilder(); // StringBuilder eftersom jag inte kan lägga in direkta variabler i min string prompt fick det bli såhär, kolla vidare på stringbuilder + 

    float healthPercentage = (float)player.HealthPoints / player.MaxHealthPoints;

    int numberOfCharacters = (int)(healthPercentage * 20);
        healthBar.Append("\u001b[32m");

    for (int i = 0; i < numberOfCharacters; i++)
    {
        healthBar.Append("=");
    }
        healthBar.Append("\u001b[0m");
        healthBar.Append("\u001b[31m");

    for (int i = numberOfCharacters; i < 20; i++)
    {
        healthBar.Append("-");

    }
        healthBar.Append("\u001b[0m");

    healthBar.Append($" {player.HealthPoints}/{player.MaxHealthPoints} HP");

    return healthBar.ToString();
}


}