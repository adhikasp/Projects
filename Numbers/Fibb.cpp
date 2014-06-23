#include <iostream>

using namespace std;

void fib(int n);

int main()
{
    int n;

    cout << "======================" << endl;
    cout << "= Fibonacci Sequence =" << endl;
    cout << "======================" << endl;
    cout << "Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number." << endl;
    cout << endl;

    cout << "Nth number : ";
    cin  >> n;
    cout << endl;

    fib(n);
}

void fib(int n)
{
    int a = 0;
    int b = 1;

    cout << "(1) ";
    for (int i = 0; i <= n; ++i)
    {
        b += a;
        a = b-a;
        cout << b << " ";
    }
}
