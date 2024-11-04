#include <iostream>
using namespace std;

int main()
{
    int num;
    cout << "Enter the number to get the sum..";
    cin >> num;
    int res;

    for(int i = 1; i <= num; i++)
    {
        res = res + i; 
    }
    cout << "Sum of the N number is : " << res << endl;
}