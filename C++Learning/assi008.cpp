#include <ctime>
#include <iostream>
using namespace std;

class Player

{
private:
    int health = 100;

    int minDamage = 15;
    int maxDamge = 25;

    int minHeal = 10;
    int maxHeal = 15;

public:
    Player()
    {
        cout << "The hero of this World..\n";
        cout << "To save the world from evil..\n";
        cout << "He is here...\n";
    }

    int GetHealth()
    {
        return health;
    }
    void TakeDamage(int damage)
    {
        if(health > 0)
        {
            cout <<"Player Health before getting damage: " << health <<endl;
            cout <<"Enemy is damageing the Player by :" << damage <<endl;
            health = health - damage;
            cout <<" Player Health after getting damage: " << health << endl;
        }else{
            cout <<" ohh ohh Player died.. better luck next time.." <<endl;
        }
    }
    int GiveDamage()
    {
        srand(time(0));
        int randomDamage = (rand() % (maxDamge - minDamage + 1) + minDamage);

        cout << "random number: "<<randomDamage << endl;
        return randomDamage;
       
    }
    void Heal()
    {
        srand(time(0));

        int randomHeal = (rand() % (maxHeal - minHeal + 1) + minHeal);

        cout << "Random heal value is :" << randomHeal << endl;
    }
    void Move();
    void Fire();
    
};

class Enemy
{
    private:
    int health = 100;

    int minDamage = 15;
    int maxDamge = 25;

    public :
    Enemy()
    {
        cout << "Those who come again me will die without mercy.." << endl;
        cout << "There is no one in this world to stop me from achieving what i want..." << endl;
        cout << "Dont waste my time you peasent.." << endl;
        cout << "Go back to the place you come from.." << endl;
        cout << "You cannot defeat me you fool..." << endl;
    }
     int GetHealth()
    {
        return health;
    }
    void TakeDamage(int damage)
    {
        if(health > 0)
        {
            cout <<"Enemy Health before getting damage: " << health <<endl;
            cout <<"Player is damageing the Enemy by :" << damage <<endl;
            health = health - damage;
            cout <<" Enemy Health after getting damage: " << health << endl;
        }else{ 
            cout <<"ahh.. ahhh.. ahh.... you are strong, i shall have my revenage..." <<endl;
        }
    }
    int GiveDamage()
    {
        srand(time(0));
        int randomDamage = (rand() % (maxDamge - minDamage + 1) + minDamage);

        cout << "random number: "<<randomDamage << endl;
        return randomDamage;
       
    }
};

int main()

{
    char userInput;
    do{
        cout << "Press S to start the game and any other key to exit the game." << endl;
        cin >>userInput ;
        if( userInput == 'S' || userInput == 's')
        {
            Player myPlayObj;
            Enemy enemObj;
            cout << "The enemy health is: " << enemObj.GetHealth() << endl;
            enemObj.TakeDamage(50);
            enemObj.GiveDamage();
            // cout << "The player Health is: " <<myPlayObj.GetHealth() <<endl;

            // myPlayObj.TakeDamage(50);
            // myPlayObj.GiveDamage();
            // myPlayObj.Heal();
        }else{
            cout <<"Thank you for Playing.." << endl;
        }
    }while (userInput == 'S' || userInput == 's');
   
   
    //myPlayObj.GiveDamage();
    //myPlayObj.Heal();
 
}