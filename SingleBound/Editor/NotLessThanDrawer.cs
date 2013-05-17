using UnityEditor;
using UnityEngine;
using System;

// presents a normal edit box, but bounds it 
[CustomPropertyDrawer(typeof(NotLessThan))]
public class NotLessThanDrawer : PropertyDrawer
{

    public override void OnGUI (Rect position,
                                SerializedProperty prop,
                                GUIContent label) 
    {
        var bound = attribute as NotLessThan;
        
        if (prop.propertyType == SerializedPropertyType.Integer)
        {
            prop.intValue = Mathf.Max(EditorGUI.IntField(position, label, prop.intValue),
                                      bound.IntLowerBound);
        }
        else if (prop.propertyType == SerializedPropertyType.Float)
        {
            prop.floatValue = Mathf.Max(EditorGUI.FloatField(position, label, prop.floatValue),
                                        bound.FloatLowerBound);
        }
        else
        {
            throw new UnityException("property " + prop 
                                     + " must be int or float to use with NotMoreThan");
        }
    }
}