using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console; 
class Game
{
    int hpPot = 2;
    Character c; 
    Character treeEnemy = new Character("Tree", 30, 30, 10, "Twig", 10, 10); 
    Character mabel = new Character("Mabel", 1000, 1000, 20, "Magical wand", 100, 100);
    GameMethods gameMethods = new GameMethods();
    public void RunMainMenu()
    {
        
        string prompt = @"

                _____     ____   ____      _____               _____           ____        ______  _______        ______   
           ____|\    \   |    | |    | ___|\    \          ___|\    \     ____|\   \      |      \/       \   ___|\     \  
          /     /\    \  |    | |    ||    |\    \        /    /\    \   /    /\    \    /          /\     \ |     \     \ 
         /     /  \    \ |    | |    ||    | |    |      |    |  |____| |    |  |    |  /     /\   / /\     ||     ,_____/|
        |     |    |    ||    | |    ||    |/____/       |    |    ____ |    |__|    | /     /\ \_/ / /    /||     \--'\_|/
        |     |    |    ||    | |    ||    |\    \       |    |   |    ||    .--.    ||     |  \|_|/ /    / ||     /___/|  
        |\     \  /    /||    | |    ||    | |    |      |    |   |_,  ||    |  |    ||     |       |    |  ||     \_____|\ 
        | \_____\/____/ ||\___\_|____||____| |____|      |\ ___\___/  /||____|  |____||\____\       |____|  /|____ '     /|
         \ |    ||    | /| |    |    ||    | |    |      | |   /____ / ||    |  |    || |    |      |    | / |    /_____/ |
          \|____||____|/  \|____|____||____| |____|       \|___|    | / |____|  |____| \|____|      |____|/  |____|     | /
             \(    )/        \(   )/    \(     )/           \( |____|/    \(      )/      \(          )/       \( |_____|/ 
              '    '          '   '      '     '             '   )/        '      '        '          '         '    )/    
                                                                 '                                                   '     
Welcome to Our game What would you like to do? Use the arrow keys to cycle between options then use enter to confirm";
        string[] options = {"Play", "Credits", "Exit"};
        Menu mainMenu = new Menu(prompt, options);
        int selectedIndex = mainMenu.Run();
        switch(selectedIndex)
        {
            case 0:
                RunPlay();
            break;

            case 1:
                RunCredits();
            break;

            case 2:
                RunExit();
            break;
        }
    }
        static void DialogText(string text)
     
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(20); 
        }
    }

    public void ShowStats()
    {
        Console.Clear();
        System.Console.WriteLine(@"
  (                                  (     
  )\ )    *   )     (        *   )   )\ )  
 (()/(  ` )  /(     )\     ` )  /(  (()/(  
  /(_))  ( )(_)) ((((_)(    ( )(_))  /(_)) 
 (_))   (_(_())   )\ _ )\  (_(_())  (_))   
 / __|  |_   _|   (_)_\(_) |_   _|  / __|  
 \__ \    | |      / _ \     | |    \__ \  
 |___/    |_|     /_/ \_\    |_|    |___/  
                                            ");
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.WriteLine($"║                                              ║");
        Console.WriteLine($"║   HEALTH:            [   {c.HealthPoints}/{c.MaxHealthPoints}   ]           ║");
        Console.WriteLine($"║   POWER:             [   {c.Power}   ]              ║");
        Console.WriteLine("║      Press any key to return...              ║");
        Console.WriteLine("║                                              ║");
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ReadKey(true);
    }
    
    private void RunPlay()
    {
        Console.Clear();
        string prompt = @"
                      ...........     ............
                 ,..,'           ',.,'            ',..,
               ,' ,'               :                ', ',
             ,' ,'                 :                  ', ',
           ,' ,'                   :                    ', ',
         ,' ,'                     :                      ', ',
       ,' ,'                       :                        ', ',
     ,' ,'.......................  :  ........................', ',
   ,' ,'                         ',:,'                          ', ',
 ,'  '........................     '     .........................'  ',
  ''''''''''''''''''''''''''''';''''''';''''''''''''''''''''''''''''''
                                '''''''";
        string[] options = {"Create a class", "Help", };        
        Menu playMenu = new Menu(prompt, options);
        int selectedIndex = playMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                RunCharacterChoice();
            break; 

            case 1:
                Console.Clear();
                System.Console.WriteLine("Use the arrow keys to cycle between options then use enter to confirm! ");
                System.Console.WriteLine("Press any key to return to the beginning... ");
                Console.ReadKey(true);
                RunPlay();
            break;
        }
    }
    private void RunCredits()
    {
        gameMethods.FootSteps();
        System.Console.WriteLine("This game is made as a groupassingment made By: Osman, Milad and Noah");
        System.Console.WriteLine("Thank you for Reading the credits, Press any key to return to the main menu... ");
        Console.ReadKey(true);
        RunMainMenu();
    }
    private void RunExit()
    {   
        Console.Clear();
        System.Console.WriteLine("Thank you for playing, Press any key to exit... ");
        Console.ReadKey(true);
        Environment.Exit(0);
    }

    private void RunCharacterChoice()
    {   
        string prompt = @"
                        \_____________________/
                         \       __O__       /
                          \      =(_)=      /              +
         +                _\  ___________  /_         .  . . .
          . . +          ( \\/ ___   ___.\// )       +.. .. .+
          .. .. :         \    (o)) ((o)    /       ... .. . .
         .. : .. .:. .    (_)    /   \    (_)      ..+.. + ...+
         . .+ . ++. .       \:. (_   _) .:/         +  + :.. + :
          . __... . +        )::::\_/::::(            :. __  . .
          _(  \ __ .        (:::\_|_|_/:::)          __ /  )_
         (  \  (  \      __  \:::\_|_/:::/  __      /  )  /  )
          \  \  \  \    /  )  \:::::::::/  (  \    /  /  /  /
         ( \  \  \  \__/  /    |\:::::/|    \  \__/  /  /  //)
          \ \_ \_ \_     / ____| |___| |____ \     _/ _/ _/ /
           \            /_/ ||   |___|   || \_\            /
            \          /\   ||  (_____)  ||   /\          /
             \________/ \\  ||___________||  // \________/
______________\\_______//    |___________|   \\______//_________________
                  \______/_:                   :_\______/

Chose your character below";
        string[] options = {"Archer 10 Power 90 HP", "Knight 8 Power 100 HP"};
        Menu charachterMenu = new Menu(prompt, options);
        int selectedIndex = charachterMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                System.Console.Write("Chose your name: ");
                c = new Archer(Console.ReadLine(), 90, 90, 10, "Bow", 30, 30);
                RunMainPlayingMenu();
            break; 
 
            case 1: 
                System.Console.Write("Chose your name: ");
                c = new Knight(Console.ReadLine(), 110, 110, 8, "Sword", 25, 25);
                RunMainPlayingMenu();
            break; 
        }

    }
    public void RunMainPlayingMenu()
    {
        string prompt = $@"
  ^  ^  ^   ^      ___I_      ^  ^   ^  ^  ^   ^  ^
 /|\/|\/|\ /|\    /\-_--\    /|\/|\ /|\/|\/|\ /|\/|\
 /|\/|\/|\ /|\   /  \_-__\   /|\/|\ /|\/|\/|\ /|\/|\
 /|\/|\/|\ /|\   |[]| [] |   /|\/|\ /|\/|\/|\ /|\/|\
Welcome to the beginning young {c.Name} it looks like your in the woods, alone, what would you like to do? ";
        string[] options = {"Inventory", "Go explore", "Go train", "Show stats"};
        Menu charachterMenu = new Menu(prompt, options);
        int selectedIndex = charachterMenu.Run();

        switch(selectedIndex)
        {
            case 0:
                RunInventory();
                RunMainPlayingMenu();
            break; 
                
            case 1:
                gameMethods.FootSteps();
                string dialogText = $"You go and explore the dark woods you´re in, and you see something moving... you approach it with confidence as you have a {c.Weapon}";
                DialogText(dialogText);
                Thread.Sleep(2000);
                Console.Clear();
                AttackManager.StartBattle(c, treeEnemy);
                RunThankyouPage();
                RunVillageMainMenu();
            break;

            case 2:
                Console.Clear();
                System.Console.WriteLine("You dont have a training partner! Returning to the woods...");
                Thread.Sleep(3000);
                RunMainPlayingMenu();
            break;

            case 3:
                ShowStats();
                RunMainPlayingMenu();
            break;
        }
    }
    public void RunInventory()
    {
        string prompt = @"Welcome to you inventory>
  _________
 /\____;;___\
| /         /
`. ())oo() .
 |\(%()*^^()^\
 %| |-%-------|
 % \ | %  ))   |
 %  \|%________|
 "; 
            
        string[] options = {$"{hpPot}x healthpotion", "1 Gold", "Exit Inventory..."};
        Menu invMenu = new Menu(prompt, options);
        int selectedIndex =  invMenu.Run();  
        
        switch(selectedIndex)
        {
            case 0:
                Console.Clear();
                if (c.HealthPoints > c.MaxHealthPoints)
                {
                    System.Console.WriteLine("You have max healthpoints already");
                    c.HealthPoints = c.MaxHealthPoints;
                    if(hpPot < 0 )
                    {
                        c.HealthPoints += 10;
                        hpPot--; 
                        Console.WriteLine($"You drank a Health Potion! You now have {c.HealthPoints} HP!");
                        System.Console.WriteLine("Press any key to return to the inventory...");
                        Console.ReadKey(true);
                        RunInventory();                      
                    }
                }
                else
                {
                    Console.WriteLine("You don't have any Health Potions left.");
                    RunInventory();
                }
            break;
            case 1:
                Console.WriteLine("You indeed have 1 Gold, wonder what you can do with that... ");
                Console.ReadKey(true);
                RunInventory();
            break; 
            case 2:
                
            break;
        }
    }

    private void RunThankyouPage()
    {
        string dialogText = $"´Hello? Did you just chop that tree down? with that {c.Weapon}? Do you realize what you have done?! Whats your name young traveler?´ \n´{c.Name}? well {c.Name} you have saved us! come come with me and meet everyone, please. Come with me´\n\nYou are confused, who is this man? He has an axe on his back but you choose to trust and follow him\n\nYou reach a small village, destroyed and burnt, children running around and playing among the debris young people helping their eldery and then you hear a loud scream\n\n´EVERYONE!!! this traveler by the name of {c.Name} just chopped down the tree thats been tormenting the woods!´\n\nThe few people in the village turns around and greets you, they are hurt but they still walk up to you and show their gratitude\nOne old woman comes to you and says ´Welomce {c.Name}, my name is Mabel. You are welcome to stay here on your travels´\n\nYou show your thanks and wonders to yourself where did i even come from? Confusion fills your brain as you haven´t had much time to think about where you even are, you ignore it for now hoping you regain your memories shortly... ";
        DialogText(dialogText);
        Thread.Sleep(5500);
    }
    public void RunVillageMainMenu()
    {
        string prompt = @"  
                                                          
                              /\  //\\
                       /\    //\\///\\\        /\                                      *
                      //\\  ///\////\\\\  /\  //\\                                     (   
         /\          /  ^ \/^ ^/*  ^  ^ \/^ \/  ^ \                                    )\ ) 
        / ^\    /\  / ^   /  ^ (  ^ ^ ^   ^\ ^/  ^^  \                  \_/            (()/
       /^   \  / ^\/ ^ ^   ^ ` )  `    ^  \/ ^   ^  \       *          =(_)=-   /\||  /(|      /\||
      /  ^ ^ \/^  ^\ ^ ^ ^   ^ )\     ^   ___   ^   ^  \   /|\          / \        \\| (_\\|  //\\|     ^
     / ^ ^  ^ \ ^  _\________ (()/_____|  |_____^ ^  \    /||o\                //  \\ //  \\ //  \\    /|\      
    / ^^  ^ ^ ^\  /__________(((_)( _____________\ ^ ^ \ /|o|||\              |[]  []|[]  []|[]  []|   /|\
   /  ^  ^^ ^ ^  /__________)\ _ )\ ______________\  ^  /|||||o|\            &|  ||  %  ||  |  ||  |%  /|\ 
  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\          ooooooooooooooooooooooooooooooooooo
 / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |
/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo
ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo  \_/       .:'    .:'    .:'
Welcome to our village, as you can see its quite burnt down as you know the dragon is awake, it came 9 moons ago and ravaged our small village";
        string[] options = {"Ask around", "Approach the blacksmith", "Show stats", "Inventory"};
        Menu newVillageMenu = new Menu(prompt, options);
        int selectedIndex = newVillageMenu.Run();
        
            switch(selectedIndex)
            {
                case 0:
                    Console.Clear();
                    string dialogText = "You choose to ask around the village, you approach a child and asks him, what happend here?\n´Hello, you dont know? it was the dragon´\nYou dont know what he is talking about, this grows you anxious\n´Well you seem to know nothing traveler. The dragon has been asleep for centuries, this is what my father told me. It was not supposed to wake for another thousands of years\nAlthough it did, no one made preperations for this and here we are. Travelers who has been here have told us the dragon has nested in the capitals castle everyone has been brunt alive. \nWe know nothing about the state of the world, all we know is that we have to rebuild if it comes back...´\n\nYou walk back wondering to yourself, what is going on? You dont remeber anything and there is a dragon why does no one kill it? You seem to think for a while until you find it hopeless, you walk back... ";
                    DialogText(dialogText);
                    Thread.Sleep(4500);
                    RunVillageMainMenu();
                break; 

                case 1:
                    Console.Clear();
                    string dialogText1 = $"You choose to walk to the one shop that looks unharmed by the dragons wrath\n´Oh hello there´ A big man with a thick beard says ´I have not had a chance to thank you!´\nYou ask the bearded man why his shop is unharmed\nHe grins as he says ´I am the blacksmith of this town, i work with fire everyday so my shop is quite safe from the dragon´\n´If the dragon wanted to this shop would be burnt down aswell, melted. But he just passed this village letting out one single breath\n\nYou are shocked, did the dragon only let out one breath...\n\n´Well you sould visit Mabel you seem to be a bit hurt from that tree´\n\nYou hear a loud scream, thinking that the dragon is back it is the man that you first met in the woods, the one with the axe\n´Traveler! i harvested the evil Trees wood, this is strong wood! lets have a look at that {c.Weapon} of yours\n´Here blacksmith, could you please use this string wood to reinforce {c.Name}s {c.Weapon}´\nThe blacksmith nods and happily helps you as you have given them access to the woods once again.. ";
                    DialogText(dialogText1);
                    Thread.Sleep(3500);
                    Console.Clear();
                    System.Console.WriteLine(@$"It Appears you have gotten a stronger {c.Weapon}! Check your stats!");
                    Thread.Sleep(2000);
                    c.Power+=20;
                    RunVillageMainMenu2();
                break;

                case 2:
                    ShowStats();
                    RunVillageMainMenu();
                break;

                case 3: 
                    RunInventory();
                    RunVillageMainMenu();
                break; 
            }

    }
    public void RunVillageMainMenu2()
    {

        string prompt = @"  
                                                          
                              /\  //\\
                       /\    //\\///\\\        /\                                      *
                      //\\  ///\////\\\\  /\  //\\                                     (   
         /\          /  ^ \/^ ^/*  ^  ^ \/^ \/  ^ \                                    )\ ) 
        / ^\    /\  / ^   /  ^ (  ^ ^ ^   ^\ ^/  ^^  \                  \_/            (()/
       /^   \  / ^\/ ^ ^   ^ ` )  `    ^  \/ ^   ^  \       *          =(_)=-   /\||  /(|      /\||
      /  ^ ^ \/^  ^\ ^ ^ ^   ^ )\     ^   ___   ^   ^  \   /|\          / \        \\| (_\\|  //\\|      ^
     / ^ ^  ^ \ ^  _\________ (()/_____|  |_____^ ^  \    /||o\                //  \\ //  \\ //  \\    /|\      
    / ^^  ^ ^ ^\  /__________(((_)( _____________\ ^ ^ \ /|o|||\              |[]  []|[]  []|[]  []|   /|\
   /  ^  ^^ ^ ^  /__________)\ _ )\ ______________\  ^  /|||||o|\            &|  ||  %  ||  |  ||  |%  /|\ 
  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\          ooooooooooooooooooooooooooooooooooo
 / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |
/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo
ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo  \_/       .:'    .:'    .:'
Welcome to our village, as you can see its quite burnt down as you know the dragon is awake, it came 9 moons ago and ravaged our small village";
        string[] options = {"Go visit Mabel", "Ask around", "Approach the blacksmith", "Show stats"};
        Menu newVillageMenu = new Menu(prompt, options);
        int selectedIndex = newVillageMenu.Run();
        
            switch(selectedIndex)
            {
                case 0: 
                Console.Clear();
                string dialogTextMabel = $"You approach Mabel in her shelter you see some people around her she feels respected by the village\n\n´Hello {c.Name} you seem to have taken a look around our village then i wont explain to you what has happend here... closer´\n\nMabel takes a close look at you and you start feeling better as shes examning you\n\n´There you go, i have healed you, you know i am a witch although not in my prime anymore i can still do basic healing as such´\n\nYou are intrigued and ask her more about her abilites´\n\nMabel smiles ´Do you not know about magic, you posses it yourself, no common man can take a evil tree like that down, i can teach you the basic healing but the rest you need to learn on your own...\n´  ";
                DialogText(dialogTextMabel);
                AttackManagerMainMabel.StartBattle(c, mabel);// OBSOBS
                RunAfterTraining();

                break; 

                case 1:
                    Console.Clear();
                    string dialogText = "You choose to ask around the village, you approach a child and asks him, what happend here?\n´Hello, you dont know? it was the dragon´\nYou dont know what he is talking about, this grows you anxious\n´Well you seem to know nothing traveler. The dragon has been asleep for centuries, this is what my father told me. It was not supposed to wake for another thousands of years\nAlthough it did, no one made preperations for this and here we are. Travelers who has been here have told us the dragon has nested in the capitals castle everyone has been brunt alive. \nWe know nothing about the state of the world, all we know is that we have to rebuild if it comes back...´\n\nYou walk back wondering to yourself, what is going on? You dont remeber anything and there is a dragon why does no one kill it? You seem to think for a while until you find it hopeless, you walk back... ";
                    DialogText(dialogText);
                    Thread.Sleep(4500);
                    RunVillageMainMenu2();
                break; 
                
                case 2:
                    Console.Clear();
                    string dialogText1 = $"You choose to walk to the one shop that looks unharmed by the dragons wrath\n´Oh hello there´ A big man with a thick beard says ´I have not had a chance to thank you!´\nYou ask the bearded man why his shop is unharmed\nHe grins as he says ´I am the blacksmith of this town, i work with fire everyday so my shop is quite safe from the dragon´\n´If the dragon wanted to this shop would be burnt down aswell, melted. But he just passed this village letting out one single breath\n\nYou are shocked, did the dragon only let out one breath...\n\n´Well you sould visit Mabel you seem to be a bit hurt from that tree´\n\nYou hear a loud scream, thinking that the dragon is back it is the man that you first met in the woods, the one with the axe\n´Traveler! i harvested the evil Trees wood, this is strong wood! lets have a look at that {c.Weapon} of yours\n´Here blacksmith, could you please use this string wood to reinforce {c.Name}s {c.Weapon}´\nThe blacksmith nods and happily helps you as you have given them access to the woods once again.. ";
                    DialogText(dialogText1);
                    Thread.Sleep(3500);
                    c.Power+=20;// vapenuppgradring
                    RunVillageMainMenu2();
                break;

                case 3:
                    ShowStats();
                    RunVillageMainMenu2();
                break; 
            }

    }
    public void RunAfterTraining()
    {
        string dialogtext = $"You did great! This heal spell will prove itself useful in the future! what will you do now?\n\nYou Think for yourself and you decide you want to slay the dragon\nMabel laughs ´Thats ambitous, i wish you the best of luck on your travels {c.Name}";
        DialogText(dialogtext);
        Console.Clear();
        string dialogtext2 =$"After a good nights sleep you set out, with new a newly enforced {c.Weapon}, magical knowledge and information about the world today you feel confident in meeting this dragon many speaks of...";
        
    }
    
            
    
    
    


}
class GameMethods
{
    public void FootSteps()
    {
        Console.Clear();
        Console.Write(@"      
                              (/--.   
                                `-'");
        Thread.Sleep(600);
        Console.Write(@"   
                                      ,-. 
                                    (\--'");
        Thread.Sleep(600);
        Console.Write(@"
                                                   (/--. 
                                                     `-'");
        Thread.Sleep(600);
        Console.Write(@"
                                                          ,-.
                                                        (\--'");
        Thread.Sleep(600);
        Console.Write(@"
                                                                     (/--.
                                                                       `-'");
        Thread.Sleep(600);
        Console.Write(@"                                                     
                                                                              ,-. 
                                                                            (\--'");  
        Thread.Sleep(600);        
        Console.Clear();                                                         
    }
}