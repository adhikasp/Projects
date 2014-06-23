/*

Belum Jadi!!
Belum menemukan rumus nyari digit ke-N Pi yg benar.

*/


#include <iostream>
#include <math.h>

using namespace std;

double piDigit(int urutan);

int main()
{
    cout << "hello world" << endl;
    cout << piDigit(100);
}

double piDigit(int urutan)
{
    double hasil = 0;
    double temp;
    for (int n = 0; n <= urutan; ++n)
    {
        temp = ( -(32 / (4*n + 1)) - (1 / 4*n + 3) + (256 / 10*n + 1) - (64 / 10*n + 3) - (4 / 10*n + 5) - (4 / 10*n + 7) + (1 / 10*n + 9) );
        temp /= pow(1024, n);
        hasil += (n % 2 == 0) ? temp : -temp;
        cout << temp << endl;
    }
    hasil /= 64;

    return hasil;
}
