#include <iostream>

using namespace std;
typedef unsigned long long ulong;

ulong factorialRecursion (int n);
ulong factorialLoop      (int n);

int main()
{
    int factor;

    cout << "======================" << endl;
    cout << "=  Factorial Finder  =" << endl;
    cout << "======================" << endl;
    cout << "The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1 and the factorial of zero, 0, is defined as being 1. Solve this using both loops and recursion." << endl;
    cout << endl;

    cout << "Factorial : ";
    cin  >> factor;

    cout << factor << "! = " << factorialRecursion(factor) << endl;
    cout << endl;
}

ulong factorialRecursion(int n)
{
    if (n < 2) {
        return 1;
    } else {
        return n * factorialRecursion(n-1);
    }
}

ulong factorialLoop(int n)
{
    int result = 1;
    for (int i = 2; i <= n; ++i) {
        result *= i;
    }
    return result;
}
