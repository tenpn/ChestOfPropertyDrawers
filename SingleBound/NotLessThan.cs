using UnityEngine;
using System;

/*

will stop the the user entering a value below this bound

*/
public class NotLessThan : SingleBound
{
    public NotLessThan(int lowerBound) { IntBound = lowerBound; }
    public NotLessThan(float lowerBound) { FloatBound = lowerBound; }
}