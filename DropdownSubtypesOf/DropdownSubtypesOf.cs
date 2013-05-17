
using UnityEngine;
using System;

/*

this attribute says you want a dropdox of all subtypes of basetype,
which will be stored as a string in the property.

usage:

[DropdownSubtypesOf(typeof(BaseType))]
[SerializeField] private string m_type;

m_type will contain the string name of the type selected in the dropdown.

*/
public class DropdownSubtypesOf : PropertyAttribute 
{
    public DropdownSubtypesOf(Type baseType)
    {
        BaseType = baseType;
    }

    public Type BaseType { get; private set; }

    //////////////////////////////////////////////////

    //////////////////////////////////////////////////
}