#include <iostream>

#include "../greeter/greeter.h"
#include "../PrimitiveMarshaling/calculator.h"
#include "../PrimitiveMarshaling/strings.h"

using namespace std;

int main()
{
    Greet();
    int a = 2;
    int b = 5;

    cout << a << " + " << b << " = " << Add(a, b) << endl;

    cout << (IsLengthGreaterThan("test123", 5) ? "true" : "false") << endl;

    cout << GetName() << endl;

    return 0;
}