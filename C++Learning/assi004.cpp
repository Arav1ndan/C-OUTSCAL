#include <iostream>
using namespace std;

void shooting()
{
    cout << "Player is Shooting.." << endl;
}
void healing()
{
    cout << "Player is Healing.." << endl;
}
void attacking()
{
    cout << "Player is Attacking.." << endl;
}
int main()
{
     int i = 0;
    for(int i =0 ;i< 10;i++)
    {
        shooting();
    }
    while( i < 5)
    {
        healing();
        i++;
    }

    i = 0;
    do{
        attacking();
        i++;
    }while( i < 7);
}