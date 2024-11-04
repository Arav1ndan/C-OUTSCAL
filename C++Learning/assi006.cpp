#include <iostream>
using namespace std;

void gameStory()
{
    cout << "Game Story... " << endl;
    cout << "Player Running shooting Enemy dies.." << endl;
    cout << "Player won.." << endl;
}
class Player
{
private:
    /* data */
public:
    int health;
    int attackPower;
    Player(int heal, int attack);
};

Player::Player(int heal, int attack)
{
    health = heal;
    attackPower = attack;
}

int main()
{
    gameStory();
    Player player = Player(24, 20);
    cout << "Health :"<<player.health << endl;
    cout << "Attack Power :"<< player.attackPower <<endl;
}