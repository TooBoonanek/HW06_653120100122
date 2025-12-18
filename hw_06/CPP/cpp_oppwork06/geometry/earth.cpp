#include <iostream>

using namespace std;

class Earth {
    public:
        double G = 6.673e-11;
        double Radius = 6.3781e6;
        double Mass = 5.97e24; 

        void EarthInfo(){
            cout << "Earth: G = " << G << ", Radius = " << Radius << ", Mass = " << Mass << endl;
        }
};  