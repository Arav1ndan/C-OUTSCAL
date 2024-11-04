#include <iostream>
using namespace std;

int health = 100;
int attack = 20;
int defense = 15;
int healingPower = 25;
void TakeDamage(int damageToInflict);
void Heal(int healthToRecover );
void DamageMultiplier(int multiplier);

int main()
{

    cout << " Player statics " << endl;
    cout << "health :" << health << endl;
    cout << "attack :" << attack << endl;
    cout << "defense :" << defense << endl;
    cout << "Healing Power :" << healingPower << endl;

    TakeDamage(attack);
    Heal(healingPower);
    DamageMultiplier(2);
}
void TakeDamage(int damageToInflict)
{
    if (health > 0)
    {
        cout << "Player Health before Damage: " << health << endl;
        health = health - damageToInflict;
        cout << "Player Health after Damage: " << health << endl;
    }else{
        cout << "Player Health is Zero Can't Take anymore Damage.." << health << endl;
    }
}
void Heal(int healthToRecover)
{
    if(health < 100)
    {
        health = health + healthToRecover;
        if(health > 100)
        {
            health = 100;
        }
        cout << "Player Health after Healing: " << health << endl;
    }
}
void DamageMultiplier(int multiplier)
{
    attack =  attack * multiplier;
    cout << "Player Attack Power is Multiplyed..." << attack << endl;
}