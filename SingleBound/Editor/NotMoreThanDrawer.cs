using UnityEditor;
using UnityEngine;
using System;

// presents a normal edit box, but bounds it 
[CustomPropertyDrawer(typeof(NotMoreThan))]
public class NotMoreThanDrawer : PropertyDrawer
{

    public override void OnGUI (Rect position,
                                SerializedProperty prop,
                                GUIContent label) 
    {
        var bound = attribute as NotMoreThan;
        
        if (prop.propertyType == SerializedPropertyType.Integer)
        {
            prop.intValue = Mathf.Min(EditorGUI.IntField(position, label, prop.intValue),
                                      bound.IntUpperBound);
        }
        else if (prop.propertyType == SerializedPropertyType.Float)
        {
            prop.floatValue = Mathf.Min(EditorGUI.FloatField(position, label, prop.floatValue),
                                        bound.FloatUpperBound);
        }
        else
        {
            throw new UnityException("property " + prop 
                                     + " must be int or float to use with NotMoreThan");
        }
    }
}