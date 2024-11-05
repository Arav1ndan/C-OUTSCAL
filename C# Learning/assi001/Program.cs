
Console.WriteLine("\n=================================================");
Console.WriteLine("              MIDNIGHT PIZZA FIGHT              ");
Console.WriteLine("=================================================");
Console.WriteLine("In a bustling pizzeria on a busy Friday night...");
Console.WriteLine("You, the Dought Master, created your magnum opus -\nthe perfect pizza suddenly, a sneaky Crust Bandit\nsnatches your masterpiece!");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("\nFueled by passion for your craft, you give chase..");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Through winding alleys and crowded streets, you \npursue the pizza pilerer. Finally, the thief is \ncornered in a dead-end alley. It's time to recover \nyour stolen slice!");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("                       FIGHT!                    ");

Player player= new Player();
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