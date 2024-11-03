#include <iostream>
using namespace std;

int main()
{
    int playerHeath;
    int enemyHealth;

    cout << "Enter the Health for the Player: ";
    cin>>playerHeath;
    
    cout <<"Enter the Health for the Enemy: ";
    cin>>enemyHealth;

    //cout << "Enter the Health for the Player: "<<playerHeath <<endl;
    //cout << "Enter the Health for the Player: "<< enemyHealth << endl;

    std::string whoWon;


    if(playerHeath == 100)
    {
        cout << "The Player Health is FULL" <<endl;
    }else if(playerHeath <= 50 && playerHeath > 0)
    {
        cout << "The Player Health is HALF" << endl;
    }else if (playerHeath <=0 )
    {
       cout << " The Player Health is ZERO" << endl;
    }
   
    if(playerHeath >= 0)
    {
        if(enemyHealth == 100)
        {
            cout << "Enemy Health is FULL" << endl;
        }else if(enemyHealth <= 50 )
        {
            cout << "Enemy Health is HALF" << endl;
        }else if (enemyHealth == 0)
        {
            cout << "Enemy Health is ZERO" << endl;
        }

    }
    if(playerHeath == 0 || enemyHealth == 0)
    {
        if(playerHeath == 0 && enemyHealth == 0)
        {
            cout << "GAMEOVER BOTH THE PLAYER AND ENEMY DIED..." << endl;
        }else{
            whoWon = (playerHeath == 0) ? "ENEMY WON" : "PLAYER WON" ;
            cout << "GAME OVER " << whoWon<< endl;
        }
    }
    //whoWon = (playerHeath == 0 || enemyHealth == 1 ) ? "Player Won" : "Enemy Won" ;

    //cout<< " Game Over :" <<whoWon << endl;

    //healthSta = (playerHeath  > 50) ? "Good" : "Bad";

    //cout<< "player health status " << healthStatus << endl;
}