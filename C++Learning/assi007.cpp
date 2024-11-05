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
    int GiveDamage(int damage)
    {
        if(health > 0)
        {
            cout <<"Player Health before getting damage: " << health <<endl;
            health = health - damage;
            cout <<" Player Health after getting damage: " << health << endl;
        }else{
            cout <<" ohh ohh Player died.. better luck next time.." <<endl;
        }
    }
    int TakeDamage()
    {

    }
    int Heal()
    {
        
    }
    void Move();
    void Fire();
    
};


int main()
{
    Player myPlayObj;
    myPlayObj.Move();
    // myPlayObj.health;
}