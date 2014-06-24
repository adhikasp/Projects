#include <iostream>
#include <string>

using namespace std;

int calculateCost(int width, int height, int cost);

int main()
{
    int width, height, cost;

    cout << "==========================================" << endl;
    cout << "= Find Cost of Tile to Cover W x H Floor =" << endl;
    cout << "==========================================" << endl;
    cout << "Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user." << endl;
    cout << endl;

    cout << "Please enter the floor width, height, and cost (in IDR rupiah)." << endl;
    cout << "Width  : ";
    cin  >> width;
    cout << "Height : ";
    cin  >> height;
    cout << "Cost   : Rp ";
    cin  >> cost;
    cout << endl;

    cout << "Total cost : Rp " << calculateCost(width, height, cost) << endl;
    cout << endl;
}

int calculateCost(int width, int height, int cost)
{
    return width * height * cost;
}
