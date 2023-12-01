class Menu
{
    //Fält
    public int SelectedIndex; 
    public string[] Options; 
    public string Prompt;

   
    //Konstruktor
    public Menu(string prompt, string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectedIndex = 0;

    }
    //display metod
    private void DisplayOptions()
    {   //skriver ut prompt
        System.Console.WriteLine(Prompt);
        //skriver ut samtliga options och highlightar med hjälp av om i är samma som selectedindex och if satser
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOptions = Options[i];
            if(i == SelectedIndex )
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            System.Console.WriteLine($" >> {currentOptions} <<");
        }
        Console.ResetColor();
    }
    //kör en menu och returnerar alltid det index från options array som vi använder klickar enter på så vi alltid kan använda oss av en enkel switch sats.
    public int Run()
    {
        ConsoleKey keyPressed;
        //do whilen hjälper till så vi alltid visar något till vi klickar enter samt nedan är knapptryck logiken vilket är rätt enkelt
        do 
        {
            Console.Clear();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);                      //0                   
            keyPressed = keyInfo.Key;                                            //1
            if(keyPressed == ConsoleKey.UpArrow)                                 //2       
            {                                                                    //3

                SelectedIndex--;
                if(SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length - 1; 
                    
                }
            }
            else if(keyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if(SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0; 
                    
                }
            }
        } 
        // när vi inte klickar enter då körs loopen alltså om vi klickar pilarna i detta fallet, när vi väl klickar enter jo då returnar vi selectedindex som lätt kan användas som argument i en switch sats 
        while(keyPressed != ConsoleKey.Enter);

        return SelectedIndex; 
    }
    
}