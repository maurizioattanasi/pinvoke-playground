#include "strings.h"
#include <string.h>

static const char str[] = "Maurizio Attanasi";

bool IsLengthGreaterThan(const char *value, int len)
{
    return strlen(value) > len;
}

const char *GetName()
{
    return str;
}