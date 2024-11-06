
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
game.DisplayGameStory();
Player player= new Player();
Enemy enemy= new();
class Player{
    private int health = 100;
    private int maxHealth = 100;
    private int attackDamage = 20;
    private int healingCapasity = 15;
    
    public int Health
    {
        get
        {
            return health;
        }
        private set
        {
            if(value < 0){
                health = 0;
            }else if (value > 0)
            {
                health = maxHealth;
            }else{
                health = value;
            }
        }
    }
    public Player()
    {
        SpawnPlayer();
    }
    private void SpawnPlayer()
    {
        Console.WriteLine("\n=================================================");
        Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕 ");
        Console.WriteLine("==================================================\n");
        Console.WriteLine("\nDough Master: That scoundrel won't escape with my creation!\n");
    }
}
class Enemy

{
    private int health = 150;
    private int maxHealth = 150;
    private int attackDamage = 15;

    public int Health
    {
        get
        {
            return health;
        }
        private set
        {
            if(value < 0){
                health = 0;
            }else if (value > 0)
            {
                health = maxHealth;
            }else{
                health = value;
            }
        }
    }
    public Enemy()
    {
        SpawnEnemy();
    }
    private void SpawnEnemy()
    {
        Console.WriteLine("\n=================================================");
        Console.WriteLine("  🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹 ");
        Console.WriteLine("==================================================\n");
        Console.WriteLine("\nCrust Bandit: This delectable pizza is mine now!");
        Console.WriteLine("\nYou'll never catch me, flour face!\n");

    }
}

class Game{
    public void DisplayGameStory()
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
}