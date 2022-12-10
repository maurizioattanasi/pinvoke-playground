#include <iostream>
#include "greeter.h"

using namespace std;

namespace NativeLibrary
{
    Greeter::Greeter(/* args */)
    {
    }

    Greeter::~Greeter()
    {
    }

    void Greeter::Greet()
    {
        cout << "Hello, world!" << endl;
    }
}