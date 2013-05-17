using UnityEngine;
using System;

/*

will stop the the user entering a value above this bound

*/
public class NotMoreThan : SingleBound
{
    public NotMoreThan(int upperBound) { IntBound = upperBound; }
    public NotMoreThan(float upperBound) { FloatBound = upperBound; }
}