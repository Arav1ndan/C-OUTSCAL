#include <iostream>
using namespace std;

class Player
{
    private:
    int health = 100;

    public:
    void Move()
    {
        cout << "The player can walk at 5km speed and run at 8km speed, he even can jump and sometimes he fly too.."<<endl;
        
    }
    void Fire();
    Player();

};
Player::Player()
{
    cout << "The hero of this World..\n";
    cout<< "To save the world from evil..\n";
    cout << "He is here...\n";

}
int main()
{
    Player myPlayObj;
    myPlayObj.Move();
    //myPlayObj.health;
}