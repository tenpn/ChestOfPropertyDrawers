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

        try
        {
            if (prop.propertyType == SerializedPropertyType.Integer)
            {
                prop.intValue = Mathf.Min(EditorGUI.IntField(position, label, prop.intValue),
                                          bound.IntBound);
            }
            else if (prop.propertyType == SerializedPropertyType.Float)
            {
                prop.floatValue = Mathf.Min(EditorGUI.FloatField(
                                                position, label, prop.floatValue),
                                            bound.FloatBound);
            }
            else
            {
                throw new UnityException(
                    "must be int or float property to use with NotMoreThan");
            }
        }
        catch (UnityException e)
        {
            throw new UnityException("error on NotMoreThan attribute of property " 
                                     + prop.name + "\n" + e.ToString());
        }
    }
}