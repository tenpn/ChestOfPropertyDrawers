
Bounds a float or an int to either a maximum or mimimum. For when you don't know a sensible value for the other half of a ranged property.

Presents int or float field just like normal, except value is bound.

Extensive error checking to make sure attributes and properties are always same type.

If anyone knows how to reduce duplication of code in the drawers, please have a hack!

usage:

    [NotLessThan(3)]
    int MyInt = 10;

    [NotMoreThan(100.0f)]
    float MyFloat = 45.0f;