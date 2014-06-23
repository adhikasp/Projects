#include <iostream>
#include <math.h>

using namespace std;

void primeFactor(int number);
bool isPrime(int number);

int main()
{
    int number;

    cout << "=======================" << endl;
    cout << "= Prime Factorization =" << endl;
    cout << "=======================" << endl;
    cout << "Have the user enter a number and find all Prime Factors (if there are any) and display them." << endl;
    cout << endl;

    cout << "Enter a number : ";
    cin  >> number;
    cout << endl;

    primeFactor(number);
}

void primeFactor(int number)
{
    int prime = 2;
    int power = 0;
    int limit = sqrt(number) + 1;

    cout << "Searching prime factor..." << endl;
    cout << "\t" << number << " = ";
    while (prime < limit || number == 1)
    {
        if (number % prime == 0) {
            number /= prime;
            ++power;
        } else {
            if (power){
                if (prime == 2){
                    cout << prime << "^" << power;
                } else {
                    cout << " * " << prime << "^" << power;
                }
            }
            if (number == 1){
                break;
            }
            while(true) {
                if (prime == 2) {
                    ++prime;
                } else {
                    prime += 2;
                }
                if (isPrime(prime) || prime < limit){
                    power = 0;
                    break;
                }
            }
        }
    }
    cout << endl;
}

bool isPrime(int number)
{
    int limit;
    limit = sqrt(number) + 1;
    for (int i = 2; i <= limit; ++i)
    {
        if (number % i == 0){
            return false;
        }
    }
    return true;
}
