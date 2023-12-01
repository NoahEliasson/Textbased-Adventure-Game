class GameMethods1
{
    Game game = new Game();
        public void RunCredits()
    {
        System.Console.WriteLine("This game is made as a groupassingment made By: Osman, Milad and Noah");
        System.Console.WriteLine("Thank you for Reading the credits, Press any key to return to the main menu... ");
        Console.ReadKey(true);
    }
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