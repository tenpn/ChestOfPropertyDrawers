
using UnityEditor;
using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

// draws a dropdown containing all subtypes
// of the base type contained in DropdownSubtypesOf.
[CustomPropertyDrawer (typeof (DropdownSubtypesOf))]
public class DropdownSubtypesDrawer : PropertyDrawer
{
    public static IEnumerable<System.Type> FindSubclassesOf(System.Type t) 
    {
        var subclasses = new List<System.Type>();
        foreach(var asm in System.AppDomain.CurrentDomain.GetAssemblies()) 
        {
            foreach (var type in asm.GetTypes()) 
            {
                if (type.IsAbstract == false && t.IsAssignableFrom(type)) 
                {
                    subclasses.Add(type);
                }
            }
        }
        return subclasses;
    }




    public override void OnGUI (Rect position,
                                SerializedProperty prop,
                                GUIContent label) 
    {
        if(prop.propertyType != SerializedPropertyType.String)
        {
            throw new UnityException("property " + prop 
                                     + " must be string to use with DropdownSubtypesOf");
        }
                    

        var popupRect = EditorGUI.PrefixLabel(position, 
                                              GUIUtility.GetControlID(FocusType.Passive),
                                              label);

        var baseType = SubtypesAttribute.BaseType;

        var subclasses = FindSubclassesOf(baseType).Select(t => t.Name).ToArray();

        var currentClassName = prop.stringValue;
        var currentClassIndex = subclasses.Length - 1;
        for(; currentClassIndex >= 0; --currentClassIndex)
        {
            if (subclasses[currentClassIndex] == currentClassName)
            {
                break;
            }
        }

        int newClassIndex = EditorGUI.Popup(popupRect, currentClassIndex, subclasses);
        
        prop.stringValue = newClassIndex < 0 ? "" : subclasses[newClassIndex];
    }


    //////////////////////////////////////////////////

    private DropdownSubtypesOf SubtypesAttribute 
    { 
        get { return attribute as DropdownSubtypesOf; } 
    }

    //////////////////////////////////////////////////

}