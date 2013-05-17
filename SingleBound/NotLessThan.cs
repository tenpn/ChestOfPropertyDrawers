using UnityEngine;
using System;

/*

will stop the the user entering a value below this bound

*/
public class NotLessThan : PropertyAttribute 
{
    public NotLessThan(int lowerBound) { IntLowerBound = lowerBound; }
    public NotLessThan(float lowerBound) { FloatLowerBound = lowerBound; }

    public int IntLowerBound { get; private set; }
    public float FloatLowerBound { get; private set; }

    public Type FixedType { get; private set; }

    //////////////////////////////////////////////////

    private float m_floatLowerBound;
    private float m_intLowerBound;

    //////////////////////////////////////////////////
}