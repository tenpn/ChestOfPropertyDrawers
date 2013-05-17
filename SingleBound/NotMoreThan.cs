using UnityEngine;
using System;

/*

will stop the the user entering a value below this bound

*/
public class NotMoreThan : PropertyAttribute 
{
    public NotMoreThan(int upperBound) { IntUpperBound = upperBound; }
    public NotMoreThan(float upperBound) { FloatUpperBound = upperBound; }

    public int IntUpperBound { get; private set; }
    public float FloatUpperBound { get; private set; }
}