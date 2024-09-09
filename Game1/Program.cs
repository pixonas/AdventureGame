
Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your character's name:");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character's class (Warrior, Wizard, Archer)");
string charcacterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {charcacterType} find yourself at the edge of the dark forest \n" +
    $"Do you enter the forest ? (y or n)");

string choice1 = Console.ReadLine();
string dayTime;

if (choice1.ToLower() == "y")
{
    Console.WriteLine("You enter a forest at night, without knowing what is waiting for you.");
    dayTime = "night";
   

}
else
{
    Console.WriteLine("You decided to stay out of the forest and wait for daylight before entering.");
    dayTime = "day";
    
}
bool gameContinues = true;



while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Which path do you take, left or right? ");
    string direction = Console.ReadLine();
    if (dayTime == "night")
    {


        if (direction.ToLower() == "left")
        {
            Console.WriteLine("You stummble upon a big troll. Do you fight or flee?");
            string fightOrFlee = Console.ReadLine();
            if (fightOrFlee.ToLower() == "fight")
            {
                Random random = new Random();
                int luck = random.Next(1, 11);
                if (charcacterType == "warrior")
                {
                    luck += 3;
                }
                else if (charcacterType == "wizard")
                {
                    luck += 2;
                }
                else { luck += 1; }
                if (luck > 5)
                {
                    Console.WriteLine("You beat the troll!");
                    if (luck > 8)
                    {
                        Console.WriteLine("Troll dropped a treasure!");
                        gameContinues = false;
                    }
                }
                else
                {
                    Console.WriteLine("The troll was too strong, you died!");
                    gameContinues = false;
                }

            }
        }
        else
    {
        Console.WriteLine("You find a treasure!");
        gameContinues = false;


    }
    }
    
    else
    {
        if (direction.ToLower() == "left")
        {
            Console.WriteLine("You stummble upon a big snake. Do you fight or flee?");
            string fightOrFlee = Console.ReadLine();
            if (fightOrFlee.ToLower() == "fight")
            {
                Random random = new Random();
                int luck = random.Next(1, 11);
                if (charcacterType == "warrior")
                {
                    luck += 1;
                }
                else if (charcacterType == "wizard")
                {
                    luck += 3;
                }
                else { luck += 2; }
                if (luck > 5)
                {
                    Console.WriteLine("You beat the snake!");
                    if (luck > 8)
                    {
                        Console.WriteLine("Snake dropped a treasure!");
                        gameContinues = false;
                    }
                }
                else
                {
                    Console.WriteLine("The snake was too strong, you died!");
                    gameContinues = false;
                }

            }
        }
else
    {
        Console.WriteLine("You find a treasure!");
        gameContinues = false;


    }
    }

    
    
}

Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing the game !");
Console.ReadKey();
