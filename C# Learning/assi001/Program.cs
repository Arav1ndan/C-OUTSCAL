
// Console.WriteLine("\n=================================================");
// Console.WriteLine("              MIDNIGHT PIZZA FIGHT              ");
// Console.WriteLine("=================================================");
// Console.WriteLine("In a bustling pizzeria on a busy Friday night...");
// Console.WriteLine("You, the Dought Master, created your magnum opus -\nthe perfect pizza suddenly, a sneaky Crust Bandit\nsnatches your masterpiece!");
// Console.WriteLine("-------------------------------------------------");
// Console.WriteLine("\nFueled by passion for your craft, you give chase..");
// Console.WriteLine("-------------------------------------------------");
// Console.WriteLine("Through winding alleys and crowded streets, you \npursue the pizza pilerer. Finally, the thief is \ncornered in a dead-end alley. It's time to recover \nyour stolen slice!");
// Console.WriteLine("-------------------------------------------------");
// Console.WriteLine("                       FIGHT!                    ");

Game game = new Game();
game.GameLoop();
class Player
{
    private int health = 100;
    private int maxHealth = 100;
    private int attackDamage = 20;
    private int healingCapasity = 15;

    private void SpawnPlayer()
    {
        Console.WriteLine("\n=================================================");
        Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕 ");
        Console.WriteLine("==================================================\n");
        Console.WriteLine("\nDough Master: That scoundrel won't escape with my creation!\n");
    }
    private int generateRandomNumberInRange(int min, int max)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(min, max);
        return randomNumber;
    }
    public int Health
    {
        get
        {
            return health;
        }
        private set
        {
            if (value < 0)
            {
                health = 0;
            }
            else if (value > 0)
            {
                health = maxHealth;
            }
            else
            {
                health = value;
            }
        }
    }
    public Player()
    {
        SpawnPlayer();
    }
    public int CalculateTotalDamage()
    {
        int additionalDamage = generateRandomNumberInRange(5, 15);
        int totalDamage = attackDamage + additionalDamage;
        return totalDamage;
    }
    public void ShowAttackDamage(int totalDamage)
    {
        Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
        Console.WriteLine("============================================");
        Console.WriteLine("Dough Master's attack dealt " + totalDamage + " damage! 🥊");
        Console.WriteLine("--------------------------------------------");
    }
    public void TakeDamage(int damageRecieved) => health -= damageRecieved;

    public int CalculateTotalHeal()
    {
        int additionalHeal = generateRandomNumberInRange(10, 20);
        int totalHeal = healingCapasity + additionalHeal;
        return totalHeal;
    }
    public void Heal(int healAmount) => health += healAmount;

    public void ShowHeal(int healAmount)
    {
        if (Health >= maxHealth)
        {
            Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
            Console.WriteLine("============================================");
            Console.WriteLine("     Dough Master is bursting with energy! 🚀    ");
            Console.WriteLine("--------------------------------------------");
        }
        else
        {
            Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
            Console.WriteLine("============================================");
            Console.WriteLine("Dough Master's heal restored " + healAmount + " hp! ☕");
            Console.WriteLine("--------------------------------------------");
        }
    }
    public void DisplayPlayerStats()
    {
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("              DOUGH MASTER'S STATS                ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Health :" + health + "/" + maxHealth);
        Console.WriteLine("Dough Slapper :" + attackDamage);
        Console.WriteLine("Espresso Shot ☕: " + healingCapasity);
        Console.WriteLine("Dough Slapper Boost 🌪️: 5 to 15");
        Console.WriteLine("Espresso Shot Boost ☕: 10 to 20");
    }

}
class Enemy

{
    private int health = 150;
    private int maxHealth = 150;
    private int attackDamage = 15;

    private void SpawnEnemy()
    {
        Console.WriteLine("\n=================================================");
        Console.WriteLine("  🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹 ");
        Console.WriteLine("==================================================\n");
        Console.WriteLine("\nCrust Bandit: This delectable pizza is mine now!");
        Console.WriteLine("\nYou'll never catch me, flour face!\n");

    }
    private int generateRandomNumberInRangeForEnemy(int min, int max)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(min, max);
        return randomNumber;
    }
    public int Health
    {
        get
        {
            return health;
        }
        private set
        {
            if (value < 0)
            {
                health = 0;
            }
            else if (value > 0)
            {
                health = maxHealth;
            }
            else
            {
                health = value;
            }
        }
    }
    public Enemy()
    {
        SpawnEnemy();
    }
    public int CalculateTotalDamage()
    {
        int additionalDamage = generateRandomNumberInRangeForEnemy(5, 15);
        int totalDamage = attackDamage + additionalDamage;
        return totalDamage;
    }
    public void ShowAttackDamage(int totalDamage)
    {
        Console.WriteLine("             🍕 PIZZA BATTLE 🍕                   ");
        Console.WriteLine("============================================");
        Console.WriteLine("Crust Bandit's attack dealt " + totalDamage + " damage! 🥊");
        Console.WriteLine("--------------------------------------------");
    }
    public void TakeDamage(int damageRecieved) => health -= damageRecieved;

    public void DisplayEnemyStats()
    {
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("               CRUST BANDIT'S STATS                ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Health :" + health + "/" + maxHealth);
        Console.WriteLine("Dough Slapper :" + attackDamage);
        //Console.WriteLine("Espresso Shot ☕: "+healingCapasity);
        Console.WriteLine("Dough Slapper Boost 🌪️: 5 to 15");
        Console.WriteLine("Espresso Shot Boost ☕: 10 to 20");
    }

}

class Game
{
    Player player = new Player();
    Enemy enemy = new Enemy();

    bool isGameExited = false;
    private void ShowBattleOptions()
    {
        Console.WriteLine("\n==================================================");
        Console.WriteLine("             🍕 PIZZA BATTLE OPTIONS 🍕             ");
        Console.WriteLine("==================================================");
        Console.WriteLine("  Choose your action:");
        Console.WriteLine("    [A] Attack the Crust Bandit 🥊");
        Console.WriteLine("    [H] Gulp an Espresso Shot ☕");
        Console.WriteLine("==================================================");
        Console.Write("  Your choice: ");
    }
    private void SpawnCharacter()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
    }
    private void PlayerAttack()
    {
        int totalDamage = player.CalculateTotalDamage();
        enemy.TakeDamage(totalDamage);
        player.ShowAttackDamage(totalDamage);
    }
    private void PlayerHeal()
    {
        int totalHeal = player.CalculateTotalHeal();
        player.Heal(totalHeal);
        player.ShowHeal(totalHeal);
    }
    private void EnemyAttack()
    {
        int totalDamage = enemy.CalculateTotalDamage();
        player.TakeDamage(totalDamage);
        enemy.ShowAttackDamage(totalDamage);
    }
    private void DisplayCharacterStats()
    {
        player.DisplayPlayerStats();
        enemy.DisplayEnemyStats();
    }
    private bool CheckGameOver()
    {
        if (enemy.Health <= 0)
        {
            ShowGameWin();
            return true;
        }
        if (player.Health <= 0)
        {
            ShowGameLose();
            return true;
        }
        return false;
    }
    private void ShowGameWin()
    {
        Console.Clear();
        Console.WriteLine("\n==================================================");
        Console.WriteLine("           🎉 PIZZA JUSTICE SERVED! 🎉              ");
        Console.WriteLine("==================================================");
        Console.WriteLine("The Dough Master has defeated the Crust Bandit!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The perfect pizza has been reclaimed 🍕           ");
        Console.WriteLine("The honor of Italian cuisine is restored!         ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("    Bon appétit, and thanks for playing! 👨‍🍳        ");
        Console.WriteLine("==================================================");
    }
    private void ShowGameLose()
    {
        Console.Clear();
        Console.WriteLine("\n==================================================");
        Console.WriteLine("              😭 PIZZA TRAGEDY! 😭                ");
        Console.WriteLine("==================================================");
        Console.WriteLine("The Dough Master has been outmaneuvered!           ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The Crust Bandit escapes with your masterpiece 🏃‍♂️");
        Console.WriteLine("Your pizzeria's reputation is in shambles 📉     ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("        Thanks for your valiant effort! 🎖️         ");
        Console.WriteLine("   Perhaps it's time to switch to calzones... 🥟   ");
        Console.WriteLine("==================================================");
    }
    private void InvalidInput() => Console.WriteLine("Invalid Input! , please give a valid input");
    private void ProcessBattleInput()
    {
        string playerChoise = GetInput();
        Console.Clear();

        switch (playerChoise)
        {
            case "A":
                PlayerAttack();
                if (CheckGameOver())
                    break;
                EnemyAttack();
                if (CheckGameOver())
                    break;
                DisplayCharacterStats();
                break;

            case "B":
                PlayerHeal();
                EnemyAttack();
                if (CheckGameOver())
                    break;
                DisplayCharacterStats();
                break;

            default:
                InvalidInput();
                break;
        }
    }
    private string GetInput()
    {
        string input = Console.ReadLine();
        return input.ToUpper();
    }
    private void DisplayGameStory()
    {
        Console.Clear();
        Console.WriteLine("\n==================================================");
        Console.WriteLine("            🍕 MIDNIGHT PIZZA FIGHT 🍕           ");
        Console.WriteLine("==================================================");
        Console.WriteLine("\nIn a bustling pizzeria on a busy Friday night...");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("You, the Dough Master, created your magnum opus -");
        Console.WriteLine("the perfect pizza🤌  Suddenly, a sneaky Crust Bandit");
        Console.WriteLine("snatches your masterpiece!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("\nFueled by passion for your craft, you give chase...");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Through winding alleys and crowded streets, you");
        Console.WriteLine("pursue the pizza pilferer. Finally, the thief is");
        Console.WriteLine("cornered in a dead-end alley. It's time to recover");
        Console.WriteLine("your stolen slice!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("                      FIGHT!                      \n");
    }


    private void ProcessBattleLoop()
    {
        do
        {
            ShowBattleOptions();
            ProcessBattleInput();
        } while (AreCharactersAlive());

    }
    private bool AreCharactersAlive() => player.Health > 0 && enemy.Health > 0;
    private void StartMenu()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("     Press S to Get Your Masterpiece BACK...     ");
        Console.WriteLine("     Press any other key to exit the game   ");
        Console.WriteLine("==================================================");
        ProcessStartMenuInput();
    }
    private void ExitGame()
    {
        Console.Clear();
        Console.WriteLine("Thanks for Playing Midnight Pizza Fight..");
        isGameExited = true;
    }
    private void ProcessStartMenuInput()
    {
        string PlayerInput = GetInput();
        

        if(PlayerInput == "S")
        {
            Console.Clear();
            SpawnCharacter();
            ProcessBattleLoop();
        }else{
            ExitGame();
        }
    }
    private void RestartMenu()
    {
        Console.WriteLine("\n==================================================");
        Console.WriteLine("     Press R to Restart...     ");
        Console.WriteLine("     Press any other key to exit the game   ");
        Console.WriteLine("==================================================");
        ProcessRestartMenuInput();
    }
    private void ProcessRestartMenuInput()
    {
        string restartGame = GetInput();
        if(restartGame == "R")
        {
            isGameExited = false;
        }else{
            ExitGame();
        }
    }
    public void GameLoop()
    {
        while(!isGameExited)
        {
            DisplayGameStory();
            StartMenu();
            if(!isGameExited)
			RestartMenu();
        }
    }
}