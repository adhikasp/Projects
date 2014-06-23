#include <iostream>
#include <vector>
#include <math.h> // sqrt
#include <chrono>

#define LIMIT 1000000

// Buat timer lamanya eksekusi code, C++11.
// http://stackoverflow.com/questions/1861294/how-to-calculate-execution-time-of-a-code-snippet-in-c
class Timer
{
    public:
        Timer() : beg_(clock_::now()) {}
        void reset() { beg_ = clock_::now(); }
        double elapsed() const {
            return std::chrono::duration_cast<second_>
                (clock_::now() - beg_).count(); }

    private:
        typedef std::chrono::high_resolution_clock clock_;
        typedef std::chrono::duration<double, std::ratio<1> > second_;
        std::chrono::time_point<clock_> beg_;
};

using std::cout;
using std::endl;
using std::vector;

int main()
{
    Timer tmr;
    typedef unsigned int uint;

    vector<uint> list_prima;
    bool prima;
    uint batas;

    list_prima.push_back(2);

    for (uint i = 3; i < LIMIT; i += 2)
    {
        prima = true;
        batas = sqrt(i) + 1;
        for (uint x: list_prima)
        {
            if (i % x == 0) {
                prima = false;
                break;
            } else if (x > batas) {
                break;
            }
        }

        if (prima) {
            list_prima.push_back(i);
        }
    }
    /*
    for (uint x: list_prima){
        cout << x << " ";
    }*/

    cout << "Selesai dalam waktu : ";
    double t = tmr.elapsed();
    cout << t << std::endl;
}
