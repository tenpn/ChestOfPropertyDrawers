
using UnityEngine;
using System;

public class DropdownSubtypesOfExample : MonoBehaviour
{
    [DropdownSubtypesOf(typeof(PropertyAttribute))]
    public string MyType;
}