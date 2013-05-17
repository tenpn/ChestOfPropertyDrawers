using UnityEngine;
using System;

public class SingleBoundExamples : MonoBehaviour
{
    [NotMoreThan(3.0f)]
    public float NotMoreThan3f;

    [NotMoreThan(10)]
    public int NotMoreThan10;

    [NotLessThan(4f)]
    public float NotLessThan4f = 5f;

    [NotLessThan(-3)]
    public int NotLessThanMinus3;
}