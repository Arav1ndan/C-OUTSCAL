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

        //cout << "random number: "<<randomDamage << endl;
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


int main()
{
    Player myPlayObj;
   
}