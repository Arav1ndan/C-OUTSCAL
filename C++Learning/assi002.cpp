#include <iostream>
using namespace std;

int main()
{
    int playerHealth;
    bool isPlayerRange;
    bool isPlayerDefending;
    bool isPlayerAttacking;


    cout<< "Enter the Player Health :";
    cin >> playerHealth;
    
    cout<< "Is the Player in Range? (Press 1 if true or 0 is false:)";
    cin >> isPlayerRange;

    cout <<"Is the Player Attacking? (Press 1 if true or 0 is false:)";
    cin >> isPlayerAttacking;

    cout << "Is the Player Defending? (Press 1 if true or 0 is false:)";
    cin >> isPlayerDefending;
    if(isPlayerRange && !isPlayerAttacking)
    {
        cout << "The Enemy should Attack.." << endl;
    }
   if(isPlayerRange && isPlayerDefending)
   {
        cout << "The Enemy should Hold.." << endl;
   }

   if(isPlayerRange && playerHealth < 20 && isPlayerAttacking)
   {
        cout << "The Player should deliver a Range Attack.." << endl;
   }
   if(isPlayerRange && !isPlayerDefending && (playerHealth == 100 || playerHealth < 10))
   {
        cout << "The Enemy should do a Special Attack.." << endl;
   }

}