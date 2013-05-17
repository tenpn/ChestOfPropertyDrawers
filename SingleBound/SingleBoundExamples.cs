using UnityEngine;
using System;

public class SingleBoundExamples : MonoBehaviour
{
    [NotMoreThan(3.0f)]
    public float NotMoreThan3f;

    [NotMoreThan(10)]
    public int NotMoreThan10;
}